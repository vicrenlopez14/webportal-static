//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/projecttemplate.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'tagtemplate.g.dart';

/// Tagtemplate
///
/// Properties:
/// * [idTt] 
/// * [nameTt] 
/// * [colorTt] 
/// * [idPt1] 
/// * [idPt1Navigation] 
@BuiltValue()
abstract class Tagtemplate implements Built<Tagtemplate, TagtemplateBuilder> {
  @BuiltValueField(wireName: r'idTt')
  String? get idTt;

  @BuiltValueField(wireName: r'nameTt')
  String? get nameTt;

  @BuiltValueField(wireName: r'colorTt')
  String? get colorTt;

  @BuiltValueField(wireName: r'idPt1')
  String? get idPt1;

  @BuiltValueField(wireName: r'idPt1Navigation')
  Projecttemplate? get idPt1Navigation;

  Tagtemplate._();

  factory Tagtemplate([void updates(TagtemplateBuilder b)]) = _$Tagtemplate;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(TagtemplateBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Tagtemplate> get serializer => _$TagtemplateSerializer();
}

class _$TagtemplateSerializer implements PrimitiveSerializer<Tagtemplate> {
  @override
  final Iterable<Type> types = const [Tagtemplate, _$Tagtemplate];

  @override
  final String wireName = r'Tagtemplate';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Tagtemplate object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idTt != null) {
      yield r'idTt';
      yield serializers.serialize(
        object.idTt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.nameTt != null) {
      yield r'nameTt';
      yield serializers.serialize(
        object.nameTt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.colorTt != null) {
      yield r'colorTt';
      yield serializers.serialize(
        object.colorTt,
        specifiedType: const FullType.nullable(String),
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
    Tagtemplate object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required TagtemplateBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idTt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idTt = valueDes;
          break;
        case r'nameTt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameTt = valueDes;
          break;
        case r'colorTt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.colorTt = valueDes;
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
  Tagtemplate deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = TagtemplateBuilder();
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

