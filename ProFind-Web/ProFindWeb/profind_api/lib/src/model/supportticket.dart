//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/activity.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/projectpay.dart';
import 'package:profind_api/src/model/proposal.dart';
import 'package:profind_api/src/model/admin.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'supportticket.g.dart';

/// Supportticket
///
/// Properties:
/// * [idSt] 
/// * [titleSt] 
/// * [contentSt] 
/// * [imageSt] 
/// * [documentSt] 
/// * [locationSt] 
/// * [audioSt] 
/// * [dateTimeSt] 
/// * [ticketStatusSt] 
/// * [suggestedActionSt] 
/// * [responseContentSt] 
/// * [responseImageSt] 
/// * [responseDocumentSt] 
/// * [responseLocationSt] 
/// * [responseAudioSt] 
/// * [idP5] 
/// * [idC5] 
/// * [idA2] 
/// * [idPj4] 
/// * [idAct1] 
/// * [idPp2] 
/// * [idPpy1] 
/// * [idA2Navigation] 
/// * [idAct1Navigation] 
/// * [idC5Navigation] 
/// * [idP5Navigation] 
/// * [idPj4Navigation] 
/// * [idPp2Navigation] 
/// * [idPpy1Navigation] 
@BuiltValue()
abstract class Supportticket implements Built<Supportticket, SupportticketBuilder> {
  @BuiltValueField(wireName: r'idSt')
  String? get idSt;

  @BuiltValueField(wireName: r'titleSt')
  String? get titleSt;

  @BuiltValueField(wireName: r'contentSt')
  String? get contentSt;

  @BuiltValueField(wireName: r'imageSt')
  String? get imageSt;

  @BuiltValueField(wireName: r'documentSt')
  String? get documentSt;

  @BuiltValueField(wireName: r'locationSt')
  String? get locationSt;

  @BuiltValueField(wireName: r'audioSt')
  String? get audioSt;

  @BuiltValueField(wireName: r'dateTimeSt')
  DateTime? get dateTimeSt;

  @BuiltValueField(wireName: r'ticketStatusSt')
  String? get ticketStatusSt;

  @BuiltValueField(wireName: r'suggestedActionSt')
  String? get suggestedActionSt;

  @BuiltValueField(wireName: r'responseContentSt')
  String? get responseContentSt;

  @BuiltValueField(wireName: r'responseImageSt')
  String? get responseImageSt;

  @BuiltValueField(wireName: r'responseDocumentSt')
  String? get responseDocumentSt;

  @BuiltValueField(wireName: r'responseLocationSt')
  String? get responseLocationSt;

  @BuiltValueField(wireName: r'responseAudioSt')
  String? get responseAudioSt;

  @BuiltValueField(wireName: r'idP5')
  String? get idP5;

  @BuiltValueField(wireName: r'idC5')
  String? get idC5;

  @BuiltValueField(wireName: r'idA2')
  String? get idA2;

  @BuiltValueField(wireName: r'idPj4')
  String? get idPj4;

  @BuiltValueField(wireName: r'idAct1')
  String? get idAct1;

  @BuiltValueField(wireName: r'idPp2')
  String? get idPp2;

  @BuiltValueField(wireName: r'idPpy1')
  String? get idPpy1;

  @BuiltValueField(wireName: r'idA2Navigation')
  Admin? get idA2Navigation;

  @BuiltValueField(wireName: r'idAct1Navigation')
  Activity? get idAct1Navigation;

  @BuiltValueField(wireName: r'idC5Navigation')
  Client? get idC5Navigation;

  @BuiltValueField(wireName: r'idP5Navigation')
  Professional? get idP5Navigation;

  @BuiltValueField(wireName: r'idPj4Navigation')
  Project? get idPj4Navigation;

  @BuiltValueField(wireName: r'idPp2Navigation')
  Proposal? get idPp2Navigation;

  @BuiltValueField(wireName: r'idPpy1Navigation')
  Projectpay? get idPpy1Navigation;

  Supportticket._();

  factory Supportticket([void updates(SupportticketBuilder b)]) = _$Supportticket;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(SupportticketBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Supportticket> get serializer => _$SupportticketSerializer();
}

class _$SupportticketSerializer implements PrimitiveSerializer<Supportticket> {
  @override
  final Iterable<Type> types = const [Supportticket, _$Supportticket];

  @override
  final String wireName = r'Supportticket';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Supportticket object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idSt != null) {
      yield r'idSt';
      yield serializers.serialize(
        object.idSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titleSt != null) {
      yield r'titleSt';
      yield serializers.serialize(
        object.titleSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.contentSt != null) {
      yield r'contentSt';
      yield serializers.serialize(
        object.contentSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.imageSt != null) {
      yield r'imageSt';
      yield serializers.serialize(
        object.imageSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.documentSt != null) {
      yield r'documentSt';
      yield serializers.serialize(
        object.documentSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.locationSt != null) {
      yield r'locationSt';
      yield serializers.serialize(
        object.locationSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.audioSt != null) {
      yield r'audioSt';
      yield serializers.serialize(
        object.audioSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.dateTimeSt != null) {
      yield r'dateTimeSt';
      yield serializers.serialize(
        object.dateTimeSt,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.ticketStatusSt != null) {
      yield r'ticketStatusSt';
      yield serializers.serialize(
        object.ticketStatusSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.suggestedActionSt != null) {
      yield r'suggestedActionSt';
      yield serializers.serialize(
        object.suggestedActionSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.responseContentSt != null) {
      yield r'responseContentSt';
      yield serializers.serialize(
        object.responseContentSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.responseImageSt != null) {
      yield r'responseImageSt';
      yield serializers.serialize(
        object.responseImageSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.responseDocumentSt != null) {
      yield r'responseDocumentSt';
      yield serializers.serialize(
        object.responseDocumentSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.responseLocationSt != null) {
      yield r'responseLocationSt';
      yield serializers.serialize(
        object.responseLocationSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.responseAudioSt != null) {
      yield r'responseAudioSt';
      yield serializers.serialize(
        object.responseAudioSt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP5 != null) {
      yield r'idP5';
      yield serializers.serialize(
        object.idP5,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC5 != null) {
      yield r'idC5';
      yield serializers.serialize(
        object.idC5,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idA2 != null) {
      yield r'idA2';
      yield serializers.serialize(
        object.idA2,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPj4 != null) {
      yield r'idPj4';
      yield serializers.serialize(
        object.idPj4,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idAct1 != null) {
      yield r'idAct1';
      yield serializers.serialize(
        object.idAct1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPp2 != null) {
      yield r'idPp2';
      yield serializers.serialize(
        object.idPp2,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPpy1 != null) {
      yield r'idPpy1';
      yield serializers.serialize(
        object.idPpy1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idA2Navigation != null) {
      yield r'idA2Navigation';
      yield serializers.serialize(
        object.idA2Navigation,
        specifiedType: const FullType(Admin),
      );
    }
    if (object.idAct1Navigation != null) {
      yield r'idAct1Navigation';
      yield serializers.serialize(
        object.idAct1Navigation,
        specifiedType: const FullType(Activity),
      );
    }
    if (object.idC5Navigation != null) {
      yield r'idC5Navigation';
      yield serializers.serialize(
        object.idC5Navigation,
        specifiedType: const FullType(Client),
      );
    }
    if (object.idP5Navigation != null) {
      yield r'idP5Navigation';
      yield serializers.serialize(
        object.idP5Navigation,
        specifiedType: const FullType(Professional),
      );
    }
    if (object.idPj4Navigation != null) {
      yield r'idPj4Navigation';
      yield serializers.serialize(
        object.idPj4Navigation,
        specifiedType: const FullType(Project),
      );
    }
    if (object.idPp2Navigation != null) {
      yield r'idPp2Navigation';
      yield serializers.serialize(
        object.idPp2Navigation,
        specifiedType: const FullType(Proposal),
      );
    }
    if (object.idPpy1Navigation != null) {
      yield r'idPpy1Navigation';
      yield serializers.serialize(
        object.idPpy1Navigation,
        specifiedType: const FullType(Projectpay),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Supportticket object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required SupportticketBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idSt = valueDes;
          break;
        case r'titleSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titleSt = valueDes;
          break;
        case r'contentSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.contentSt = valueDes;
          break;
        case r'imageSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.imageSt = valueDes;
          break;
        case r'documentSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.documentSt = valueDes;
          break;
        case r'locationSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.locationSt = valueDes;
          break;
        case r'audioSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.audioSt = valueDes;
          break;
        case r'dateTimeSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.dateTimeSt = valueDes;
          break;
        case r'ticketStatusSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.ticketStatusSt = valueDes;
          break;
        case r'suggestedActionSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.suggestedActionSt = valueDes;
          break;
        case r'responseContentSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.responseContentSt = valueDes;
          break;
        case r'responseImageSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.responseImageSt = valueDes;
          break;
        case r'responseDocumentSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.responseDocumentSt = valueDes;
          break;
        case r'responseLocationSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.responseLocationSt = valueDes;
          break;
        case r'responseAudioSt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.responseAudioSt = valueDes;
          break;
        case r'idP5':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP5 = valueDes;
          break;
        case r'idC5':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC5 = valueDes;
          break;
        case r'idA2':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idA2 = valueDes;
          break;
        case r'idPj4':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPj4 = valueDes;
          break;
        case r'idAct1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idAct1 = valueDes;
          break;
        case r'idPp2':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPp2 = valueDes;
          break;
        case r'idPpy1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPpy1 = valueDes;
          break;
        case r'idA2Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Admin),
          ) as Admin;
          result.idA2Navigation.replace(valueDes);
          break;
        case r'idAct1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Activity),
          ) as Activity;
          result.idAct1Navigation.replace(valueDes);
          break;
        case r'idC5Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Client),
          ) as Client;
          result.idC5Navigation.replace(valueDes);
          break;
        case r'idP5Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP5Navigation.replace(valueDes);
          break;
        case r'idPj4Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Project),
          ) as Project;
          result.idPj4Navigation.replace(valueDes);
          break;
        case r'idPp2Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Proposal),
          ) as Proposal;
          result.idPp2Navigation.replace(valueDes);
          break;
        case r'idPpy1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Projectpay),
          ) as Projectpay;
          result.idPpy1Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Supportticket deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = SupportticketBuilder();
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

