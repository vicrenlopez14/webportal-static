//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/projectstatus.dart';
import 'package:profind_api/src/model/activity.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/projectpay.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/notification.dart';
import 'package:profind_api/src/model/tag.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'project.g.dart';

/// Project
///
/// Properties:
/// * [idPj] 
/// * [titlePj] 
/// * [descriptionPj] 
/// * [picturePj] 
/// * [totalPricePj] 
/// * [idPs1] 
/// * [idP1] 
/// * [idC1] 
/// * [idC1Navigation] 
/// * [idP1Navigation] 
/// * [idPs1Navigation] 
/// * [activities] 
/// * [notifications] 
/// * [projectpays] 
/// * [supporttickets] 
/// * [tags] 
@BuiltValue()
abstract class Project implements Built<Project, ProjectBuilder> {
  @BuiltValueField(wireName: r'idPj')
  String? get idPj;

  @BuiltValueField(wireName: r'titlePj')
  String? get titlePj;

  @BuiltValueField(wireName: r'descriptionPj')
  String? get descriptionPj;

  @BuiltValueField(wireName: r'picturePj')
  String? get picturePj;

  @BuiltValueField(wireName: r'totalPricePj')
  double? get totalPricePj;

  @BuiltValueField(wireName: r'idPs1')
  String? get idPs1;

  @BuiltValueField(wireName: r'idP1')
  String? get idP1;

  @BuiltValueField(wireName: r'idC1')
  String? get idC1;

  @BuiltValueField(wireName: r'idC1Navigation')
  Client? get idC1Navigation;

  @BuiltValueField(wireName: r'idP1Navigation')
  Professional? get idP1Navigation;

  @BuiltValueField(wireName: r'idPs1Navigation')
  Projectstatus? get idPs1Navigation;

  @BuiltValueField(wireName: r'activities')
  BuiltList<Activity>? get activities;

  @BuiltValueField(wireName: r'notifications')
  BuiltList<Notification>? get notifications;

  @BuiltValueField(wireName: r'projectpays')
  BuiltList<Projectpay>? get projectpays;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  @BuiltValueField(wireName: r'tags')
  BuiltList<Tag>? get tags;

  Project._();

  factory Project([void updates(ProjectBuilder b)]) = _$Project;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProjectBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Project> get serializer => _$ProjectSerializer();
}

class _$ProjectSerializer implements PrimitiveSerializer<Project> {
  @override
  final Iterable<Type> types = const [Project, _$Project];

  @override
  final String wireName = r'Project';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Project object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPj != null) {
      yield r'idPj';
      yield serializers.serialize(
        object.idPj,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titlePj != null) {
      yield r'titlePj';
      yield serializers.serialize(
        object.titlePj,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionPj != null) {
      yield r'descriptionPj';
      yield serializers.serialize(
        object.descriptionPj,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.picturePj != null) {
      yield r'picturePj';
      yield serializers.serialize(
        object.picturePj,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.totalPricePj != null) {
      yield r'totalPricePj';
      yield serializers.serialize(
        object.totalPricePj,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.idPs1 != null) {
      yield r'idPs1';
      yield serializers.serialize(
        object.idPs1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP1 != null) {
      yield r'idP1';
      yield serializers.serialize(
        object.idP1,
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
    if (object.idP1Navigation != null) {
      yield r'idP1Navigation';
      yield serializers.serialize(
        object.idP1Navigation,
        specifiedType: const FullType(Professional),
      );
    }
    if (object.idPs1Navigation != null) {
      yield r'idPs1Navigation';
      yield serializers.serialize(
        object.idPs1Navigation,
        specifiedType: const FullType(Projectstatus),
      );
    }
    if (object.activities != null) {
      yield r'activities';
      yield serializers.serialize(
        object.activities,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Activity)]),
      );
    }
    if (object.notifications != null) {
      yield r'notifications';
      yield serializers.serialize(
        object.notifications,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Notification)]),
      );
    }
    if (object.projectpays != null) {
      yield r'projectpays';
      yield serializers.serialize(
        object.projectpays,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Projectpay)]),
      );
    }
    if (object.supporttickets != null) {
      yield r'supporttickets';
      yield serializers.serialize(
        object.supporttickets,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Supportticket)]),
      );
    }
    if (object.tags != null) {
      yield r'tags';
      yield serializers.serialize(
        object.tags,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Tag)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Project object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProjectBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPj':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPj = valueDes;
          break;
        case r'titlePj':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titlePj = valueDes;
          break;
        case r'descriptionPj':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionPj = valueDes;
          break;
        case r'picturePj':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.picturePj = valueDes;
          break;
        case r'totalPricePj':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.totalPricePj = valueDes;
          break;
        case r'idPs1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPs1 = valueDes;
          break;
        case r'idP1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP1 = valueDes;
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
        case r'idP1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP1Navigation.replace(valueDes);
          break;
        case r'idPs1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Projectstatus),
          ) as Projectstatus;
          result.idPs1Navigation.replace(valueDes);
          break;
        case r'activities':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Activity)]),
          ) as BuiltList<Activity>?;
          if (valueDes == null) continue;
          result.activities.replace(valueDes);
          break;
        case r'notifications':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Notification)]),
          ) as BuiltList<Notification>?;
          if (valueDes == null) continue;
          result.notifications.replace(valueDes);
          break;
        case r'projectpays':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Projectpay)]),
          ) as BuiltList<Projectpay>?;
          if (valueDes == null) continue;
          result.projectpays.replace(valueDes);
          break;
        case r'supporttickets':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Supportticket)]),
          ) as BuiltList<Supportticket>?;
          if (valueDes == null) continue;
          result.supporttickets.replace(valueDes);
          break;
        case r'tags':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Tag)]),
          ) as BuiltList<Tag>?;
          if (valueDes == null) continue;
          result.tags.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Project deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProjectBuilder();
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

