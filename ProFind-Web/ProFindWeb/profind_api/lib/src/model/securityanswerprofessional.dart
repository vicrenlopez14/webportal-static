//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/securityquestion.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'securityanswerprofessional.g.dart';

/// Securityanswerprofessional
///
/// Properties:
/// * [idSa] 
/// * [answerSa] 
/// * [idSq] 
/// * [idP] 
/// * [idPNavigation] 
/// * [idSqNavigation] 
@BuiltValue()
abstract class Securityanswerprofessional implements Built<Securityanswerprofessional, SecurityanswerprofessionalBuilder> {
  @BuiltValueField(wireName: r'idSa')
  String? get idSa;

  @BuiltValueField(wireName: r'answerSa')
  String? get answerSa;

  @BuiltValueField(wireName: r'idSq')
  String? get idSq;

  @BuiltValueField(wireName: r'idP')
  String? get idP;

  @BuiltValueField(wireName: r'idPNavigation')
  Professional? get idPNavigation;

  @BuiltValueField(wireName: r'idSqNavigation')
  Securityquestion? get idSqNavigation;

  Securityanswerprofessional._();

  factory Securityanswerprofessional([void updates(SecurityanswerprofessionalBuilder b)]) = _$Securityanswerprofessional;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(SecurityanswerprofessionalBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Securityanswerprofessional> get serializer => _$SecurityanswerprofessionalSerializer();
}

class _$SecurityanswerprofessionalSerializer implements PrimitiveSerializer<Securityanswerprofessional> {
  @override
  final Iterable<Type> types = const [Securityanswerprofessional, _$Securityanswerprofessional];

  @override
  final String wireName = r'Securityanswerprofessional';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Securityanswerprofessional object, {
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
    if (object.idSq != null) {
      yield r'idSq';
      yield serializers.serialize(
        object.idSq,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP != null) {
      yield r'idP';
      yield serializers.serialize(
        object.idP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPNavigation != null) {
      yield r'idPNavigation';
      yield serializers.serialize(
        object.idPNavigation,
        specifiedType: const FullType(Professional),
      );
    }
    if (object.idSqNavigation != null) {
      yield r'idSqNavigation';
      yield serializers.serialize(
        object.idSqNavigation,
        specifiedType: const FullType(Securityquestion),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Securityanswerprofessional object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required SecurityanswerprofessionalBuilder result,
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
        case r'idSq':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idSq = valueDes;
          break;
        case r'idP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP = valueDes;
          break;
        case r'idPNavigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idPNavigation.replace(valueDes);
          break;
        case r'idSqNavigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Securityquestion),
          ) as Securityquestion;
          result.idSqNavigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Securityanswerprofessional deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = SecurityanswerprofessionalBuilder();
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

