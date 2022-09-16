//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/activity.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'activitycomment.g.dart';

/// Activitycomment
///
/// Properties:
/// * [idAc] 
/// * [commentAc] 
/// * [dateAc] 
/// * [askToCheckChatAc] 
/// * [idA1] 
/// * [idP5] 
/// * [idC5] 
/// * [idA1Navigation] 
/// * [idC5Navigation] 
/// * [idP5Navigation] 
@BuiltValue()
abstract class Activitycomment implements Built<Activitycomment, ActivitycommentBuilder> {
  @BuiltValueField(wireName: r'idAc')
  String? get idAc;

  @BuiltValueField(wireName: r'commentAc')
  String? get commentAc;

  @BuiltValueField(wireName: r'dateAc')
  DateTime? get dateAc;

  @BuiltValueField(wireName: r'askToCheckChatAc')
  bool? get askToCheckChatAc;

  @BuiltValueField(wireName: r'idA1')
  String? get idA1;

  @BuiltValueField(wireName: r'idP5')
  String? get idP5;

  @BuiltValueField(wireName: r'idC5')
  String? get idC5;

  @BuiltValueField(wireName: r'idA1Navigation')
  Activity? get idA1Navigation;

  @BuiltValueField(wireName: r'idC5Navigation')
  Client? get idC5Navigation;

  @BuiltValueField(wireName: r'idP5Navigation')
  Professional? get idP5Navigation;

  Activitycomment._();

  factory Activitycomment([void updates(ActivitycommentBuilder b)]) = _$Activitycomment;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ActivitycommentBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Activitycomment> get serializer => _$ActivitycommentSerializer();
}

class _$ActivitycommentSerializer implements PrimitiveSerializer<Activitycomment> {
  @override
  final Iterable<Type> types = const [Activitycomment, _$Activitycomment];

  @override
  final String wireName = r'Activitycomment';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Activitycomment object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idAc != null) {
      yield r'idAc';
      yield serializers.serialize(
        object.idAc,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.commentAc != null) {
      yield r'commentAc';
      yield serializers.serialize(
        object.commentAc,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.dateAc != null) {
      yield r'dateAc';
      yield serializers.serialize(
        object.dateAc,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.askToCheckChatAc != null) {
      yield r'askToCheckChatAc';
      yield serializers.serialize(
        object.askToCheckChatAc,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.idA1 != null) {
      yield r'idA1';
      yield serializers.serialize(
        object.idA1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP5 != null) {
      yield r'idP5';
      yield serializers.serialize(
        object.idP5,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC5 != null) {
      yield r'idC5';
      yield serializers.serialize(
        object.idC5,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idA1Navigation != null) {
      yield r'idA1Navigation';
      yield serializers.serialize(
        object.idA1Navigation,
        specifiedType: const FullType(Activity),
      );
    }
    if (object.idC5Navigation != null) {
      yield r'idC5Navigation';
      yield serializers.serialize(
        object.idC5Navigation,
        specifiedType: const FullType(Client),
      );
    }
    if (object.idP5Navigation != null) {
      yield r'idP5Navigation';
      yield serializers.serialize(
        object.idP5Navigation,
        specifiedType: const FullType(Professional),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Activitycomment object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ActivitycommentBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idAc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idAc = valueDes;
          break;
        case r'commentAc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.commentAc = valueDes;
          break;
        case r'dateAc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.dateAc = valueDes;
          break;
        case r'askToCheckChatAc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.askToCheckChatAc = valueDes;
          break;
        case r'idA1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idA1 = valueDes;
          break;
        case r'idP5':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP5 = valueDes;
          break;
        case r'idC5':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC5 = valueDes;
          break;
        case r'idA1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Activity),
          ) as Activity;
          result.idA1Navigation.replace(valueDes);
          break;
        case r'idC5Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Client),
          ) as Client;
          result.idC5Navigation.replace(valueDes);
          break;
        case r'idP5Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP5Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Activitycomment deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ActivitycommentBuilder();
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

