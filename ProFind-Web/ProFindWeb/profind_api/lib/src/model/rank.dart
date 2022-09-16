//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/admin.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'rank.g.dart';

/// Rank
///
/// Properties:
/// * [idR] 
/// * [nameR] 
/// * [admins] 
@BuiltValue()
abstract class Rank implements Built<Rank, RankBuilder> {
  @BuiltValueField(wireName: r'idR')
  int? get idR;

  @BuiltValueField(wireName: r'nameR')
  String? get nameR;

  @BuiltValueField(wireName: r'admins')
  BuiltList<Admin>? get admins;

  Rank._();

  factory Rank([void updates(RankBuilder b)]) = _$Rank;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(RankBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Rank> get serializer => _$RankSerializer();
}

class _$RankSerializer implements PrimitiveSerializer<Rank> {
  @override
  final Iterable<Type> types = const [Rank, _$Rank];

  @override
  final String wireName = r'Rank';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Rank object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idR != null) {
      yield r'idR';
      yield serializers.serialize(
        object.idR,
        specifiedType: const FullType(int),
      );
    }
    if (object.nameR != null) {
      yield r'nameR';
      yield serializers.serialize(
        object.nameR,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.admins != null) {
      yield r'admins';
      yield serializers.serialize(
        object.admins,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Admin)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Rank object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required RankBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idR':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(int),
          ) as int;
          result.idR = valueDes;
          break;
        case r'nameR':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameR = valueDes;
          break;
        case r'admins':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Admin)]),
          ) as BuiltList<Admin>?;
          if (valueDes == null) continue;
          result.admins.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Rank deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = RankBuilder();
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

