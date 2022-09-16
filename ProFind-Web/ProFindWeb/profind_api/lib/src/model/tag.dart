//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/activity.dart';
import 'package:built_collection/built_collection.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'tag.g.dart';

/// Tag
///
/// Properties:
/// * [idT] 
/// * [nameT] 
/// * [colorT] 
/// * [idPj] 
/// * [idPjNavigation] 
/// * [activities] 
@BuiltValue()
abstract class Tag implements Built<Tag, TagBuilder> {
  @BuiltValueField(wireName: r'idT')
  String? get idT;

  @BuiltValueField(wireName: r'nameT')
  String? get nameT;

  @BuiltValueField(wireName: r'colorT')
  String? get colorT;

  @BuiltValueField(wireName: r'idPj')
  String? get idPj;

  @BuiltValueField(wireName: r'idPjNavigation')
  Project? get idPjNavigation;

  @BuiltValueField(wireName: r'activities')
  BuiltList<Activity>? get activities;

  Tag._();

  factory Tag([void updates(TagBuilder b)]) = _$Tag;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(TagBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Tag> get serializer => _$TagSerializer();
}

class _$TagSerializer implements PrimitiveSerializer<Tag> {
  @override
  final Iterable<Type> types = const [Tag, _$Tag];

  @override
  final String wireName = r'Tag';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Tag object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idT != null) {
      yield r'idT';
      yield serializers.serialize(
        object.idT,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.nameT != null) {
      yield r'nameT';
      yield serializers.serialize(
        object.nameT,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.colorT != null) {
      yield r'colorT';
      yield serializers.serialize(
        object.colorT,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPj != null) {
      yield r'idPj';
      yield serializers.serialize(
        object.idPj,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPjNavigation != null) {
      yield r'idPjNavigation';
      yield serializers.serialize(
        object.idPjNavigation,
        specifiedType: const FullType(Project),
      );
    }
    if (object.activities != null) {
      yield r'activities';
      yield serializers.serialize(
        object.activities,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Activity)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Tag object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required TagBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idT':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idT = valueDes;
          break;
        case r'nameT':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameT = valueDes;
          break;
        case r'colorT':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.colorT = valueDes;
          break;
        case r'idPj':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPj = valueDes;
          break;
        case r'idPjNavigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Project),
          ) as Project;
          result.idPjNavigation.replace(valueDes);
          break;
        case r'activities':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Activity)]),
          ) as BuiltList<Activity>?;
          if (valueDes == null) continue;
          result.activities.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Tag deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = TagBuilder();
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

