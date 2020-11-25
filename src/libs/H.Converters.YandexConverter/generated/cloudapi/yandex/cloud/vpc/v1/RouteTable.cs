// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/vpc/v1/route_table.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Vpc.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/vpc/v1/route_table.proto</summary>
  internal static partial class RouteTableReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/vpc/v1/route_table.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RouteTableReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV5YW5kZXgvY2xvdWQvdnBjL3YxL3JvdXRlX3RhYmxlLnByb3RvEhN5YW5k",
            "ZXguY2xvdWQudnBjLnYxGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnBy",
            "b3RvIrcCCgpSb3V0ZVRhYmxlEgoKAmlkGAEgASgJEhEKCWZvbGRlcl9pZBgC",
            "IAEoCRIuCgpjcmVhdGVkX2F0GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
            "bWVzdGFtcBIMCgRuYW1lGAQgASgJEhMKC2Rlc2NyaXB0aW9uGAUgASgJEjsK",
            "BmxhYmVscxgGIAMoCzIrLnlhbmRleC5jbG91ZC52cGMudjEuUm91dGVUYWJs",
            "ZS5MYWJlbHNFbnRyeRISCgpuZXR3b3JrX2lkGAcgASgJEjcKDXN0YXRpY19y",
            "b3V0ZXMYCCADKAsyIC55YW5kZXguY2xvdWQudnBjLnYxLlN0YXRpY1JvdXRl",
            "Gi0KC0xhYmVsc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToC",
            "OAEizwEKC1N0YXRpY1JvdXRlEhwKEmRlc3RpbmF0aW9uX3ByZWZpeBgBIAEo",
            "CUgAEhoKEG5leHRfaG9wX2FkZHJlc3MYAiABKAlIARI8CgZsYWJlbHMYAyAD",
            "KAsyLC55YW5kZXguY2xvdWQudnBjLnYxLlN0YXRpY1JvdXRlLkxhYmVsc0Vu",
            "dHJ5Gi0KC0xhYmVsc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEo",
            "CToCOAFCDQoLZGVzdGluYXRpb25CCgoIbmV4dF9ob3BCVgoXeWFuZGV4LmNs",
            "b3VkLmFwaS52cGMudjFaO2dpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdl",
            "bnByb3RvL3lhbmRleC9jbG91ZC92cGMvdjE7dnBjYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Vpc.V1.RouteTable), global::Yandex.Cloud.Vpc.V1.RouteTable.Parser, new[]{ "Id", "FolderId", "CreatedAt", "Name", "Description", "Labels", "NetworkId", "StaticRoutes" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Vpc.V1.StaticRoute), global::Yandex.Cloud.Vpc.V1.StaticRoute.Parser, new[]{ "DestinationPrefix", "NextHopAddress", "Labels" }, new[]{ "Destination", "NextHop" }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A RouteTable resource. For more information, see [Static Routes](/docs/vpc/concepts/static-routes).
  /// </summary>
  internal sealed partial class RouteTable : pb::IMessage<RouteTable> {
    private static readonly pb::MessageParser<RouteTable> _parser = new pb::MessageParser<RouteTable>(() => new RouteTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RouteTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Vpc.V1.RouteTableReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RouteTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RouteTable(RouteTable other) : this() {
      id_ = other.id_;
      folderId_ = other.folderId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      labels_ = other.labels_.Clone();
      networkId_ = other.networkId_;
      staticRoutes_ = other.staticRoutes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RouteTable Clone() {
      return new RouteTable(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the route table.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "folder_id" field.</summary>
    public const int FolderIdFieldNumber = 2;
    private string folderId_ = "";
    /// <summary>
    /// ID of the folder that the route table belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FolderId {
      get { return folderId_; }
      set {
        folderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Creation timestamp in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    /// Name of the route table. The name is unique within the project. 3-63 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    /// <summary>
    /// Optional description of the route table. 0-256 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Resource labels as `` key:value `` pairs. Мaximum of 64 per resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "network_id" field.</summary>
    public const int NetworkIdFieldNumber = 7;
    private string networkId_ = "";
    /// <summary>
    /// ID of the network the route table belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NetworkId {
      get { return networkId_; }
      set {
        networkId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "static_routes" field.</summary>
    public const int StaticRoutesFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Vpc.V1.StaticRoute> _repeated_staticRoutes_codec
        = pb::FieldCodec.ForMessage(66, global::Yandex.Cloud.Vpc.V1.StaticRoute.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Vpc.V1.StaticRoute> staticRoutes_ = new pbc::RepeatedField<global::Yandex.Cloud.Vpc.V1.StaticRoute>();
    /// <summary>
    /// List of static routes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Vpc.V1.StaticRoute> StaticRoutes {
      get { return staticRoutes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RouteTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RouteTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (FolderId != other.FolderId) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (NetworkId != other.NetworkId) return false;
      if(!staticRoutes_.Equals(other.staticRoutes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (FolderId.Length != 0) hash ^= FolderId.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (NetworkId.Length != 0) hash ^= NetworkId.GetHashCode();
      hash ^= staticRoutes_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (FolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FolderId);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreatedAt);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (NetworkId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(NetworkId);
      }
      staticRoutes_.WriteTo(output, _repeated_staticRoutes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (FolderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FolderId);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (NetworkId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NetworkId);
      }
      size += staticRoutes_.CalculateSize(_repeated_staticRoutes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RouteTable other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.FolderId.Length != 0) {
        FolderId = other.FolderId;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      labels_.Add(other.labels_);
      if (other.NetworkId.Length != 0) {
        NetworkId = other.NetworkId;
      }
      staticRoutes_.Add(other.staticRoutes_);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            FolderId = input.ReadString();
            break;
          }
          case 26: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            NetworkId = input.ReadString();
            break;
          }
          case 66: {
            staticRoutes_.AddEntriesFrom(input, _repeated_staticRoutes_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A StaticRoute resource. For more information, see [Static Routes](/docs/vpc/concepts/static-routes).
  /// </summary>
  internal sealed partial class StaticRoute : pb::IMessage<StaticRoute> {
    private static readonly pb::MessageParser<StaticRoute> _parser = new pb::MessageParser<StaticRoute>(() => new StaticRoute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StaticRoute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Vpc.V1.RouteTableReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaticRoute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaticRoute(StaticRoute other) : this() {
      labels_ = other.labels_.Clone();
      switch (other.DestinationCase) {
        case DestinationOneofCase.DestinationPrefix:
          DestinationPrefix = other.DestinationPrefix;
          break;
      }

      switch (other.NextHopCase) {
        case NextHopOneofCase.NextHopAddress:
          NextHopAddress = other.NextHopAddress;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaticRoute Clone() {
      return new StaticRoute(this);
    }

    /// <summary>Field number for the "destination_prefix" field.</summary>
    public const int DestinationPrefixFieldNumber = 1;
    /// <summary>
    /// Destination subnet in CIDR notation
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DestinationPrefix {
      get { return destinationCase_ == DestinationOneofCase.DestinationPrefix ? (string) destination_ : ""; }
      set {
        destination_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        destinationCase_ = DestinationOneofCase.DestinationPrefix;
      }
    }

    /// <summary>Field number for the "next_hop_address" field.</summary>
    public const int NextHopAddressFieldNumber = 2;
    /// <summary>
    /// Next hop IP address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextHopAddress {
      get { return nextHopCase_ == NextHopOneofCase.NextHopAddress ? (string) nextHop_ : ""; }
      set {
        nextHop_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        nextHopCase_ = NextHopOneofCase.NextHopAddress;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 26);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Resource labels as `` key:value `` pairs. Мaximum of 64 per resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    private object destination_;
    /// <summary>Enum of possible cases for the "destination" oneof.</summary>
    public enum DestinationOneofCase {
      None = 0,
      DestinationPrefix = 1,
    }
    private DestinationOneofCase destinationCase_ = DestinationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DestinationOneofCase DestinationCase {
      get { return destinationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDestination() {
      destinationCase_ = DestinationOneofCase.None;
      destination_ = null;
    }

    private object nextHop_;
    /// <summary>Enum of possible cases for the "next_hop" oneof.</summary>
    public enum NextHopOneofCase {
      None = 0,
      NextHopAddress = 2,
    }
    private NextHopOneofCase nextHopCase_ = NextHopOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NextHopOneofCase NextHopCase {
      get { return nextHopCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearNextHop() {
      nextHopCase_ = NextHopOneofCase.None;
      nextHop_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StaticRoute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StaticRoute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DestinationPrefix != other.DestinationPrefix) return false;
      if (NextHopAddress != other.NextHopAddress) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (DestinationCase != other.DestinationCase) return false;
      if (NextHopCase != other.NextHopCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (destinationCase_ == DestinationOneofCase.DestinationPrefix) hash ^= DestinationPrefix.GetHashCode();
      if (nextHopCase_ == NextHopOneofCase.NextHopAddress) hash ^= NextHopAddress.GetHashCode();
      hash ^= Labels.GetHashCode();
      hash ^= (int) destinationCase_;
      hash ^= (int) nextHopCase_;
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
      if (destinationCase_ == DestinationOneofCase.DestinationPrefix) {
        output.WriteRawTag(10);
        output.WriteString(DestinationPrefix);
      }
      if (nextHopCase_ == NextHopOneofCase.NextHopAddress) {
        output.WriteRawTag(18);
        output.WriteString(NextHopAddress);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (destinationCase_ == DestinationOneofCase.DestinationPrefix) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DestinationPrefix);
      }
      if (nextHopCase_ == NextHopOneofCase.NextHopAddress) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextHopAddress);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StaticRoute other) {
      if (other == null) {
        return;
      }
      labels_.Add(other.labels_);
      switch (other.DestinationCase) {
        case DestinationOneofCase.DestinationPrefix:
          DestinationPrefix = other.DestinationPrefix;
          break;
      }

      switch (other.NextHopCase) {
        case NextHopOneofCase.NextHopAddress:
          NextHopAddress = other.NextHopAddress;
          break;
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
            DestinationPrefix = input.ReadString();
            break;
          }
          case 18: {
            NextHopAddress = input.ReadString();
            break;
          }
          case 26: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
