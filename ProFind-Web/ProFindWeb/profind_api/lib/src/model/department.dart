//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:built_collection/built_collection.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'department.g.dart';

/// Department
///
/// Properties:
/// * [idDp] 
/// * [nameDp] 
/// * [professionals] 
@BuiltValue()
abstract class Department implements Built<Department, DepartmentBuilder> {
  @BuiltValueField(wireName: r'idDp')
  int? get idDp;

  @BuiltValueField(wireName: r'nameDp')
  String? get nameDp;

  @BuiltValueField(wireName: r'professionals')
  BuiltList<Professional>? get professionals;

  Department._();

  factory Department([void updates(DepartmentBuilder b)]) = _$Department;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(DepartmentBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Department> get serializer => _$DepartmentSerializer();
}

class _$DepartmentSerializer implements PrimitiveSerializer<Department> {
  @override
  final Iterable<Type> types = const [Department, _$Department];

  @override
  final String wireName = r'Department';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Department object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idDp != null) {
      yield r'idDp';
      yield serializers.serialize(
        object.idDp,
        specifiedType: const FullType(int),
      );
    }
    if (object.nameDp != null) {
      yield r'nameDp';
      yield serializers.serialize(
        object.nameDp,
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
    Department object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required DepartmentBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idDp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(int),
          ) as int;
          result.idDp = valueDes;
          break;
        case r'nameDp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameDp = valueDes;
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
  Department deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = DepartmentBuilder();
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

