//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_element
import 'package:profind_api/src/model/securityanswerprofessional.dart';
import 'package:profind_api/src/model/department.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:profind_api/src/model/proposalnotification.dart';
import 'package:profind_api/src/model/proposal.dart';
import 'package:profind_api/src/model/activitycomment.dart';
import 'package:profind_api/src/model/profession.dart';
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/projectpay.dart';
import 'package:profind_api/src/model/projecttemplate.dart';
import 'package:profind_api/src/model/message.dart';
import 'package:built_collection/built_collection.dart';
import 'package:profind_api/src/model/changepasswordcode.dart';
import 'package:built_value/built_value.dart';
import 'package:built_value/serializer.dart';

part 'professional.g.dart';

/// Professional
///
/// Properties:
/// * [idP] 
/// * [nameP] 
/// * [dateBirthP] 
/// * [emailP] 
/// * [passwordP] 
/// * [activeP] 
/// * [sexP] 
/// * [duip] 
/// * [afpp] 
/// * [isssp] 
/// * [zipCodeP] 
/// * [salaryP] 
/// * [hiringDateP] 
/// * [pictureP] 
/// * [curriculumP] 
/// * [latitudeLocationP] 
/// * [longitudeLocationP] 
/// * [idPfs1] 
/// * [idDp1] 
/// * [idWdt1] 
/// * [idDp1Navigation] 
/// * [idPfs1Navigation] 
/// * [activitycomments] 
/// * [changepasswordcodes] 
/// * [messages] 
/// * [projectpays] 
/// * [projects] 
/// * [projecttemplates] 
/// * [proposalnotifications] 
/// * [proposals] 
/// * [securityanswerprofessionals] 
/// * [supporttickets] 
@BuiltValue()
abstract class Professional implements Built<Professional, ProfessionalBuilder> {
  @BuiltValueField(wireName: r'idP')
  String? get idP;

  @BuiltValueField(wireName: r'nameP')
  String? get nameP;

  @BuiltValueField(wireName: r'dateBirthP')
  DateTime? get dateBirthP;

  @BuiltValueField(wireName: r'emailP')
  String? get emailP;

  @BuiltValueField(wireName: r'passwordP')
  String? get passwordP;

  @BuiltValueField(wireName: r'activeP')
  bool? get activeP;

  @BuiltValueField(wireName: r'sexP')
  bool? get sexP;

  @BuiltValueField(wireName: r'duip')
  String? get duip;

  @BuiltValueField(wireName: r'afpp')
  String? get afpp;

  @BuiltValueField(wireName: r'isssp')
  String? get isssp;

  @BuiltValueField(wireName: r'zipCodeP')
  String? get zipCodeP;

  @BuiltValueField(wireName: r'salaryP')
  double? get salaryP;

  @BuiltValueField(wireName: r'hiringDateP')
  DateTime? get hiringDateP;

  @BuiltValueField(wireName: r'pictureP')
  String? get pictureP;

  @BuiltValueField(wireName: r'curriculumP')
  String? get curriculumP;

  @BuiltValueField(wireName: r'latitudeLocationP')
  double? get latitudeLocationP;

  @BuiltValueField(wireName: r'longitudeLocationP')
  double? get longitudeLocationP;

  @BuiltValueField(wireName: r'idPfs1')
  int? get idPfs1;

  @BuiltValueField(wireName: r'idDp1')
  int? get idDp1;

  @BuiltValueField(wireName: r'idWdt1')
  int? get idWdt1;

  @BuiltValueField(wireName: r'idDp1Navigation')
  Department? get idDp1Navigation;

  @BuiltValueField(wireName: r'idPfs1Navigation')
  Profession? get idPfs1Navigation;

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

  @BuiltValueField(wireName: r'projecttemplates')
  BuiltList<Projecttemplate>? get projecttemplates;

  @BuiltValueField(wireName: r'proposalnotifications')
  BuiltList<Proposalnotification>? get proposalnotifications;

  @BuiltValueField(wireName: r'proposals')
  BuiltList<Proposal>? get proposals;

  @BuiltValueField(wireName: r'securityanswerprofessionals')
  BuiltList<Securityanswerprofessional>? get securityanswerprofessionals;

  @BuiltValueField(wireName: r'supporttickets')
  BuiltList<Supportticket>? get supporttickets;

  Professional._();

  factory Professional([void updates(ProfessionalBuilder b)]) = _$Professional;

  @BuiltValueHook(initializeBuilder: true)
  static void _defaults(ProfessionalBuilder b) => b;

  @BuiltValueSerializer(custom: true)
  static Serializer<Professional> get serializer => _$ProfessionalSerializer();
}

class _$ProfessionalSerializer implements PrimitiveSerializer<Professional> {
  @override
  final Iterable<Type> types = const [Professional, _$Professional];

  @override
  final String wireName = r'Professional';

  Iterable<Object?> _serializeProperties(
    Serializers serializers,
    Professional object, {
    FullType specifiedType = FullType.unspecified,
  }) sync* {
    if (object.idP != null) {
      yield r'idP';
      yield serializers.serialize(
        object.idP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.nameP != null) {
      yield r'nameP';
      yield serializers.serialize(
        object.nameP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.dateBirthP != null) {
      yield r'dateBirthP';
      yield serializers.serialize(
        object.dateBirthP,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.emailP != null) {
      yield r'emailP';
      yield serializers.serialize(
        object.emailP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.passwordP != null) {
      yield r'passwordP';
      yield serializers.serialize(
        object.passwordP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.activeP != null) {
      yield r'activeP';
      yield serializers.serialize(
        object.activeP,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.sexP != null) {
      yield r'sexP';
      yield serializers.serialize(
        object.sexP,
        specifiedType: const FullType.nullable(bool),
      );
    }
    if (object.duip != null) {
      yield r'duip';
      yield serializers.serialize(
        object.duip,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.afpp != null) {
      yield r'afpp';
      yield serializers.serialize(
        object.afpp,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.isssp != null) {
      yield r'isssp';
      yield serializers.serialize(
        object.isssp,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.zipCodeP != null) {
      yield r'zipCodeP';
      yield serializers.serialize(
        object.zipCodeP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.salaryP != null) {
      yield r'salaryP';
      yield serializers.serialize(
        object.salaryP,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.hiringDateP != null) {
      yield r'hiringDateP';
      yield serializers.serialize(
        object.hiringDateP,
        specifiedType: const FullType.nullable(DateTime),
      );
    }
    if (object.pictureP != null) {
      yield r'pictureP';
      yield serializers.serialize(
        object.pictureP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.curriculumP != null) {
      yield r'curriculumP';
      yield serializers.serialize(
        object.curriculumP,
        specifiedType: const FullType.nullable(String),
      );
    }
    if (object.latitudeLocationP != null) {
      yield r'latitudeLocationP';
      yield serializers.serialize(
        object.latitudeLocationP,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.longitudeLocationP != null) {
      yield r'longitudeLocationP';
      yield serializers.serialize(
        object.longitudeLocationP,
        specifiedType: const FullType.nullable(double),
      );
    }
    if (object.idPfs1 != null) {
      yield r'idPfs1';
      yield serializers.serialize(
        object.idPfs1,
        specifiedType: const FullType.nullable(int),
      );
    }
    if (object.idDp1 != null) {
      yield r'idDp1';
      yield serializers.serialize(
        object.idDp1,
        specifiedType: const FullType.nullable(int),
      );
    }
    if (object.idWdt1 != null) {
      yield r'idWdt1';
      yield serializers.serialize(
        object.idWdt1,
        specifiedType: const FullType.nullable(int),
      );
    }
    if (object.idDp1Navigation != null) {
      yield r'idDp1Navigation';
      yield serializers.serialize(
        object.idDp1Navigation,
        specifiedType: const FullType(Department),
      );
    }
    if (object.idPfs1Navigation != null) {
      yield r'idPfs1Navigation';
      yield serializers.serialize(
        object.idPfs1Navigation,
        specifiedType: const FullType(Profession),
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
    if (object.projecttemplates != null) {
      yield r'projecttemplates';
      yield serializers.serialize(
        object.projecttemplates,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Projecttemplate)]),
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
    if (object.securityanswerprofessionals != null) {
      yield r'securityanswerprofessionals';
      yield serializers.serialize(
        object.securityanswerprofessionals,
        specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerprofessional)]),
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
    Professional object, {
    FullType specifiedType = FullType.unspecified,
  }) {
    return _serializeProperties(serializers, object, specifiedType: specifiedType).toList();
  }

  void _deserializeProperties(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
    required List<Object?> serializedList,
    required ProfessionalBuilder result,
    required List<Object?> unhandled,
  }) {
    for (var i = 0; i < serializedList.length; i += 2) {
      final key = serializedList[i] as String;
      final value = serializedList[i + 1];
      switch (key) {
        case r'idP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.idP = valueDes;
          break;
        case r'nameP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.nameP = valueDes;
          break;
        case r'dateBirthP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.dateBirthP = valueDes;
          break;
        case r'emailP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.emailP = valueDes;
          break;
        case r'passwordP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.passwordP = valueDes;
          break;
        case r'activeP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.activeP = valueDes;
          break;
        case r'sexP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(bool),
          ) as bool?;
          if (valueDes == null) continue;
          result.sexP = valueDes;
          break;
        case r'duip':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.duip = valueDes;
          break;
        case r'afpp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.afpp = valueDes;
          break;
        case r'isssp':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.isssp = valueDes;
          break;
        case r'zipCodeP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.zipCodeP = valueDes;
          break;
        case r'salaryP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.salaryP = valueDes;
          break;
        case r'hiringDateP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(DateTime),
          ) as DateTime?;
          if (valueDes == null) continue;
          result.hiringDateP = valueDes;
          break;
        case r'pictureP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.pictureP = valueDes;
          break;
        case r'curriculumP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(String),
          ) as String?;
          if (valueDes == null) continue;
          result.curriculumP = valueDes;
          break;
        case r'latitudeLocationP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.latitudeLocationP = valueDes;
          break;
        case r'longitudeLocationP':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(double),
          ) as double?;
          if (valueDes == null) continue;
          result.longitudeLocationP = valueDes;
          break;
        case r'idPfs1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(int),
          ) as int?;
          if (valueDes == null) continue;
          result.idPfs1 = valueDes;
          break;
        case r'idDp1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(int),
          ) as int?;
          if (valueDes == null) continue;
          result.idDp1 = valueDes;
          break;
        case r'idWdt1':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(int),
          ) as int?;
          if (valueDes == null) continue;
          result.idWdt1 = valueDes;
          break;
        case r'idDp1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Department),
          ) as Department;
          result.idDp1Navigation.replace(valueDes);
          break;
        case r'idPfs1Navigation':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType(Profession),
          ) as Profession;
          result.idPfs1Navigation.replace(valueDes);
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
        case r'projecttemplates':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Projecttemplate)]),
          ) as BuiltList<Projecttemplate>?;
          if (valueDes == null) continue;
          result.projecttemplates.replace(valueDes);
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
        case r'securityanswerprofessionals':
          final valueDes = serializers.deserialize(
            value,
            specifiedType: const FullType.nullable(BuiltList, [FullType(Securityanswerprofessional)]),
          ) as BuiltList<Securityanswerprofessional>?;
          if (valueDes == null) continue;
          result.securityanswerprofessionals.replace(valueDes);
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
  Professional deserialize(
    Serializers serializers,
    Object serialized, {
    FullType specifiedType = FullType.unspecified,
  }) {
    final result = ProfessionalBuilder();
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

