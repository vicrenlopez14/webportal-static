//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:built_collection/built_collection.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'projectpay.g.dart';

/// Projectpay
///
/// Properties:
/// * [idPpy] 
/// * [percentagePpy] 
/// * [conceptPpy] 
/// * [amountPpy] 
/// * [currencyPpy] 
/// * [hasLimitDatePpy] 
/// * [limitDatePpy] 
/// * [defaultAmountPpy] 
/// * [payStatusPpy] 
/// * [idP3] 
/// * [idC3] 
/// * [idPj3] 
/// * [idC3Navigation] 
/// * [idP3Navigation] 
/// * [idPj3Navigation] 
/// * [supporttickets] 
@BuiltValue()
abstract class Projectpay implements Built<Projectpay, ProjectpayBuilder> {
  @BuiltValueField(wireName: r'idPpy')
  String? get idPpy;

  @BuiltValueField(wireName: r'percentagePpy')
  double? get percentagePpy;

  @BuiltValueField(wireName: r'conceptPpy')
  String? get conceptPpy;

  @BuiltValueField(wireName: r'amountPpy')
  double? get amountPpy;

  @BuiltValueField(wireName: r'currencyPpy')
  String? get currencyPpy;

  @BuiltValueField(wireName: r'hasLimitDatePpy')
  bool? get hasLimitDatePpy;

  @BuiltValueField(wireName: r'limitDatePpy')
  DateTime? get limitDatePpy;

  @BuiltValueField(wireName: r'defaultAmountPpy')
  double? get defaultAmountPpy;

  @BuiltValueField(wireName: r'payStatusPpy')
  String? get payStatusPpy;

  @BuiltValueField(wireName: r'idP3')
  String? get idP3;

  @BuiltValueField(wireName: r'idC3')
  String? get idC3;

  @BuiltValueField(wireName: r'idPj3')
  String? get idPj3;

  @BuiltValueField(wireName: r'idC3Navigation')
  Client? get idC3Navigation;

  @BuiltValueField(wireName: r'idP3Navigation')
  Professional? get idP3Navigation;

  @BuiltValueField(wireName: r'idPj3Navigation')
  Project? get idPj3Navigation;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  Projectpay._();

  factory Projectpay([void updates(ProjectpayBuilder b)]) = _$Projectpay;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProjectpayBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Projectpay> get serializer => _$ProjectpaySerializer();
}

class _$ProjectpaySerializer implements PrimitiveSerializer<Projectpay> {
  @override
  final Iterable<Type> types = const [Projectpay, _$Projectpay];

  @override
  final String wireName = r'Projectpay';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Projectpay object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPpy != null) {
      yield r'idPpy';
      yield serializers.serialize(
        object.idPpy,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.percentagePpy != null) {
      yield r'percentagePpy';
      yield serializers.serialize(
        object.percentagePpy,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.conceptPpy != null) {
      yield r'conceptPpy';
      yield serializers.serialize(
        object.conceptPpy,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.amountPpy != null) {
      yield r'amountPpy';
      yield serializers.serialize(
        object.amountPpy,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.currencyPpy != null) {
      yield r'currencyPpy';
      yield serializers.serialize(
        object.currencyPpy,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.hasLimitDatePpy != null) {
      yield r'hasLimitDatePpy';
      yield serializers.serialize(
        object.hasLimitDatePpy,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.limitDatePpy != null) {
      yield r'limitDatePpy';
      yield serializers.serialize(
        object.limitDatePpy,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.defaultAmountPpy != null) {
      yield r'defaultAmountPpy';
      yield serializers.serialize(
        object.defaultAmountPpy,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.payStatusPpy != null) {
      yield r'payStatusPpy';
      yield serializers.serialize(
        object.payStatusPpy,
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
    if (object.idPj3 != null) {
      yield r'idPj3';
      yield serializers.serialize(
        object.idPj3,
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
    if (object.idPj3Navigation != null) {
      yield r'idPj3Navigation';
      yield serializers.serialize(
        object.idPj3Navigation,
        specifiedType: const FullType(Project),
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
    Projectpay object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProjectpayBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPpy = valueDes;
          break;
        case r'percentagePpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.percentagePpy = valueDes;
          break;
        case r'conceptPpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.conceptPpy = valueDes;
          break;
        case r'amountPpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.amountPpy = valueDes;
          break;
        case r'currencyPpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.currencyPpy = valueDes;
          break;
        case r'hasLimitDatePpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.hasLimitDatePpy = valueDes;
          break;
        case r'limitDatePpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.limitDatePpy = valueDes;
          break;
        case r'defaultAmountPpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.defaultAmountPpy = valueDes;
          break;
        case r'payStatusPpy':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.payStatusPpy = valueDes;
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
        case r'idPj3':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPj3 = valueDes;
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
        case r'idPj3Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Project),
          ) as Project;
          result.idPj3Navigation.replace(valueDes);
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
  Projectpay deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProjectpayBuilder();
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

