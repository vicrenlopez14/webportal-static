//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:built_collection/built_collection.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'profession.g.dart';

/// Profession
///
/// Properties:
/// * [idPfs] 
/// * [namePfs] 
/// * [professionals] 
@BuiltValue()
abstract class Profession implements Built<Profession, ProfessionBuilder> {
  @BuiltValueField(wireName: r'idPfs')
  int? get idPfs;

  @BuiltValueField(wireName: r'namePfs')
  String? get namePfs;

  @BuiltValueField(wireName: r'professionals')
  BuiltList<Professional>? get professionals;

  Profession._();

  factory Profession([void updates(ProfessionBuilder b)]) = _$Profession;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProfessionBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Profession> get serializer => _$ProfessionSerializer();
}

class _$ProfessionSerializer implements PrimitiveSerializer<Profession> {
  @override
  final Iterable<Type> types = const [Profession, _$Profession];

  @override
  final String wireName = r'Profession';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Profession object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPfs != null) {
      yield r'idPfs';
      yield serializers.serialize(
        object.idPfs,
        specifiedType: const FullType(int),
      );
    }
    if (object.namePfs != null) {
      yield r'namePfs';
      yield serializers.serialize(
        object.namePfs,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.professionals != null) {
      yield r'professionals';
      yield serializers.serialize(
        object.professionals,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Professional)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Profession object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProfessionBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPfs':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(int),
          ) as int;
          result.idPfs = valueDes;
          break;
        case r'namePfs':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.namePfs = valueDes;
          break;
        case r'professionals':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Professional)]),
          ) as BuiltList<Professional>?;
          if (valueDes == null) continue;
          result.professionals.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Profession deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProfessionBuilder();
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

