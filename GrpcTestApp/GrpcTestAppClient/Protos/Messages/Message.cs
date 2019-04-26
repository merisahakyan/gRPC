// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Messages {

  /// <summary>Holder for reflection information generated from Message.proto</summary>
  public static partial class MessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1NZXNzYWdlLnByb3RvIlAKCEVtcGxveWVlEgoKAmlkGAEgASgFEhMKC2Jh",
            "ZGdlTnVtYmVyGAIgASgFEhEKCWZpcnN0bmFtZRgDIAEoCRIQCghsYXN0bmFt",
            "ZRgEIAEoCSIPCg1HZXRBbGxSZXF1ZXN0Ii4KF0dldEJ5QmFkZ2VOdW1iZXJS",
            "ZXF1ZXN0EhMKC2JhZGdlTnVtYmVyGAEgASgFIi0KDkVtcG9sZWVSZXF1ZXN0",
            "EhsKCGVtcGxveWVlGAEgASgLMgkuRW1wbG95ZWUiLgoPRW1wb2xlZVJlc3Bv",
            "bnNlEhsKCGVtcGxveWVlGAEgASgLMgkuRW1wbG95ZWUiHwoPQWRkUGhvdG9S",
            "ZXF1ZXN0EgwKBGRhdGEYASABKAwiIAoQQWRkUGhvdG9SZXNwb25zZRIMCgRp",
            "c09rGAEgASgIMo8CCg9FbXBsb3llZVNlcnZpY2USPgoQR2V0QnlCYWRnZU51",
            "bWJlchIYLkdldEJ5QmFkZ2VOdW1iZXJSZXF1ZXN0GhAuRW1wb2xlZVJlc3Bv",
            "bnNlEiwKBkdldEFsbBIOLkdldEFsbFJlcXVlc3QaEC5FbXBvbGVlUmVzcG9u",
            "c2UwARIpCgRTYXZlEg8uRW1wb2xlZVJlcXVlc3QaEC5FbXBvbGVlUmVzcG9u",
            "c2USMAoHU2F2ZUFsbBIPLkVtcG9sZWVSZXF1ZXN0GhAuRW1wb2xlZVJlc3Bv",
            "bnNlKAEwARIxCghBZGRQaG90bxIQLkFkZFBob3RvUmVxdWVzdBoRLkFkZFBo",
            "b3RvUmVzcG9uc2UoAUILqgIITWVzc2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.Employee), global::Messages.Employee.Parser, new[]{ "Id", "BadgeNumber", "Firstname", "Lastname" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.GetAllRequest), global::Messages.GetAllRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.GetByBadgeNumberRequest), global::Messages.GetByBadgeNumberRequest.Parser, new[]{ "BadgeNumber" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.EmpoleeRequest), global::Messages.EmpoleeRequest.Parser, new[]{ "Employee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.EmpoleeResponse), global::Messages.EmpoleeResponse.Parser, new[]{ "Employee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.AddPhotoRequest), global::Messages.AddPhotoRequest.Parser, new[]{ "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Messages.AddPhotoResponse), global::Messages.AddPhotoResponse.Parser, new[]{ "IsOk" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Employee : pb::IMessage<Employee> {
    private static readonly pb::MessageParser<Employee> _parser = new pb::MessageParser<Employee>(() => new Employee());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Employee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee(Employee other) : this() {
      id_ = other.id_;
      badgeNumber_ = other.badgeNumber_;
      firstname_ = other.firstname_;
      lastname_ = other.lastname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee Clone() {
      return new Employee(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "badgeNumber" field.</summary>
    public const int BadgeNumberFieldNumber = 2;
    private int badgeNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BadgeNumber {
      get { return badgeNumber_; }
      set {
        badgeNumber_ = value;
      }
    }

    /// <summary>Field number for the "firstname" field.</summary>
    public const int FirstnameFieldNumber = 3;
    private string firstname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Firstname {
      get { return firstname_; }
      set {
        firstname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastname" field.</summary>
    public const int LastnameFieldNumber = 4;
    private string lastname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Lastname {
      get { return lastname_; }
      set {
        lastname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Employee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Employee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (BadgeNumber != other.BadgeNumber) return false;
      if (Firstname != other.Firstname) return false;
      if (Lastname != other.Lastname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (BadgeNumber != 0) hash ^= BadgeNumber.GetHashCode();
      if (Firstname.Length != 0) hash ^= Firstname.GetHashCode();
      if (Lastname.Length != 0) hash ^= Lastname.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (BadgeNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BadgeNumber);
      }
      if (Firstname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Firstname);
      }
      if (Lastname.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Lastname);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (BadgeNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeNumber);
      }
      if (Firstname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Firstname);
      }
      if (Lastname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lastname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Employee other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.BadgeNumber != 0) {
        BadgeNumber = other.BadgeNumber;
      }
      if (other.Firstname.Length != 0) {
        Firstname = other.Firstname;
      }
      if (other.Lastname.Length != 0) {
        Lastname = other.Lastname;
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            BadgeNumber = input.ReadInt32();
            break;
          }
          case 26: {
            Firstname = input.ReadString();
            break;
          }
          case 34: {
            Lastname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetAllRequest : pb::IMessage<GetAllRequest> {
    private static readonly pb::MessageParser<GetAllRequest> _parser = new pb::MessageParser<GetAllRequest>(() => new GetAllRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest(GetAllRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest Clone() {
      return new GetAllRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllRequest other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class GetByBadgeNumberRequest : pb::IMessage<GetByBadgeNumberRequest> {
    private static readonly pb::MessageParser<GetByBadgeNumberRequest> _parser = new pb::MessageParser<GetByBadgeNumberRequest>(() => new GetByBadgeNumberRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetByBadgeNumberRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest(GetByBadgeNumberRequest other) : this() {
      badgeNumber_ = other.badgeNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest Clone() {
      return new GetByBadgeNumberRequest(this);
    }

    /// <summary>Field number for the "badgeNumber" field.</summary>
    public const int BadgeNumberFieldNumber = 1;
    private int badgeNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BadgeNumber {
      get { return badgeNumber_; }
      set {
        badgeNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetByBadgeNumberRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetByBadgeNumberRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BadgeNumber != other.BadgeNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BadgeNumber != 0) hash ^= BadgeNumber.GetHashCode();
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
      if (BadgeNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BadgeNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BadgeNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetByBadgeNumberRequest other) {
      if (other == null) {
        return;
      }
      if (other.BadgeNumber != 0) {
        BadgeNumber = other.BadgeNumber;
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
          case 8: {
            BadgeNumber = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmpoleeRequest : pb::IMessage<EmpoleeRequest> {
    private static readonly pb::MessageParser<EmpoleeRequest> _parser = new pb::MessageParser<EmpoleeRequest>(() => new EmpoleeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmpoleeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmpoleeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmpoleeRequest(EmpoleeRequest other) : this() {
      employee_ = other.employee_ != null ? other.employee_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmpoleeRequest Clone() {
      return new EmpoleeRequest(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private global::Messages.Employee employee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Messages.Employee Employee {
      get { return employee_; }
      set {
        employee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmpoleeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmpoleeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Employee, other.Employee)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (employee_ != null) hash ^= Employee.GetHashCode();
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
      if (employee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Employee);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (employee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Employee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmpoleeRequest other) {
      if (other == null) {
        return;
      }
      if (other.employee_ != null) {
        if (employee_ == null) {
          Employee = new global::Messages.Employee();
        }
        Employee.MergeFrom(other.Employee);
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
            if (employee_ == null) {
              Employee = new global::Messages.Employee();
            }
            input.ReadMessage(Employee);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmpoleeResponse : pb::IMessage<EmpoleeResponse> {
    private static readonly pb::MessageParser<EmpoleeResponse> _parser = new pb::MessageParser<EmpoleeResponse>(() => new EmpoleeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmpoleeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmpoleeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmpoleeResponse(EmpoleeResponse other) : this() {
      employee_ = other.employee_ != null ? other.employee_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmpoleeResponse Clone() {
      return new EmpoleeResponse(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private global::Messages.Employee employee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Messages.Employee Employee {
      get { return employee_; }
      set {
        employee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmpoleeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmpoleeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Employee, other.Employee)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (employee_ != null) hash ^= Employee.GetHashCode();
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
      if (employee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Employee);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (employee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Employee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmpoleeResponse other) {
      if (other == null) {
        return;
      }
      if (other.employee_ != null) {
        if (employee_ == null) {
          Employee = new global::Messages.Employee();
        }
        Employee.MergeFrom(other.Employee);
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
            if (employee_ == null) {
              Employee = new global::Messages.Employee();
            }
            input.ReadMessage(Employee);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddPhotoRequest : pb::IMessage<AddPhotoRequest> {
    private static readonly pb::MessageParser<AddPhotoRequest> _parser = new pb::MessageParser<AddPhotoRequest>(() => new AddPhotoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddPhotoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoRequest(AddPhotoRequest other) : this() {
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoRequest Clone() {
      return new AddPhotoRequest(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddPhotoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddPhotoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Data.Length != 0) hash ^= Data.GetHashCode();
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
      if (Data.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddPhotoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
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
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddPhotoResponse : pb::IMessage<AddPhotoResponse> {
    private static readonly pb::MessageParser<AddPhotoResponse> _parser = new pb::MessageParser<AddPhotoResponse>(() => new AddPhotoResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddPhotoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Messages.MessageReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoResponse(AddPhotoResponse other) : this() {
      isOk_ = other.isOk_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoResponse Clone() {
      return new AddPhotoResponse(this);
    }

    /// <summary>Field number for the "isOk" field.</summary>
    public const int IsOkFieldNumber = 1;
    private bool isOk_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsOk {
      get { return isOk_; }
      set {
        isOk_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddPhotoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddPhotoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOk != other.IsOk) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOk != false) hash ^= IsOk.GetHashCode();
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
      if (IsOk != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsOk);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsOk != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddPhotoResponse other) {
      if (other == null) {
        return;
      }
      if (other.IsOk != false) {
        IsOk = other.IsOk;
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
          case 8: {
            IsOk = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
