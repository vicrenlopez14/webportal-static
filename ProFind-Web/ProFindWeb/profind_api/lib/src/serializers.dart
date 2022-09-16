//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

// ignore_for_file: unused_import

import 'package:one_of_serializer/any_of_serializer.dart';
import 'package:one_of_serializer/one_of_serializer.dart';
import 'package:built_collection/built_collection.dart';
import 'package:built_value/json_object.dart';
import 'package:built_value/serializer.dart';
import 'package:built_value/standard_json_plugin.dart';
import 'package:built_value/iso_8601_date_time_serializer.dart';
import 'package:profind_api/src/date_serializer.dart';
import 'package:profind_api/src/model/date.dart';

import 'package:profind_api/src/model/activity.dart';
import 'package:profind_api/src/model/activitycomment.dart';
import 'package:profind_api/src/model/admin.dart';
import 'package:profind_api/src/model/admin_login.dart';
import 'package:profind_api/src/model/changepasswordcode.dart';
import 'package:profind_api/src/model/client.dart';
import 'package:profind_api/src/model/date_only.dart';
import 'package:profind_api/src/model/day_of_week.dart';
import 'package:profind_api/src/model/department.dart';
import 'package:profind_api/src/model/message.dart';
import 'package:profind_api/src/model/notification.dart';
import 'package:profind_api/src/model/profession.dart';
import 'package:profind_api/src/model/professional.dart';
import 'package:profind_api/src/model/project.dart';
import 'package:profind_api/src/model/projectpay.dart';
import 'package:profind_api/src/model/projectpaytemplate.dart';
import 'package:profind_api/src/model/projectstatus.dart';
import 'package:profind_api/src/model/projecttemplate.dart';
import 'package:profind_api/src/model/proposal.dart';
import 'package:profind_api/src/model/proposalnotification.dart';
import 'package:profind_api/src/model/rank.dart';
import 'package:profind_api/src/model/securityansweradmin.dart';
import 'package:profind_api/src/model/securityanswerclient.dart';
import 'package:profind_api/src/model/securityanswerprofessional.dart';
import 'package:profind_api/src/model/securityquestion.dart';
import 'package:profind_api/src/model/supportticket.dart';
import 'package:profind_api/src/model/tag.dart';
import 'package:profind_api/src/model/tagtemplate.dart';

part 'serializers.g.dart';

@SerializersFor([
  Activity,
  Activitycomment,
  Admin,
  AdminLogin,
  Changepasswordcode,
  Client,
  DateOnly,
  DayOfWeek,
  Department,
  Message,
  Notification,
  Profession,
  Professional,
  Project,
  Projectpay,
  Projectpaytemplate,
  Projectstatus,
  Projecttemplate,
  Proposal,
  Proposalnotification,
  Rank,
  Securityansweradmin,
  Securityanswerclient,
  Securityanswerprofessional,
  Securityquestion,
  Supportticket,
  Tag,
  Tagtemplate,
])
Serializers serializers = (_$serializers.toBuilder()
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Message)]),
        () => ListBuilder<Message>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Securityansweradmin)]),
        () => ListBuilder<Securityansweradmin>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Projecttemplate)]),
        () => ListBuilder<Projecttemplate>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Proposal)]),
        () => ListBuilder<Proposal>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Notification)]),
        () => ListBuilder<Notification>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Rank)]),
        () => ListBuilder<Rank>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Securityanswerprofessional)]),
        () => ListBuilder<Securityanswerprofessional>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Activity)]),
        () => ListBuilder<Activity>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Projectpay)]),
        () => ListBuilder<Projectpay>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Tag)]),
        () => ListBuilder<Tag>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Securityanswerclient)]),
        () => ListBuilder<Securityanswerclient>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Client)]),
        () => ListBuilder<Client>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Professional)]),
        () => ListBuilder<Professional>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Supportticket)]),
        () => ListBuilder<Supportticket>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Tagtemplate)]),
        () => ListBuilder<Tagtemplate>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Projectstatus)]),
        () => ListBuilder<Projectstatus>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Securityquestion)]),
        () => ListBuilder<Securityquestion>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Department)]),
        () => ListBuilder<Department>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Admin)]),
        () => ListBuilder<Admin>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Project)]),
        () => ListBuilder<Project>(),
      )
      ..addBuilderFactory(
        const FullType(BuiltList, [FullType(Profession)]),
        () => ListBuilder<Profession>(),
      )
      ..add(const OneOfSerializer())
      ..add(const AnyOfSerializer())
      ..add(const DateSerializer())
      ..add(Iso8601DateTimeSerializer()))
    .build();

Serializers standardSerializers =
    (serializers.toBuilder()..addPlugin(StandardJsonPlugin())).build();
