// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/resource_preset_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Clickhouse.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/clickhouse/v1/resource_preset_service.proto</summary>
  internal static partial class ResourcePresetServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/clickhouse/v1/resource_preset_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourcePresetServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjx5YW5kZXgvY2xvdWQvbWRiL2NsaWNraG91c2UvdjEvcmVzb3VyY2VfcHJl",
            "c2V0X3NlcnZpY2UucHJvdG8SHnlhbmRleC5jbG91ZC5tZGIuY2xpY2tob3Vz",
            "ZS52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxodeWFuZGV4L2Ns",
            "b3VkL3ZhbGlkYXRpb24ucHJvdG8aNHlhbmRleC9jbG91ZC9tZGIvY2xpY2to",
            "b3VzZS92MS9yZXNvdXJjZV9wcmVzZXQucHJvdG8iRAoYR2V0UmVzb3VyY2VQ",
            "cmVzZXRSZXF1ZXN0EigKEnJlc291cmNlX3ByZXNldF9pZBgBIAEoCUIM6Mcx",
            "AYrIMQQ8PTUwIloKGkxpc3RSZXNvdXJjZVByZXNldHNSZXF1ZXN0Eh0KCXBh",
            "Z2Vfc2l6ZRgCIAEoA0IK+scxBjw9MTAwMBIdCgpwYWdlX3Rva2VuGAMgASgJ",
            "QgmKyDEFPD0xMDAigAEKG0xpc3RSZXNvdXJjZVByZXNldHNSZXNwb25zZRJI",
            "ChByZXNvdXJjZV9wcmVzZXRzGAEgAygLMi4ueWFuZGV4LmNsb3VkLm1kYi5j",
            "bGlja2hvdXNlLnYxLlJlc291cmNlUHJlc2V0EhcKD25leHRfcGFnZV90b2tl",
            "bhgCIAEoCTKAAwoVUmVzb3VyY2VQcmVzZXRTZXJ2aWNlErQBCgNHZXQSOC55",
            "YW5kZXguY2xvdWQubWRiLmNsaWNraG91c2UudjEuR2V0UmVzb3VyY2VQcmVz",
            "ZXRSZXF1ZXN0Gi4ueWFuZGV4LmNsb3VkLm1kYi5jbGlja2hvdXNlLnYxLlJl",
            "c291cmNlUHJlc2V0IkOC0+STAj0SOy9tYW5hZ2VkLWNsaWNraG91c2UvdjEv",
            "cmVzb3VyY2VQcmVzZXRzL3tyZXNvdXJjZV9wcmVzZXRfaWR9Eq8BCgRMaXN0",
            "EjoueWFuZGV4LmNsb3VkLm1kYi5jbGlja2hvdXNlLnYxLkxpc3RSZXNvdXJj",
            "ZVByZXNldHNSZXF1ZXN0GjsueWFuZGV4LmNsb3VkLm1kYi5jbGlja2hvdXNl",
            "LnYxLkxpc3RSZXNvdXJjZVByZXNldHNSZXNwb25zZSIugtPkkwIoEiYvbWFu",
            "YWdlZC1jbGlja2hvdXNlL3YxL3Jlc291cmNlUHJlc2V0c0JzCiJ5YW5kZXgu",
            "Y2xvdWQuYXBpLm1kYi5jbGlja2hvdXNlLnYxWk1naXRodWIuY29tL3lhbmRl",
            "eC1jbG91ZC9nby1nZW5wcm90by95YW5kZXgvY2xvdWQvbWRiL2NsaWNraG91",
            "c2UvdjE7Y2xpY2tob3VzZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest), global::Yandex.Cloud.Mdb.Clickhouse.V1.GetResourcePresetRequest.Parser, new[]{ "ResourcePresetId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsRequest.Parser, new[]{ "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListResourcePresetsResponse.Parser, new[]{ "ResourcePresets", "NextPageToken" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class GetResourcePresetRequest : pb::IMessage<GetResourcePresetRequest> {
    private static readonly pb::MessageParser<GetResourcePresetRequest> _parser = new pb::MessageParser<GetResourcePresetRequest>(() => new GetResourcePresetRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetResourcePresetRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResourcePresetRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResourcePresetRequest(GetResourcePresetRequest other) : this() {
      resourcePresetId_ = other.resourcePresetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResourcePresetRequest Clone() {
      return new GetResourcePresetRequest(this);
    }

    /// <summary>Field number for the "resource_preset_id" field.</summary>
    public const int ResourcePresetIdFieldNumber = 1;
    private string resourcePresetId_ = "";
    /// <summary>
    /// ID of the resource preset to return.
    /// To get the resource preset ID, use a [ResourcePresetService.List] request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourcePresetId {
      get { return resourcePresetId_; }
      set {
        resourcePresetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetResourcePresetRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetResourcePresetRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourcePresetId != other.ResourcePresetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourcePresetId.Length != 0) hash ^= ResourcePresetId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourcePresetId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourcePresetId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourcePresetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourcePresetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetResourcePresetRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourcePresetId.Length != 0) {
        ResourcePresetId = other.ResourcePresetId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourcePresetId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListResourcePresetsRequest : pb::IMessage<ListResourcePresetsRequest> {
    private static readonly pb::MessageParser<ListResourcePresetsRequest> _parser = new pb::MessageParser<ListResourcePresetsRequest>(() => new ListResourcePresetsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListResourcePresetsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListResourcePresetsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListResourcePresetsRequest(ListResourcePresetsRequest other) : this() {
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListResourcePresetsRequest Clone() {
      return new ListResourcePresetsRequest(this);
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private long pageSize_;
    /// <summary>
    /// The maximum number of results per page to return. If the number of available
    /// results is larger than [page_size], the service returns a [ListResourcePresetsResponse.next_page_token]
    /// that can be used to get the next page of results in subsequent list requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 3;
    private string pageToken_ = "";
    /// <summary>
    /// Page token. To get the next page of results, Set [page_token] to the [ListResourcePresetsResponse.next_page_token]
    /// returned by a previous list request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListResourcePresetsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListResourcePresetsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PageSize != 0L) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PageSize != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PageSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListResourcePresetsRequest other) {
      if (other == null) {
        return;
      }
      if (other.PageSize != 0L) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 16: {
            PageSize = input.ReadInt64();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListResourcePresetsResponse : pb::IMessage<ListResourcePresetsResponse> {
    private static readonly pb::MessageParser<ListResourcePresetsResponse> _parser = new pb::MessageParser<ListResourcePresetsResponse>(() => new ListResourcePresetsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListResourcePresetsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePresetServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListResourcePresetsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListResourcePresetsResponse(ListResourcePresetsResponse other) : this() {
      resourcePresets_ = other.resourcePresets_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListResourcePresetsResponse Clone() {
      return new ListResourcePresetsResponse(this);
    }

    /// <summary>Field number for the "resource_presets" field.</summary>
    public const int ResourcePresetsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> _repeated_resourcePresets_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> resourcePresets_ = new pbc::RepeatedField<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset>();
    /// <summary>
    /// List of ResourcePreset resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Mdb.Clickhouse.V1.ResourcePreset> ResourcePresets {
      get { return resourcePresets_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// This token allows you to get the next page of results for list requests. If the number of results
    /// is larger than [ListResourcePresetsRequest.page_size], use the [next_page_token] as the value
    /// for the [ListResourcePresetsRequest.page_token] parameter in the next list request. Each subsequent
    /// list request will have its own [next_page_token] to continue paging through the results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListResourcePresetsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListResourcePresetsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!resourcePresets_.Equals(other.resourcePresets_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= resourcePresets_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      resourcePresets_.WriteTo(output, _repeated_resourcePresets_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += resourcePresets_.CalculateSize(_repeated_resourcePresets_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListResourcePresetsResponse other) {
      if (other == null) {
        return;
      }
      resourcePresets_.Add(other.resourcePresets_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            resourcePresets_.AddEntriesFrom(input, _repeated_resourcePresets_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
