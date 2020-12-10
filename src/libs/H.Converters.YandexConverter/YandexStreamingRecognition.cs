﻿using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using H.Core.Converters;
using Yandex.Cloud.Ai.Stt.V2;

namespace H.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class YandexStreamingRecognition : StreamingRecognition
    {
        #region Properties

        private AsyncDuplexStreamingCall<StreamingRecognitionRequest, StreamingRecognitionResponse> Call { get; }

        private ConcurrentQueue<byte[]> WriteQueue { get; } = new ConcurrentQueue<byte[]>();
        private Task ReceiveTask { get; }
        private Task WriteTask { get; }
        private bool IsFinished { get; set; }

        #endregion

        #region Constructors

        internal YandexStreamingRecognition(AsyncDuplexStreamingCall<StreamingRecognitionRequest, StreamingRecognitionResponse> call)
        {
            Call = call ?? throw new ArgumentNullException(nameof(call));

            // TODO: Implement exception return
            ReceiveTask = Task.Run(async () =>
            {
                while (!IsFinished && await Call.ResponseStream.MoveNext().ConfigureAwait(false))
                {
                    var response = Call.ResponseStream.Current;
                    var chunk = response.Chunks
                        .LastOrDefault();
                    var text = chunk?
                        .Alternatives
                        .OrderBy(i => i.Confidence)
                        .FirstOrDefault()?
                        .Text;

                    if (chunk != null && text != null && !string.IsNullOrWhiteSpace(text))
                    {
                        if (chunk.Final)
                        {
                            IsFinished = true;
                            OnFinalResultsReceived(text);
                        }
                        else
                        {
                            OnPartialResultsReceived(text);
                        }
                    }

                    Trace.WriteLine($"{DateTime.Now:h:mm:ss.fff} YandexStreamingRecognition: {response}");
                }
            });
            WriteTask = Task.Run(async () =>
            {
                while (!IsFinished)
                {
                    // TODO: Combine all accumulated data in the queue into one message
                    if (!WriteQueue.TryDequeue(out var bytes))
                    {
                        await Task.Delay(TimeSpan.FromMilliseconds(1)).ConfigureAwait(false);
                        continue;
                    }

                    await Call.RequestStream.WriteAsync(new StreamingRecognitionRequest
                    {
                        AudioContent = ByteString.CopyFrom(bytes, 0, bytes.Length),
                    }).ConfigureAwait(false);
                }
            });
        }

        #endregion

        #region Public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task WriteAsync(byte[] bytes, CancellationToken cancellationToken = default)
        {
            WriteQueue.Enqueue(bytes);

            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task StopAsync(CancellationToken cancellationToken = default)
        {
            await WriteTask.ConfigureAwait(false);

            await Call.RequestStream.CompleteAsync().ConfigureAwait(false);

            await ReceiveTask.ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (IsDisposed)
            {
                return;
            }

            if (disposing)
            {
                ReceiveTask.Dispose();
                WriteTask.Dispose();
                Call.Dispose();
            }

            base.Dispose(disposing);
        }

        #endregion
    }
}
