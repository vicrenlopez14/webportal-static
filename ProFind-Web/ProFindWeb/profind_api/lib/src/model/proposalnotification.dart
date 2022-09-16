//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/proposal.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'proposalnotification.g.dart';

/// Proposalnotification
///
/// Properties:
/// * [idPn] 
/// * [contentPn] 
/// * [imagePn] 
/// * [actionPn] 
/// * [idPp1] 
/// * [idP4] 
/// * [idC4] 
/// * [idC4Navigation] 
/// * [idP4Navigation] 
/// * [idPp1Navigation] 
@BuiltValue()
abstract class Proposalnotification implements Built<Proposalnotification, ProposalnotificationBuilder> {
  @BuiltValueField(wireName: r'idPn')
  String? get idPn;

  @BuiltValueField(wireName: r'contentPn')
  String? get contentPn;

  @BuiltValueField(wireName: r'imagePn')
  String? get imagePn;

  @BuiltValueField(wireName: r'actionPn')
  String? get actionPn;

  @BuiltValueField(wireName: r'idPp1')
  String? get idPp1;

  @BuiltValueField(wireName: r'idP4')
  String? get idP4;

  @BuiltValueField(wireName: r'idC4')
  String? get idC4;

  @BuiltValueField(wireName: r'idC4Navigation')
  Client? get idC4Navigation;

  @BuiltValueField(wireName: r'idP4Navigation')
  Professional? get idP4Navigation;

  @BuiltValueField(wireName: r'idPp1Navigation')
  Proposal? get idPp1Navigation;

  Proposalnotification._();

  factory Proposalnotification([void updates(ProposalnotificationBuilder b)]) = _$Proposalnotification;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProposalnotificationBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Proposalnotification> get serializer => _$ProposalnotificationSerializer();
}

class _$ProposalnotificationSerializer implements PrimitiveSerializer<Proposalnotification> {
  @override
  final Iterable<Type> types = const [Proposalnotification, _$Proposalnotification];

  @override
  final String wireName = r'Proposalnotification';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Proposalnotification object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPn != null) {
      yield r'idPn';
      yield serializers.serialize(
        object.idPn,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.contentPn != null) {
      yield r'contentPn';
      yield serializers.serialize(
        object.contentPn,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.imagePn != null) {
      yield r'imagePn';
      yield serializers.serialize(
        object.imagePn,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.actionPn != null) {
      yield r'actionPn';
      yield serializers.serialize(
        object.actionPn,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPp1 != null) {
      yield r'idPp1';
      yield serializers.serialize(
        object.idPp1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP4 != null) {
      yield r'idP4';
      yield serializers.serialize(
        object.idP4,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC4 != null) {
      yield r'idC4';
      yield serializers.serialize(
        object.idC4,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idC4Navigation != null) {
      yield r'idC4Navigation';
      yield serializers.serialize(
        object.idC4Navigation,
        specifiedType: const FullType(Client),
      );
    }
    if (object.idP4Navigation != null) {
      yield r'idP4Navigation';
      yield serializers.serialize(
        object.idP4Navigation,
        specifiedType: const FullType(Professional),
      );
    }
    if (object.idPp1Navigation != null) {
      yield r'idPp1Navigation';
      yield serializers.serialize(
        object.idPp1Navigation,
        specifiedType: const FullType(Proposal),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Proposalnotification object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProposalnotificationBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPn':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPn = valueDes;
          break;
        case r'contentPn':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.contentPn = valueDes;
          break;
        case r'imagePn':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.imagePn = valueDes;
          break;
        case r'actionPn':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.actionPn = valueDes;
          break;
        case r'idPp1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPp1 = valueDes;
          break;
        case r'idP4':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP4 = valueDes;
          break;
        case r'idC4':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC4 = valueDes;
          break;
        case r'idC4Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Client),
          ) as Client;
          result.idC4Navigation.replace(valueDes);
          break;
        case r'idP4Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP4Navigation.replace(valueDes);
          break;
        case r'idPp1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Proposal),
          ) as Proposal;
          result.idPp1Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Proposalnotification deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProposalnotificationBuilder();
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

