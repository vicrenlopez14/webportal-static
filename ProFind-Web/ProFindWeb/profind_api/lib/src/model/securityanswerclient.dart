//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/securityquestion.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'securityanswerclient.g.dart';

/// Securityanswerclient
///
/// Properties:
/// * [idSa] 
/// * [answerSa] 
/// * [idSq1] 
/// * [idC1] 
/// * [idC1Navigation] 
/// * [idSq1Navigation] 
@BuiltValue()
abstract class Securityanswerclient implements Built<Securityanswerclient, SecurityanswerclientBuilder> {
  @BuiltValueField(wireName: r'idSa')
  String? get idSa;

  @BuiltValueField(wireName: r'answerSa')
  String? get answerSa;

  @BuiltValueField(wireName: r'idSq1')
  String? get idSq1;

  @BuiltValueField(wireName: r'idC1')
  String? get idC1;

  @BuiltValueField(wireName: r'idC1Navigation')
  Client? get idC1Navigation;

  @BuiltValueField(wireName: r'idSq1Navigation')
  Securityquestion? get idSq1Navigation;

  Securityanswerclient._();

  factory Securityanswerclient([void updates(SecurityanswerclientBuilder b)]) = _$Securityanswerclient;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(SecurityanswerclientBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Securityanswerclient> get serializer => _$SecurityanswerclientSerializer();
}

class _$SecurityanswerclientSerializer implements PrimitiveSerializer<Securityanswerclient> {
  @override
  final Iterable<Type> types = const [Securityanswerclient, _$Securityanswerclient];

  @override
  final String wireName = r'Securityanswerclient';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Securityanswerclient object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idSa != null) {
      yield r'idSa';
      yield serializers.serialize(
        object.idSa,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.answerSa != null) {
      yield r'answerSa';
      yield serializers.serialize(
        object.answerSa,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idSq1 != null) {
      yield r'idSq1';
      yield serializers.serialize(
        object.idSq1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC1 != null) {
      yield r'idC1';
      yield serializers.serialize(
        object.idC1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC1Navigation != null) {
      yield r'idC1Navigation';
      yield serializers.serialize(
        object.idC1Navigation,
        specifiedType: const FullType(Client),
      );
    }
    if (object.idSq1Navigation != null) {
      yield r'idSq1Navigation';
      yield serializers.serialize(
        object.idSq1Navigation,
        specifiedType: const FullType(Securityquestion),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Securityanswerclient object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required SecurityanswerclientBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idSa':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idSa = valueDes;
          break;
        case r'answerSa':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.answerSa = valueDes;
          break;
        case r'idSq1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idSq1 = valueDes;
          break;
        case r'idC1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC1 = valueDes;
          break;
        case r'idC1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Client),
          ) as Client;
          result.idC1Navigation.replace(valueDes);
          break;
        case r'idSq1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Securityquestion),
          ) as Securityquestion;
          result.idSq1Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Securityanswerclient deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = SecurityanswerclientBuilder();
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

