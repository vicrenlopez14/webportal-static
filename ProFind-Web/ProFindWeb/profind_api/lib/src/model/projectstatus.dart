//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/project.dart';
import 'package:built_collection/built_collection.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'projectstatus.g.dart';

/// Projectstatus
///
/// Properties:
/// * [idPs] 
/// * [namePs] 
/// * [descriptionPs] 
/// * [colorPs] 
/// * [projects] 
@BuiltValue()
abstract class Projectstatus implements Built<Projectstatus, ProjectstatusBuilder> {
  @BuiltValueField(wireName: r'idPs')
  String? get idPs;

  @BuiltValueField(wireName: r'namePs')
  String? get namePs;

  @BuiltValueField(wireName: r'descriptionPs')
  String? get descriptionPs;

  @BuiltValueField(wireName: r'colorPs')
  String? get colorPs;

  @BuiltValueField(wireName: r'projects')
  BuiltList<Project>? get projects;

  Projectstatus._();

  factory Projectstatus([void updates(ProjectstatusBuilder b)]) = _$Projectstatus;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProjectstatusBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Projectstatus> get serializer => _$ProjectstatusSerializer();
}

class _$ProjectstatusSerializer implements PrimitiveSerializer<Projectstatus> {
  @override
  final Iterable<Type> types = const [Projectstatus, _$Projectstatus];

  @override
  final String wireName = r'Projectstatus';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Projectstatus object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPs != null) {
      yield r'idPs';
      yield serializers.serialize(
        object.idPs,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.namePs != null) {
      yield r'namePs';
      yield serializers.serialize(
        object.namePs,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionPs != null) {
      yield r'descriptionPs';
      yield serializers.serialize(
        object.descriptionPs,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.colorPs != null) {
      yield r'colorPs';
      yield serializers.serialize(
        object.colorPs,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.projects != null) {
      yield r'projects';
      yield serializers.serialize(
        object.projects,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Project)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Projectstatus object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProjectstatusBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPs':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPs = valueDes;
          break;
        case r'namePs':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.namePs = valueDes;
          break;
        case r'descriptionPs':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionPs = valueDes;
          break;
        case r'colorPs':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.colorPs = valueDes;
          break;
        case r'projects':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Project)]),
          ) as BuiltList<Project>?;
          if (valueDes == null) continue;
          result.projects.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Projectstatus deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProjectstatusBuilder();
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

