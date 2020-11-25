// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/resource_preset_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Mdb.Clickhouse.V1 {
  /// <summary>
  /// A set of methods for managing ResourcePreset resources.
  /// </summary>
  internal static partial class ResourcePresetService
  {
    static readonly string __ServiceName = "yandex.cloud.mdb.clickhouse.v1.ResourcePresetService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_GetResourcePresetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ResourcePreset = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListResourcePresetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListResourcePresetsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> __Method_Get = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_GetResourcePresetRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ResourcePreset);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListResourcePresetsRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListResourcePresetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ResourcePresetService</summary>
    public partial class ResourcePresetServiceClient : grpc::ClientBase<ResourcePresetServiceClient>
    {
      /// <summary>Creates a new client for ResourcePresetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ResourcePresetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ResourcePresetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ResourcePresetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ResourcePresetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ResourcePresetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified ResourcePreset resource.
      ///
      /// To get the list of available ResourcePreset resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset Get(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified ResourcePreset resource.
      ///
      /// To get the list of available ResourcePreset resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset Get(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified ResourcePreset resource.
      ///
      /// To get the list of available ResourcePreset resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> GetAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified ResourcePreset resource.
      ///
      /// To get the list of available ResourcePreset resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> GetAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of available ResourcePreset resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of available ResourcePreset resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of available ResourcePreset resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of available ResourcePreset resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ResourcePresetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ResourcePresetServiceClient(configuration);
      }
    }

  }
}
#endregion
