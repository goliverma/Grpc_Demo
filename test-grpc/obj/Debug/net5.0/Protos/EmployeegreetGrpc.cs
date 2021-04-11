// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/employeegreet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace test_grpc {
  public static partial class EmployeeGreeter
  {
    static readonly string __ServiceName = "employeegreet.EmployeeGreeter";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::test_grpc.responseemp> __Marshaller_employeegreet_responseemp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::test_grpc.responseemp.Parser));
    static readonly grpc::Marshaller<global::test_grpc.replyemp> __Marshaller_employeegreet_replyemp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::test_grpc.replyemp.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::test_grpc.replyemps> __Marshaller_employeegreet_replyemps = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::test_grpc.replyemps.Parser));

    static readonly grpc::Method<global::test_grpc.responseemp, global::test_grpc.replyemp> __Method_getemploye = new grpc::Method<global::test_grpc.responseemp, global::test_grpc.replyemp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getemploye",
        __Marshaller_employeegreet_responseemp,
        __Marshaller_employeegreet_replyemp);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::test_grpc.replyemps> __Method_getemployes = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::test_grpc.replyemps>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getemployes",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_employeegreet_replyemps);

    static readonly grpc::Method<global::test_grpc.replyemp, global::Google.Protobuf.WellKnownTypes.Empty> __Method_updateemploye = new grpc::Method<global::test_grpc.replyemp, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updateemploye",
        __Marshaller_employeegreet_replyemp,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::test_grpc.EmployeegreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EmployeeGreeter</summary>
    [grpc::BindServiceMethod(typeof(EmployeeGreeter), "BindService")]
    public abstract partial class EmployeeGreeterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::test_grpc.replyemp> getemploye(global::test_grpc.responseemp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::test_grpc.replyemps> getemployes(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> updateemploye(global::test_grpc.replyemp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EmployeeGreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_getemploye, serviceImpl.getemploye)
          .AddMethod(__Method_getemployes, serviceImpl.getemployes)
          .AddMethod(__Method_updateemploye, serviceImpl.updateemploye).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EmployeeGreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_getemploye, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::test_grpc.responseemp, global::test_grpc.replyemp>(serviceImpl.getemploye));
      serviceBinder.AddMethod(__Method_getemployes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::test_grpc.replyemps>(serviceImpl.getemployes));
      serviceBinder.AddMethod(__Method_updateemploye, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::test_grpc.replyemp, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.updateemploye));
    }

  }
}
#endregion
