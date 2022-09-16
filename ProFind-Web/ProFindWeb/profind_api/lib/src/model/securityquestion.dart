//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/securityansweradmin.dart';
import 'package:profind_api/src/model/securityanswerprofessional.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/securityanswerclient.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'securityquestion.g.dart';

/// Securityquestion
///
/// Properties:
/// * [idSq] 
/// * [nameSq] 
/// * [securityansweradmins] 
/// * [securityanswerclients] 
/// * [securityanswerprofessionals] 
@BuiltValue()
abstract class Securityquestion implements Built<Securityquestion, SecurityquestionBuilder> {
  @BuiltValueField(wireName: r'idSq')
  String? get idSq;

  @BuiltValueField(wireName: r'nameSq')
  String? get nameSq;

  @BuiltValueField(wireName: r'securityansweradmins')
  BuiltList<Securityansweradmin>? get securityansweradmins;

  @BuiltValueField(wireName: r'securityanswerclients')
  BuiltList<Securityanswerclient>? get securityanswerclients;

  @BuiltValueField(wireName: r'securityanswerprofessionals')
  BuiltList<Securityanswerprofessional>? get securityanswerprofessionals;

  Securityquestion._();

  factory Securityquestion([void updates(SecurityquestionBuilder b)]) = _$Securityquestion;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(SecurityquestionBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Securityquestion> get serializer => _$SecurityquestionSerializer();
}

class _$SecurityquestionSerializer implements PrimitiveSerializer<Securityquestion> {
  @override
  final Iterable<Type> types = const [Securityquestion, _$Securityquestion];

  @override
  final String wireName = r'Securityquestion';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Securityquestion object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idSq != null) {
      yield r'idSq';
      yield serializers.serialize(
        object.idSq,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.nameSq != null) {
      yield r'nameSq';
      yield serializers.serialize(
        object.nameSq,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.securityansweradmins != null) {
      yield r'securityansweradmins';
      yield serializers.serialize(
        object.securityansweradmins,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Securityansweradmin)]),
      );
    }
    if (object.securityanswerclients != null) {
      yield r'securityanswerclients';
      yield serializers.serialize(
        object.securityanswerclients,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerclient)]),
      );
    }
    if (object.securityanswerprofessionals != null) {
      yield r'securityanswerprofessionals';
      yield serializers.serialize(
        object.securityanswerprofessionals,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerprofessional)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Securityquestion object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required SecurityquestionBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idSq':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idSq = valueDes;
          break;
        case r'nameSq':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameSq = valueDes;
          break;
        case r'securityansweradmins':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Securityansweradmin)]),
          ) as BuiltList<Securityansweradmin>?;
          if (valueDes == null) continue;
          result.securityansweradmins.replace(valueDes);
          break;
        case r'securityanswerclients':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerclient)]),
          ) as BuiltList<Securityanswerclient>?;
          if (valueDes == null) continue;
          result.securityanswerclients.replace(valueDes);
          break;
        case r'securityanswerprofessionals':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerprofessional)]),
          ) as BuiltList<Securityanswerprofessional>?;
          if (valueDes == null) continue;
          result.securityanswerprofessionals.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Securityquestion deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = SecurityquestionBuilder();
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

