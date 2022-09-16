//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/date_only.dart';
import 'package:profind_api/src/model/admin.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'changepasswordcode.g.dart';

/// Changepasswordcode
///
/// Properties:
/// * [idCpc] 
/// * [verifiedCpc] 
/// * [validCpc] 
/// * [issueDateCpc] 
/// * [idC1] 
/// * [idA1] 
/// * [idP1] 
/// * [idA1Navigation] 
/// * [idC1Navigation] 
/// * [idP1Navigation] 
@BuiltValue()
abstract class Changepasswordcode implements Built<Changepasswordcode, ChangepasswordcodeBuilder> {
  @BuiltValueField(wireName: r'idCpc')
  String? get idCpc;

  @BuiltValueField(wireName: r'verifiedCpc')
  bool? get verifiedCpc;

  @BuiltValueField(wireName: r'validCpc')
  bool? get validCpc;

  @BuiltValueField(wireName: r'issueDateCpc')
  DateOnly? get issueDateCpc;

  @BuiltValueField(wireName: r'idC1')
  String? get idC1;

  @BuiltValueField(wireName: r'idA1')
  String? get idA1;

  @BuiltValueField(wireName: r'idP1')
  String? get idP1;

  @BuiltValueField(wireName: r'idA1Navigation')
  Admin? get idA1Navigation;

  @BuiltValueField(wireName: r'idC1Navigation')
  Client? get idC1Navigation;

  @BuiltValueField(wireName: r'idP1Navigation')
  Professional? get idP1Navigation;

  Changepasswordcode._();

  factory Changepasswordcode([void updates(ChangepasswordcodeBuilder b)]) = _$Changepasswordcode;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ChangepasswordcodeBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Changepasswordcode> get serializer => _$ChangepasswordcodeSerializer();
}

class _$ChangepasswordcodeSerializer implements PrimitiveSerializer<Changepasswordcode> {
  @override
  final Iterable<Type> types = const [Changepasswordcode, _$Changepasswordcode];

  @override
  final String wireName = r'Changepasswordcode';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Changepasswordcode object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idCpc != null) {
      yield r'idCpc';
      yield serializers.serialize(
        object.idCpc,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.verifiedCpc != null) {
      yield r'verifiedCpc';
      yield serializers.serialize(
        object.verifiedCpc,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.validCpc != null) {
      yield r'validCpc';
      yield serializers.serialize(
        object.validCpc,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.issueDateCpc != null) {
      yield r'issueDateCpc';
      yield serializers.serialize(
        object.issueDateCpc,
        specifiedType: const FullType(DateOnly),
      );
    }
    if (object.idC1 != null) {
      yield r'idC1';
      yield serializers.serialize(
        object.idC1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idA1 != null) {
      yield r'idA1';
      yield serializers.serialize(
        object.idA1,
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
    if (object.idA1Navigation != null) {
      yield r'idA1Navigation';
      yield serializers.serialize(
        object.idA1Navigation,
        specifiedType: const FullType(Admin),
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
  }

  @override
  Object serialize(
    Serializers serializers,
    Changepasswordcode object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ChangepasswordcodeBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idCpc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idCpc = valueDes;
          break;
        case r'verifiedCpc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.verifiedCpc = valueDes;
          break;
        case r'validCpc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.validCpc = valueDes;
          break;
        case r'issueDateCpc':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(DateOnly),
          ) as DateOnly;
          result.issueDateCpc.replace(valueDes);
          break;
        case r'idC1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idC1 = valueDes;
          break;
        case r'idA1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idA1 = valueDes;
          break;
        case r'idP1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP1 = valueDes;
          break;
        case r'idA1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Admin),
          ) as Admin;
          result.idA1Navigation.replace(valueDes);
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
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Changepasswordcode deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ChangepasswordcodeBuilder();
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

