//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/projecttemplate.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'projectpaytemplate.g.dart';

/// Projectpaytemplate
///
/// Properties:
/// * [idPpt] 
/// * [titlePpt] 
/// * [descriptionPpt] 
/// * [picturePpt] 
/// * [totalPricePpt] 
/// * [idPt1] 
/// * [idPt1Navigation] 
@BuiltValue()
abstract class Projectpaytemplate implements Built<Projectpaytemplate, ProjectpaytemplateBuilder> {
  @BuiltValueField(wireName: r'idPpt')
  String? get idPpt;

  @BuiltValueField(wireName: r'titlePpt')
  String? get titlePpt;

  @BuiltValueField(wireName: r'descriptionPpt')
  String? get descriptionPpt;

  @BuiltValueField(wireName: r'picturePpt')
  String? get picturePpt;

  @BuiltValueField(wireName: r'totalPricePpt')
  double? get totalPricePpt;

  @BuiltValueField(wireName: r'idPt1')
  String? get idPt1;

  @BuiltValueField(wireName: r'idPt1Navigation')
  Projecttemplate? get idPt1Navigation;

  Projectpaytemplate._();

  factory Projectpaytemplate([void updates(ProjectpaytemplateBuilder b)]) = _$Projectpaytemplate;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProjectpaytemplateBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Projectpaytemplate> get serializer => _$ProjectpaytemplateSerializer();
}

class _$ProjectpaytemplateSerializer implements PrimitiveSerializer<Projectpaytemplate> {
  @override
  final Iterable<Type> types = const [Projectpaytemplate, _$Projectpaytemplate];

  @override
  final String wireName = r'Projectpaytemplate';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Projectpaytemplate object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPpt != null) {
      yield r'idPpt';
      yield serializers.serialize(
        object.idPpt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titlePpt != null) {
      yield r'titlePpt';
      yield serializers.serialize(
        object.titlePpt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionPpt != null) {
      yield r'descriptionPpt';
      yield serializers.serialize(
        object.descriptionPpt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.picturePpt != null) {
      yield r'picturePpt';
      yield serializers.serialize(
        object.picturePpt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.totalPricePpt != null) {
      yield r'totalPricePpt';
      yield serializers.serialize(
        object.totalPricePpt,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.idPt1 != null) {
      yield r'idPt1';
      yield serializers.serialize(
        object.idPt1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idPt1Navigation != null) {
      yield r'idPt1Navigation';
      yield serializers.serialize(
        object.idPt1Navigation,
        specifiedType: const FullType(Projecttemplate),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Projectpaytemplate object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProjectpaytemplateBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPpt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPpt = valueDes;
          break;
        case r'titlePpt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titlePpt = valueDes;
          break;
        case r'descriptionPpt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionPpt = valueDes;
          break;
        case r'picturePpt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.picturePpt = valueDes;
          break;
        case r'totalPricePpt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.totalPricePpt = valueDes;
          break;
        case r'idPt1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPt1 = valueDes;
          break;
        case r'idPt1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Projecttemplate),
          ) as Projecttemplate;
          result.idPt1Navigation.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Projectpaytemplate deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProjectpaytemplateBuilder();
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

