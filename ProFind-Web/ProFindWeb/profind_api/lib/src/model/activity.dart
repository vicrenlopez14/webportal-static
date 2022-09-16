//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/activitycomment.dart';
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/tag.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'activity.g.dart';

/// Activity
///
/// Properties:
/// * [idA] 
/// * [titleA] 
/// * [descriptionA] 
/// * [expectedBeginA] 
/// * [expectedEndA] 
/// * [pictureA] 
/// * [idPj1] 
/// * [idT1] 
/// * [idPj1Navigation] 
/// * [idT1Navigation] 
/// * [activitycomments] 
/// * [supporttickets] 
@BuiltValue()
abstract class Activity implements Built<Activity, ActivityBuilder> {
  @BuiltValueField(wireName: r'idA')
  String? get idA;

  @BuiltValueField(wireName: r'titleA')
  String? get titleA;

  @BuiltValueField(wireName: r'descriptionA')
  String? get descriptionA;

  @BuiltValueField(wireName: r'expectedBeginA')
  DateTime? get expectedBeginA;

  @BuiltValueField(wireName: r'expectedEndA')
  DateTime? get expectedEndA;

  @BuiltValueField(wireName: r'pictureA')
  String? get pictureA;

  @BuiltValueField(wireName: r'idPj1')
  String? get idPj1;

  @BuiltValueField(wireName: r'idT1')
  String? get idT1;

  @BuiltValueField(wireName: r'idPj1Navigation')
  Project? get idPj1Navigation;

  @BuiltValueField(wireName: r'idT1Navigation')
  Tag? get idT1Navigation;

  @BuiltValueField(wireName: r'activitycomments')
  BuiltList<Activitycomment>? get activitycomments;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  Activity._();

  factory Activity([void updates(ActivityBuilder b)]) = _$Activity;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ActivityBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Activity> get serializer => _$ActivitySerializer();
}

class _$ActivitySerializer implements PrimitiveSerializer<Activity> {
  @override
  final Iterable<Type> types = const [Activity, _$Activity];

  @override
  final String wireName = r'Activity';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Activity object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idA != null) {
      yield r'idA';
      yield serializers.serialize(
        object.idA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titleA != null) {
      yield r'titleA';
      yield serializers.serialize(
        object.titleA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionA != null) {
      yield r'descriptionA';
      yield serializers.serialize(
        object.descriptionA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.expectedBeginA != null) {
      yield r'expectedBeginA';
      yield serializers.serialize(
        object.expectedBeginA,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.expectedEndA != null) {
      yield r'expectedEndA';
      yield serializers.serialize(
        object.expectedEndA,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.pictureA != null) {
      yield r'pictureA';
      yield serializers.serialize(
        object.pictureA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPj1 != null) {
      yield r'idPj1';
      yield serializers.serialize(
        object.idPj1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idT1 != null) {
      yield r'idT1';
      yield serializers.serialize(
        object.idT1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPj1Navigation != null) {
      yield r'idPj1Navigation';
      yield serializers.serialize(
        object.idPj1Navigation,
        specifiedType: const FullType(Project),
      );
    }
    if (object.idT1Navigation != null) {
      yield r'idT1Navigation';
      yield serializers.serialize(
        object.idT1Navigation,
        specifiedType: const FullType(Tag),
      );
    }
    if (object.activitycomments != null) {
      yield r'activitycomments';
      yield serializers.serialize(
        object.activitycomments,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Activitycomment)]),
      );
    }
    if (object.supporttickets != null) {
      yield r'supporttickets';
      yield serializers.serialize(
        object.supporttickets,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Supportticket)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Activity object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ActivityBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idA = valueDes;
          break;
        case r'titleA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titleA = valueDes;
          break;
        case r'descriptionA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionA = valueDes;
          break;
        case r'expectedBeginA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.expectedBeginA = valueDes;
          break;
        case r'expectedEndA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.expectedEndA = valueDes;
          break;
        case r'pictureA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.pictureA = valueDes;
          break;
        case r'idPj1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPj1 = valueDes;
          break;
        case r'idT1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idT1 = valueDes;
          break;
        case r'idPj1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Project),
          ) as Project;
          result.idPj1Navigation.replace(valueDes);
          break;
        case r'idT1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Tag),
          ) as Tag;
          result.idT1Navigation.replace(valueDes);
          break;
        case r'activitycomments':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Activitycomment)]),
          ) as BuiltList<Activitycomment>?;
          if (valueDes == null) continue;
          result.activitycomments.replace(valueDes);
          break;
        case r'supporttickets':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Supportticket)]),
          ) as BuiltList<Supportticket>?;
          if (valueDes == null) continue;
          result.supporttickets.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Activity deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ActivityBuilder();
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

