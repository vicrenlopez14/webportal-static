//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/securityansweradmin.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/changepasswordcode.dart';
import 'package:profind_api/src/model/rank.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'admin.g.dart';

/// Admin
///
/// Properties:
/// * [idA] 
/// * [nameA] 
/// * [emailA] 
/// * [telA] 
/// * [passwordA] 
/// * [pictureA] 
/// * [idR1] 
/// * [idR1Navigation] 
/// * [changepasswordcodes] 
/// * [securityansweradmins] 
/// * [supporttickets] 
@BuiltValue()
abstract class Admin implements Built<Admin, AdminBuilder> {
  @BuiltValueField(wireName: r'idA')
  String? get idA;

  @BuiltValueField(wireName: r'nameA')
  String? get nameA;

  @BuiltValueField(wireName: r'emailA')
  String? get emailA;

  @BuiltValueField(wireName: r'telA')
  String? get telA;

  @BuiltValueField(wireName: r'passwordA')
  String? get passwordA;

  @BuiltValueField(wireName: r'pictureA')
  String? get pictureA;

  @BuiltValueField(wireName: r'idR1')
  int? get idR1;

  @BuiltValueField(wireName: r'idR1Navigation')
  Rank? get idR1Navigation;

  @BuiltValueField(wireName: r'changepasswordcodes')
  BuiltList<Changepasswordcode>? get changepasswordcodes;

  @BuiltValueField(wireName: r'securityansweradmins')
  BuiltList<Securityansweradmin>? get securityansweradmins;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  Admin._();

  factory Admin([void updates(AdminBuilder b)]) = _$Admin;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(AdminBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Admin> get serializer => _$AdminSerializer();
}

class _$AdminSerializer implements PrimitiveSerializer<Admin> {
  @override
  final Iterable<Type> types = const [Admin, _$Admin];

  @override
  final String wireName = r'Admin';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Admin object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idA != null) {
      yield r'idA';
      yield serializers.serialize(
        object.idA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.nameA != null) {
      yield r'nameA';
      yield serializers.serialize(
        object.nameA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.emailA != null) {
      yield r'emailA';
      yield serializers.serialize(
        object.emailA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.telA != null) {
      yield r'telA';
      yield serializers.serialize(
        object.telA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.passwordA != null) {
      yield r'passwordA';
      yield serializers.serialize(
        object.passwordA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.pictureA != null) {
      yield r'pictureA';
      yield serializers.serialize(
        object.pictureA,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idR1 != null) {
      yield r'idR1';
      yield serializers.serialize(
        object.idR1,
        specifiedType: const FullType.nullable(int),
      );
    }
    if (object.idR1Navigation != null) {
      yield r'idR1Navigation';
      yield serializers.serialize(
        object.idR1Navigation,
        specifiedType: const FullType(Rank),
      );
    }
    if (object.changepasswordcodes != null) {
      yield r'changepasswordcodes';
      yield serializers.serialize(
        object.changepasswordcodes,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Changepasswordcode)]),
      );
    }
    if (object.securityansweradmins != null) {
      yield r'securityansweradmins';
      yield serializers.serialize(
        object.securityansweradmins,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Securityansweradmin)]),
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
    Admin object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required AdminBuilder result,
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
        case r'nameA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameA = valueDes;
          break;
        case r'emailA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.emailA = valueDes;
          break;
        case r'telA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.telA = valueDes;
          break;
        case r'passwordA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.passwordA = valueDes;
          break;
        case r'pictureA':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.pictureA = valueDes;
          break;
        case r'idR1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(int),
          ) as int?;
          if (valueDes == null) continue;
          result.idR1 = valueDes;
          break;
        case r'idR1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Rank),
          ) as Rank;
          result.idR1Navigation.replace(valueDes);
          break;
        case r'changepasswordcodes':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Changepasswordcode)]),
          ) as BuiltList<Changepasswordcode>?;
          if (valueDes == null) continue;
          result.changepasswordcodes.replace(valueDes);
          break;
        case r'securityansweradmins':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Securityansweradmin)]),
          ) as BuiltList<Securityansweradmin>?;
          if (valueDes == null) continue;
          result.securityansweradmins.replace(valueDes);
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
  Admin deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = AdminBuilder();
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

