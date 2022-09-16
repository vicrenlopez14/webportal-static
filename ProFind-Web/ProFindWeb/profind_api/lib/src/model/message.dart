//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'message.g.dart';

/// Message
///
/// Properties:
/// * [idM] 
/// * [contentM] 
/// * [imageM] 
/// * [documentM] 
/// * [locationM] 
/// * [audioM] 
/// * [dateTimeM] 
/// * [idP4] 
/// * [idC4] 
/// * [idC4Navigation] 
/// * [idP4Navigation] 
@BuiltValue()
abstract class Message implements Built<Message, MessageBuilder> {
  @BuiltValueField(wireName: r'idM')
  String? get idM;

  @BuiltValueField(wireName: r'contentM')
  String? get contentM;

  @BuiltValueField(wireName: r'imageM')
  String? get imageM;

  @BuiltValueField(wireName: r'documentM')
  String? get documentM;

  @BuiltValueField(wireName: r'locationM')
  String? get locationM;

  @BuiltValueField(wireName: r'audioM')
  String? get audioM;

  @BuiltValueField(wireName: r'dateTimeM')
  DateTime? get dateTimeM;

  @BuiltValueField(wireName: r'idP4')
  String? get idP4;

  @BuiltValueField(wireName: r'idC4')
  String? get idC4;

  @BuiltValueField(wireName: r'idC4Navigation')
  Client? get idC4Navigation;

  @BuiltValueField(wireName: r'idP4Navigation')
  Professional? get idP4Navigation;

  Message._();

  factory Message([void updates(MessageBuilder b)]) = _$Message;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(MessageBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Message> get serializer => _$MessageSerializer();
}

class _$MessageSerializer implements PrimitiveSerializer<Message> {
  @override
  final Iterable<Type> types = const [Message, _$Message];

  @override
  final String wireName = r'Message';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Message object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idM != null) {
      yield r'idM';
      yield serializers.serialize(
        object.idM,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.contentM != null) {
      yield r'contentM';
      yield serializers.serialize(
        object.contentM,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.imageM != null) {
      yield r'imageM';
      yield serializers.serialize(
        object.imageM,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.documentM != null) {
      yield r'documentM';
      yield serializers.serialize(
        object.documentM,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.locationM != null) {
      yield r'locationM';
      yield serializers.serialize(
        object.locationM,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.audioM != null) {
      yield r'audioM';
      yield serializers.serialize(
        object.audioM,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.dateTimeM != null) {
      yield r'dateTimeM';
      yield serializers.serialize(
        object.dateTimeM,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.idP4 != null) {
      yield r'idP4';
      yield serializers.serialize(
        object.idP4,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC4 != null) {
      yield r'idC4';
      yield serializers.serialize(
        object.idC4,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC4Navigation != null) {
      yield r'idC4Navigation';
      yield serializers.serialize(
        object.idC4Navigation,
        specifiedType: const FullType(Client),
      );
    }
    if (object.idP4Navigation != null) {
      yield r'idP4Navigation';
      yield serializers.serialize(
        object.idP4Navigation,
        specifiedType: const FullType(Professional),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Message object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required MessageBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idM = valueDes;
          break;
        case r'contentM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.contentM = valueDes;
          break;
        case r'imageM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.imageM = valueDes;
          break;
        case r'documentM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.documentM = valueDes;
          break;
        case r'locationM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.locationM = valueDes;
          break;
        case r'audioM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.audioM = valueDes;
          break;
        case r'dateTimeM':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.dateTimeM = valueDes;
          break;
        case r'idP4':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP4 = valueDes;
          break;
        case r'idC4':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC4 = valueDes;
          break;
        case r'idC4Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Client),
          ) as Client;
          result.idC4Navigation.replace(valueDes);
          break;
        case r'idP4Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP4Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Message deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = MessageBuilder();
    final serializedList = (serialized as Iterable<Object?>).toList();
    final unhandled = <Object?>[];
    _deserializeProperties(
      serializers,
      serialized,
      specifiedType: specifiedType,
      serializedList: serializedList,
      unhandled: unhandled,
      result: result,
    );
    return result.build();
  }
}

