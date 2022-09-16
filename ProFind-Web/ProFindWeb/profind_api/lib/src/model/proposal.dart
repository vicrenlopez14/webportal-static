//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/proposalnotification.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'proposal.g.dart';

/// Proposal
///
/// Properties:
/// * [idPp] 
/// * [titlePp] 
/// * [descriptionPp] 
/// * [picturePp] 
/// * [suggestedStart] 
/// * [suggestedEnd] 
/// * [seen] 
/// * [revisionStatus] 
/// * [idP3] 
/// * [idC3] 
/// * [idC3Navigation] 
/// * [idP3Navigation] 
/// * [proposalnotifications] 
/// * [supporttickets] 
@BuiltValue()
abstract class Proposal implements Built<Proposal, ProposalBuilder> {
  @BuiltValueField(wireName: r'idPp')
  String? get idPp;

  @BuiltValueField(wireName: r'titlePp')
  String? get titlePp;

  @BuiltValueField(wireName: r'descriptionPp')
  String? get descriptionPp;

  @BuiltValueField(wireName: r'picturePp')
  String? get picturePp;

  @BuiltValueField(wireName: r'suggestedStart')
  DateTime? get suggestedStart;

  @BuiltValueField(wireName: r'suggestedEnd')
  DateTime? get suggestedEnd;

  @BuiltValueField(wireName: r'seen')
  bool? get seen;

  @BuiltValueField(wireName: r'revisionStatus')
  String? get revisionStatus;

  @BuiltValueField(wireName: r'idP3')
  String? get idP3;

  @BuiltValueField(wireName: r'idC3')
  String? get idC3;

  @BuiltValueField(wireName: r'idC3Navigation')
  Client? get idC3Navigation;

  @BuiltValueField(wireName: r'idP3Navigation')
  Professional? get idP3Navigation;

  @BuiltValueField(wireName: r'proposalnotifications')
  BuiltList<Proposalnotification>? get proposalnotifications;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  Proposal._();

  factory Proposal([void updates(ProposalBuilder b)]) = _$Proposal;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProposalBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Proposal> get serializer => _$ProposalSerializer();
}

class _$ProposalSerializer implements PrimitiveSerializer<Proposal> {
  @override
  final Iterable<Type> types = const [Proposal, _$Proposal];

  @override
  final String wireName = r'Proposal';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Proposal object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPp != null) {
      yield r'idPp';
      yield serializers.serialize(
        object.idPp,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titlePp != null) {
      yield r'titlePp';
      yield serializers.serialize(
        object.titlePp,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionPp != null) {
      yield r'descriptionPp';
      yield serializers.serialize(
        object.descriptionPp,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.picturePp != null) {
      yield r'picturePp';
      yield serializers.serialize(
        object.picturePp,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.suggestedStart != null) {
      yield r'suggestedStart';
      yield serializers.serialize(
        object.suggestedStart,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.suggestedEnd != null) {
      yield r'suggestedEnd';
      yield serializers.serialize(
        object.suggestedEnd,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.seen != null) {
      yield r'seen';
      yield serializers.serialize(
        object.seen,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.revisionStatus != null) {
      yield r'revisionStatus';
      yield serializers.serialize(
        object.revisionStatus,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP3 != null) {
      yield r'idP3';
      yield serializers.serialize(
        object.idP3,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC3 != null) {
      yield r'idC3';
      yield serializers.serialize(
        object.idC3,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC3Navigation != null) {
      yield r'idC3Navigation';
      yield serializers.serialize(
        object.idC3Navigation,
        specifiedType: const FullType(Client),
      );
    }
    if (object.idP3Navigation != null) {
      yield r'idP3Navigation';
      yield serializers.serialize(
        object.idP3Navigation,
        specifiedType: const FullType(Professional),
      );
    }
    if (object.proposalnotifications != null) {
      yield r'proposalnotifications';
      yield serializers.serialize(
        object.proposalnotifications,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Proposalnotification)]),
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
    Proposal object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProposalBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPp = valueDes;
          break;
        case r'titlePp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titlePp = valueDes;
          break;
        case r'descriptionPp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionPp = valueDes;
          break;
        case r'picturePp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.picturePp = valueDes;
          break;
        case r'suggestedStart':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.suggestedStart = valueDes;
          break;
        case r'suggestedEnd':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.suggestedEnd = valueDes;
          break;
        case r'seen':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.seen = valueDes;
          break;
        case r'revisionStatus':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.revisionStatus = valueDes;
          break;
        case r'idP3':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP3 = valueDes;
          break;
        case r'idC3':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC3 = valueDes;
          break;
        case r'idC3Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Client),
          ) as Client;
          result.idC3Navigation.replace(valueDes);
          break;
        case r'idP3Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP3Navigation.replace(valueDes);
          break;
        case r'proposalnotifications':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Proposalnotification)]),
          ) as BuiltList<Proposalnotification>?;
          if (valueDes == null) continue;
          result.proposalnotifications.replace(valueDes);
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
  Proposal deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProposalBuilder();
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

