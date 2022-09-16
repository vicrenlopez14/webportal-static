//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/activitycomment.dart';
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/projectpay.dart';
import 'package:profind_api/src/model/message.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/proposalnotification.dart';
import 'package:profind_api/src/model/changepasswordcode.dart';
import 'package:profind_api/src/model/proposal.dart';
import 'package:profind_api/src/model/securityanswerclient.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'client.g.dart';

/// Client
///
/// Properties:
/// * [idC] 
/// * [nameC] 
/// * [emailC] 
/// * [passwordC] 
/// * [pictureC] 
/// * [activitycomments] 
/// * [changepasswordcodes] 
/// * [messages] 
/// * [projectpays] 
/// * [projects] 
/// * [proposalnotifications] 
/// * [proposals] 
/// * [securityanswerclients] 
/// * [supporttickets] 
@BuiltValue()
abstract class Client implements Built<Client, ClientBuilder> {
  @BuiltValueField(wireName: r'idC')
  String? get idC;

  @BuiltValueField(wireName: r'nameC')
  String? get nameC;

  @BuiltValueField(wireName: r'emailC')
  String? get emailC;

  @BuiltValueField(wireName: r'passwordC')
  String? get passwordC;

  @BuiltValueField(wireName: r'pictureC')
  String? get pictureC;

  @BuiltValueField(wireName: r'activitycomments')
  BuiltList<Activitycomment>? get activitycomments;

  @BuiltValueField(wireName: r'changepasswordcodes')
  BuiltList<Changepasswordcode>? get changepasswordcodes;

  @BuiltValueField(wireName: r'messages')
  BuiltList<Message>? get messages;

  @BuiltValueField(wireName: r'projectpays')
  BuiltList<Projectpay>? get projectpays;

  @BuiltValueField(wireName: r'projects')
  BuiltList<Project>? get projects;

  @BuiltValueField(wireName: r'proposalnotifications')
  BuiltList<Proposalnotification>? get proposalnotifications;

  @BuiltValueField(wireName: r'proposals')
  BuiltList<Proposal>? get proposals;

  @BuiltValueField(wireName: r'securityanswerclients')
  BuiltList<Securityanswerclient>? get securityanswerclients;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  Client._();

  factory Client([void updates(ClientBuilder b)]) = _$Client;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ClientBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Client> get serializer => _$ClientSerializer();
}

class _$ClientSerializer implements PrimitiveSerializer<Client> {
  @override
  final Iterable<Type> types = const [Client, _$Client];

  @override
  final String wireName = r'Client';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Client object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idC != null) {
      yield r'idC';
      yield serializers.serialize(
        object.idC,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.nameC != null) {
      yield r'nameC';
      yield serializers.serialize(
        object.nameC,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.emailC != null) {
      yield r'emailC';
      yield serializers.serialize(
        object.emailC,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.passwordC != null) {
      yield r'passwordC';
      yield serializers.serialize(
        object.passwordC,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.pictureC != null) {
      yield r'pictureC';
      yield serializers.serialize(
        object.pictureC,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.activitycomments != null) {
      yield r'activitycomments';
      yield serializers.serialize(
        object.activitycomments,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Activitycomment)]),
      );
    }
    if (object.changepasswordcodes != null) {
      yield r'changepasswordcodes';
      yield serializers.serialize(
        object.changepasswordcodes,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Changepasswordcode)]),
      );
    }
    if (object.messages != null) {
      yield r'messages';
      yield serializers.serialize(
        object.messages,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Message)]),
      );
    }
    if (object.projectpays != null) {
      yield r'projectpays';
      yield serializers.serialize(
        object.projectpays,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Projectpay)]),
      );
    }
    if (object.projects != null) {
      yield r'projects';
      yield serializers.serialize(
        object.projects,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Project)]),
      );
    }
    if (object.proposalnotifications != null) {
      yield r'proposalnotifications';
      yield serializers.serialize(
        object.proposalnotifications,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Proposalnotification)]),
      );
    }
    if (object.proposals != null) {
      yield r'proposals';
      yield serializers.serialize(
        object.proposals,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Proposal)]),
      );
    }
    if (object.securityanswerclients != null) {
      yield r'securityanswerclients';
      yield serializers.serialize(
        object.securityanswerclients,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerclient)]),
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
    Client object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ClientBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idC':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC = valueDes;
          break;
        case r'nameC':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameC = valueDes;
          break;
        case r'emailC':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.emailC = valueDes;
          break;
        case r'passwordC':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.passwordC = valueDes;
          break;
        case r'pictureC':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.pictureC = valueDes;
          break;
        case r'activitycomments':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Activitycomment)]),
          ) as BuiltList<Activitycomment>?;
          if (valueDes == null) continue;
          result.activitycomments.replace(valueDes);
          break;
        case r'changepasswordcodes':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Changepasswordcode)]),
          ) as BuiltList<Changepasswordcode>?;
          if (valueDes == null) continue;
          result.changepasswordcodes.replace(valueDes);
          break;
        case r'messages':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Message)]),
          ) as BuiltList<Message>?;
          if (valueDes == null) continue;
          result.messages.replace(valueDes);
          break;
        case r'projectpays':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Projectpay)]),
          ) as BuiltList<Projectpay>?;
          if (valueDes == null) continue;
          result.projectpays.replace(valueDes);
          break;
        case r'projects':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Project)]),
          ) as BuiltList<Project>?;
          if (valueDes == null) continue;
          result.projects.replace(valueDes);
          break;
        case r'proposalnotifications':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Proposalnotification)]),
          ) as BuiltList<Proposalnotification>?;
          if (valueDes == null) continue;
          result.proposalnotifications.replace(valueDes);
          break;
        case r'proposals':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Proposal)]),
          ) as BuiltList<Proposal>?;
          if (valueDes == null) continue;
          result.proposals.replace(valueDes);
          break;
        case r'securityanswerclients':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerclient)]),
          ) as BuiltList<Securityanswerclient>?;
          if (valueDes == null) continue;
          result.securityanswerclients.replace(valueDes);
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
  Client deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ClientBuilder();
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

