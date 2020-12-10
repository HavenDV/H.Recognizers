using System;
using System.Linq;
using System.Threading.Tasks;
using H.NET.Converters.IntegrationTests.Utilities;
using H.Core;
using H.Core.Converters;
using H.Core.Recorders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H.Converters.IntegrationTests
{
    public static class BaseConvertersTests
    {
        public static async Task StartStreamingRecognitionTest(IConverter converter, string name, string expected, int bytesPerWrite = 8000)
        {
            using var recognition = await converter.StartStreamingRecognitionAsync();
            recognition.PartialResultsReceived += (_, value) => Console.WriteLine($"{DateTime.Now:h:mm:ss.fff} AfterPartialResults: {value}");
            recognition.FinalResultsReceived += (_, value) =>
            {
                Console.WriteLine($"{DateTime.Now:h:mm:ss.fff} AfterFinalResults: {value}");

                Assert.AreEqual(expected, value);
            };

            var bytes = ResourcesUtilities.ReadFileAsBytes(name);
            // 44 - is default wav header length
            for (var i = 44; i < bytes.Length; i += bytesPerWrite)
            {
                var chunk = new ArraySegment<byte>(bytes, i, i < bytes.Length - bytesPerWrite ? bytesPerWrite : bytes.Length - i).ToArray();
                await recognition.WriteAsync(chunk);

                await Task.Delay(TimeSpan.FromMilliseconds(500));
            }

            await recognition.StopAsync();
        }

        public static async Task StartStreamingRecognitionTest_RealTime(IRecorder recorder, IConverter converter, bool writeWavHeader = false)
        {
            await recorder.InitializeAsync();
            await recorder.StartAsync();

            using var recognition = await converter.StartStreamingRecognitionAsync();
            recognition.PartialResultsReceived += (_, value) => Console.WriteLine($"{DateTime.Now:h:mm:ss.fff} AfterPartialResults: {value}");
            recognition.FinalResultsReceived += (_, value) => Console.WriteLine($"{DateTime.Now:h:mm:ss.fff} AfterFinalResults: {value}");

            if (writeWavHeader)
            {
                await recognition.WriteAsync(recorder.WavHeader);
            }
            if (recorder.RawData.Any())
            {
                await recognition.WriteAsync(recorder.RawData);
            }

            // ReSharper disable once AccessToDisposedClosure
            recorder.RawDataReceived += async (_, bytes) =>
            {
                await recognition.WriteAsync(bytes);
            };

            await Task.Delay(TimeSpan.FromMilliseconds(5000));

            await recorder.StopAsync();
            await recognition.StopAsync();
        }

        public static async Task ConvertTest(IConverter converter, string name, string expected)
        {
            var bytes = ResourcesUtilities.ReadFileAsBytes(name);
            var actual = await converter.ConvertAsync(bytes);

            Assert.AreEqual(expected, actual);
        }

        public static async Task ConvertTest_RealTime(IRecorder recorder, IConverter converter)
        {
            await recorder.InitializeAsync();
            await recorder.StartAsync();

            await Task.Delay(TimeSpan.FromMilliseconds(5000));

            await recorder.StopAsync();

            var bytes = recorder.WavData;
            Assert.IsNotNull(bytes, $"{nameof(bytes)} == null");

            var result = await converter.ConvertAsync(bytes);

            Console.WriteLine(result);
        }
    }
}
