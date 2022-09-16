//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/securityquestion.dart';
import 'package:profind_api/src/model/admin.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'securityansweradmin.g.dart';

/// Securityansweradmin
///
/// Properties:
/// * [idSa] 
/// * [answerSa] 
/// * [idSq1] 
/// * [idA1] 
/// * [idA1Navigation] 
/// * [idSq1Navigation] 
@BuiltValue()
abstract class Securityansweradmin implements Built<Securityansweradmin, SecurityansweradminBuilder> {
  @BuiltValueField(wireName: r'idSa')
  String? get idSa;

  @BuiltValueField(wireName: r'answerSa')
  String? get answerSa;

  @BuiltValueField(wireName: r'idSq1')
  String? get idSq1;

  @BuiltValueField(wireName: r'idA1')
  String? get idA1;

  @BuiltValueField(wireName: r'idA1Navigation')
  Admin? get idA1Navigation;

  @BuiltValueField(wireName: r'idSq1Navigation')
  Securityquestion? get idSq1Navigation;

  Securityansweradmin._();

  factory Securityansweradmin([void updates(SecurityansweradminBuilder b)]) = _$Securityansweradmin;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(SecurityansweradminBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Securityansweradmin> get serializer => _$SecurityansweradminSerializer();
}

class _$SecurityansweradminSerializer implements PrimitiveSerializer<Securityansweradmin> {
  @override
  final Iterable<Type> types = const [Securityansweradmin, _$Securityansweradmin];

  @override
  final String wireName = r'Securityansweradmin';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Securityansweradmin object, {
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
    if (object.idA1 != null) {
      yield r'idA1';
      yield serializers.serialize(
        object.idA1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idA1Navigation != null) {
      yield r'idA1Navigation';
      yield serializers.serialize(
        object.idA1Navigation,
        specifiedType: const FullType(Admin),
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
    Securityansweradmin object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required SecurityansweradminBuilder result,
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
        case r'idA1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idA1 = valueDes;
          break;
        case r'idA1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Admin),
          ) as Admin;
          result.idA1Navigation.replace(valueDes);
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
  Securityansweradmin deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = SecurityansweradminBuilder();
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

