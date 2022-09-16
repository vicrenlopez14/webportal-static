//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/professional.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/projectpaytemplate.dart';
import 'package:profind_api/src/model/tagtemplate.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'projecttemplate.g.dart';

/// Projecttemplate
///
/// Properties:
/// * [idPt] 
/// * [titlePt] 
/// * [descriptionPt] 
/// * [picturePt] 
/// * [totalPricePt] 
/// * [saveTagsPt] 
/// * [saveProjectPaysPt] 
/// * [idP1] 
/// * [idP1Navigation] 
/// * [projectpaytemplates] 
/// * [tagtemplates] 
@BuiltValue()
abstract class Projecttemplate implements Built<Projecttemplate, ProjecttemplateBuilder> {
  @BuiltValueField(wireName: r'idPt')
  String? get idPt;

  @BuiltValueField(wireName: r'titlePt')
  String? get titlePt;

  @BuiltValueField(wireName: r'descriptionPt')
  String? get descriptionPt;

  @BuiltValueField(wireName: r'picturePt')
  String? get picturePt;

  @BuiltValueField(wireName: r'totalPricePt')
  double? get totalPricePt;

  @BuiltValueField(wireName: r'saveTagsPt')
  bool? get saveTagsPt;

  @BuiltValueField(wireName: r'saveProjectPaysPt')
  bool? get saveProjectPaysPt;

  @BuiltValueField(wireName: r'idP1')
  String? get idP1;

  @BuiltValueField(wireName: r'idP1Navigation')
  Professional? get idP1Navigation;

  @BuiltValueField(wireName: r'projectpaytemplates')
  BuiltList<Projectpaytemplate>? get projectpaytemplates;

  @BuiltValueField(wireName: r'tagtemplates')
  BuiltList<Tagtemplate>? get tagtemplates;

  Projecttemplate._();

  factory Projecttemplate([void updates(ProjecttemplateBuilder b)]) = _$Projecttemplate;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProjecttemplateBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Projecttemplate> get serializer => _$ProjecttemplateSerializer();
}

class _$ProjecttemplateSerializer implements PrimitiveSerializer<Projecttemplate> {
  @override
  final Iterable<Type> types = const [Projecttemplate, _$Projecttemplate];

  @override
  final String wireName = r'Projecttemplate';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Projecttemplate object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idPt != null) {
      yield r'idPt';
      yield serializers.serialize(
        object.idPt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.titlePt != null) {
      yield r'titlePt';
      yield serializers.serialize(
        object.titlePt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.descriptionPt != null) {
      yield r'descriptionPt';
      yield serializers.serialize(
        object.descriptionPt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.picturePt != null) {
      yield r'picturePt';
      yield serializers.serialize(
        object.picturePt,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.totalPricePt != null) {
      yield r'totalPricePt';
      yield serializers.serialize(
        object.totalPricePt,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.saveTagsPt != null) {
      yield r'saveTagsPt';
      yield serializers.serialize(
        object.saveTagsPt,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.saveProjectPaysPt != null) {
      yield r'saveProjectPaysPt';
      yield serializers.serialize(
        object.saveProjectPaysPt,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.idP1 != null) {
      yield r'idP1';
      yield serializers.serialize(
        object.idP1,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.idP1Navigation != null) {
      yield r'idP1Navigation';
      yield serializers.serialize(
        object.idP1Navigation,
        specifiedType: const FullType(Professional),
      );
    }
    if (object.projectpaytemplates != null) {
      yield r'projectpaytemplates';
      yield serializers.serialize(
        object.projectpaytemplates,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Projectpaytemplate)]),
      );
    }
    if (object.tagtemplates != null) {
      yield r'tagtemplates';
      yield serializers.serialize(
        object.tagtemplates,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Tagtemplate)]),
      );
    }
  }

  @override
  Object serialize(
    Serializers serializers,
    Projecttemplate object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProjecttemplateBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idPt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idPt = valueDes;
          break;
        case r'titlePt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.titlePt = valueDes;
          break;
        case r'descriptionPt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.descriptionPt = valueDes;
          break;
        case r'picturePt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.picturePt = valueDes;
          break;
        case r'totalPricePt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.totalPricePt = valueDes;
          break;
        case r'saveTagsPt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.saveTagsPt = valueDes;
          break;
        case r'saveProjectPaysPt':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.saveProjectPaysPt = valueDes;
          break;
        case r'idP1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP1 = valueDes;
          break;
        case r'idP1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Professional),
          ) as Professional;
          result.idP1Navigation.replace(valueDes);
          break;
        case r'projectpaytemplates':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Projectpaytemplate)]),
          ) as BuiltList<Projectpaytemplate>?;
          if (valueDes == null) continue;
          result.projectpaytemplates.replace(valueDes);
          break;
        case r'tagtemplates':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Tagtemplate)]),
          ) as BuiltList<Tagtemplate>?;
          if (valueDes == null) continue;
          result.tagtemplates.replace(valueDes);
          break;
        default:
          unhandled.add(key);
          unhandled.add(value);
          break;
      }
    }
  }

  @override
  Projecttemplate deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProjecttemplateBuilder();
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

