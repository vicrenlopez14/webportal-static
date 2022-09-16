//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/project.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'notification.g.dart';

/// Notification
///
/// Properties:
/// * [idN] 
/// * [titleN] 
/// * [descriptionN] 
/// * [dateTimeIssuedN] 
/// * [pictureN] 
/// * [idPj2] 
/// * [idPj2Navigation] 
@BuiltValue()
abstract class Notification implements Built<Notification, NotificationBuilder> {
  @BuiltValueField(wireName: r'idN')
  String? get idN;

  @BuiltValueField(wireName: r'titleN')
  String? get titleN;

  @BuiltValueField(wireName: r'descriptionN')
  String? get descriptionN;

  @BuiltValueField(wireName: r'dateTimeIssuedN')
  DateTime? get dateTimeIssuedN;

  @BuiltValueField(wireName: r'pictureN')
  String? get pictureN;

  @BuiltValueField(wireName: r'idPj2')
  String? get idPj2;

  @BuiltValueField(wireName: r'idPj2Navigation')
  Project? get idPj2Navigation;

  Notification._();

  factory Notification([void updates(NotificationBuilder b)]) = _$Notification;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(NotificationBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Notification> get serializer => _$NotificationSerializer();
}

class _$NotificationSerializer implements PrimitiveSerializer<Notification> {
  @override
  final Iterable<Type> types = const [Notification, _$Notification];

  @override
  final String wireName = r'Notification';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Notification object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idN != null) {
      yield r'idN';
      yield serializers.serialize(
        object.idN,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titleN != null) {
      yield r'titleN';
      yield serializers.serialize(
        object.titleN,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionN != null) {
      yield r'descriptionN';
      yield serializers.serialize(
        object.descriptionN,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.dateTimeIssuedN != null) {
      yield r'dateTimeIssuedN';
      yield serializers.serialize(
        object.dateTimeIssuedN,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.pictureN != null) {
      yield r'pictureN';
      yield serializers.serialize(
        object.pictureN,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPj2 != null) {
      yield r'idPj2';
      yield serializers.serialize(
        object.idPj2,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPj2Navigation != null) {
      yield r'idPj2Navigation';
      yield serializers.serialize(
        object.idPj2Navigation,
        specifiedType: const FullType(Project),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Notification object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required NotificationBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idN':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idN = valueDes;
          break;
        case r'titleN':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titleN = valueDes;
          break;
        case r'descriptionN':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionN = valueDes;
          break;
        case r'dateTimeIssuedN':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.dateTimeIssuedN = valueDes;
          break;
        case r'pictureN':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.pictureN = valueDes;
          break;
        case r'idPj2':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPj2 = valueDes;
          break;
        case r'idPj2Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Project),
          ) as Project;
          result.idPj2Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Notification deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = NotificationBuilder();
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

