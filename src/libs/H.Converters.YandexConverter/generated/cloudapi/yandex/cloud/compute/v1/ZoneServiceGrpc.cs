// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/compute/v1/zone_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Compute.V1 {
  /// <summary>
  /// A set of methods to retrieve information about availability zones.
  /// </summary>
  internal static partial class ZoneService
  {
    static readonly string __ServiceName = "yandex.cloud.compute.v1.ZoneService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.GetZoneRequest> __Marshaller_yandex_cloud_compute_v1_GetZoneRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.GetZoneRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.Zone> __Marshaller_yandex_cloud_compute_v1_Zone = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.Zone.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListZonesRequest> __Marshaller_yandex_cloud_compute_v1_ListZonesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListZonesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListZonesResponse> __Marshaller_yandex_cloud_compute_v1_ListZonesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListZonesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.GetZoneRequest, global::Yandex.Cloud.Compute.V1.Zone> __Method_Get = new grpc::Method<global::Yandex.Cloud.Compute.V1.GetZoneRequest, global::Yandex.Cloud.Compute.V1.Zone>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_compute_v1_GetZoneRequest,
        __Marshaller_yandex_cloud_compute_v1_Zone);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.ListZonesRequest, global::Yandex.Cloud.Compute.V1.ListZonesResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Compute.V1.ListZonesRequest, global::Yandex.Cloud.Compute.V1.ListZonesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_compute_v1_ListZonesRequest,
        __Marshaller_yandex_cloud_compute_v1_ListZonesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Compute.V1.ZoneServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ZoneService</summary>
    public partial class ZoneServiceClient : grpc::ClientBase<ZoneServiceClient>
    {
      /// <summary>Creates a new client for ZoneService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZoneServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ZoneService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZoneServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZoneServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZoneServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the information about the specified availability zone.
      ///
      /// To get the list of availability zones, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.Zone Get(global::Yandex.Cloud.Compute.V1.GetZoneRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the information about the specified availability zone.
      ///
      /// To get the list of availability zones, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.Zone Get(global::Yandex.Cloud.Compute.V1.GetZoneRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the information about the specified availability zone.
      ///
      /// To get the list of availability zones, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.Zone> GetAsync(global::Yandex.Cloud.Compute.V1.GetZoneRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the information about the specified availability zone.
      ///
      /// To get the list of availability zones, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.Zone> GetAsync(global::Yandex.Cloud.Compute.V1.GetZoneRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of availability zones.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListZonesResponse List(global::Yandex.Cloud.Compute.V1.ListZonesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of availability zones.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListZonesResponse List(global::Yandex.Cloud.Compute.V1.ListZonesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of availability zones.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListZonesResponse> ListAsync(global::Yandex.Cloud.Compute.V1.ListZonesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of availability zones.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListZonesResponse> ListAsync(global::Yandex.Cloud.Compute.V1.ListZonesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZoneServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZoneServiceClient(configuration);
      }
    }

  }
}
#endregion
