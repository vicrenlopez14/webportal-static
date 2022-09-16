//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//

import 'package:dio/dio.dart';
import 'package:built_value/serializer.dart';
import 'package:profind_api/src/serializers.dart';
import 'package:profind_api/src/auth/api_key_auth.dart';
import 'package:profind_api/src/auth/basic_auth.dart';
import 'package:profind_api/src/auth/bearer_auth.dart';
import 'package:profind_api/src/auth/oauth.dart';
import 'package:profind_api/src/api/activities_api.dart';
import 'package:profind_api/src/api/admins_api.dart';
import 'package:profind_api/src/api/clients_api.dart';
import 'package:profind_api/src/api/departments_api.dart';
import 'package:profind_api/src/api/login_admin_api.dart';
import 'package:profind_api/src/api/messages_api.dart';
import 'package:profind_api/src/api/notifications_api.dart';
import 'package:profind_api/src/api/professionals_api.dart';
import 'package:profind_api/src/api/professions_api.dart';
import 'package:profind_api/src/api/projectpays_api.dart';
import 'package:profind_api/src/api/projects_api.dart';
import 'package:profind_api/src/api/projectstatus_api.dart';
import 'package:profind_api/src/api/projecttemplates_api.dart';
import 'package:profind_api/src/api/proposals_api.dart';
import 'package:profind_api/src/api/ranks_api.dart';
import 'package:profind_api/src/api/securityansweradmins_api.dart';
import 'package:profind_api/src/api/securityanswerclients_api.dart';
import 'package:profind_api/src/api/securityanswerprofessionals_api.dart';
import 'package:profind_api/src/api/securityquestions_api.dart';
import 'package:profind_api/src/api/supporttickets_api.dart';
import 'package:profind_api/src/api/tags_api.dart';
import 'package:profind_api/src/api/tagtemplates_api.dart';

class ProfindApi {
  static const String basePath = r'https://localhost:7073';

  final Dio dio;
  final Serializers serializers;

  ProfindApi({
    Dio? dio,
    Serializers? serializers,
    String? basePathOverride,
    List<Interceptor>? interceptors,
  })  : this.serializers = serializers ?? standardSerializers,
        this.dio = dio ??
            Dio(BaseOptions(
              baseUrl: basePathOverride ?? basePath,
              connectTimeout: 5000,
              receiveTimeout: 3000,
            )) {
    if (interceptors == null) {
      this.dio.interceptors.addAll([
        OAuthInterceptor(),
        BasicAuthInterceptor(),
        BearerAuthInterceptor(),
        ApiKeyAuthInterceptor(),
      ]);
    } else {
      this.dio.interceptors.addAll(interceptors);
    }
  }

  void setOAuthToken(String name, String token) {
    if (this.dio.interceptors.any((i) => i is OAuthInterceptor)) {
      (this.dio.interceptors.firstWhere((i) => i is OAuthInterceptor) as OAuthInterceptor).tokens[name] = token;
    }
  }

  void setBearerAuth(String name, String token) {
    if (this.dio.interceptors.any((i) => i is BearerAuthInterceptor)) {
      (this.dio.interceptors.firstWhere((i) => i is BearerAuthInterceptor) as BearerAuthInterceptor).tokens[name] = token;
    }
  }

  void setBasicAuth(String name, String username, String password) {
    if (this.dio.interceptors.any((i) => i is BasicAuthInterceptor)) {
      (this.dio.interceptors.firstWhere((i) => i is BasicAuthInterceptor) as BasicAuthInterceptor).authInfo[name] = BasicAuthInfo(username, password);
    }
  }

  void setApiKey(String name, String apiKey) {
    if (this.dio.interceptors.any((i) => i is ApiKeyAuthInterceptor)) {
      (this.dio.interceptors.firstWhere((element) => element is ApiKeyAuthInterceptor) as ApiKeyAuthInterceptor).apiKeys[name] = apiKey;
    }
  }

  /// Get ActivitiesApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ActivitiesApi getActivitiesApi() {
    return ActivitiesApi(dio, serializers);
  }

  /// Get AdminsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  AdminsApi getAdminsApi() {
    return AdminsApi(dio, serializers);
  }

  /// Get ClientsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ClientsApi getClientsApi() {
    return ClientsApi(dio, serializers);
  }

  /// Get DepartmentsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  DepartmentsApi getDepartmentsApi() {
    return DepartmentsApi(dio, serializers);
  }

  /// Get LoginAdminApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  LoginAdminApi getLoginAdminApi() {
    return LoginAdminApi(dio, serializers);
  }

  /// Get MessagesApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  MessagesApi getMessagesApi() {
    return MessagesApi(dio, serializers);
  }

  /// Get NotificationsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  NotificationsApi getNotificationsApi() {
    return NotificationsApi(dio, serializers);
  }

  /// Get ProfessionalsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProfessionalsApi getProfessionalsApi() {
    return ProfessionalsApi(dio, serializers);
  }

  /// Get ProfessionsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProfessionsApi getProfessionsApi() {
    return ProfessionsApi(dio, serializers);
  }

  /// Get ProjectpaysApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProjectpaysApi getProjectpaysApi() {
    return ProjectpaysApi(dio, serializers);
  }

  /// Get ProjectsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProjectsApi getProjectsApi() {
    return ProjectsApi(dio, serializers);
  }

  /// Get ProjectstatusApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProjectstatusApi getProjectstatusApi() {
    return ProjectstatusApi(dio, serializers);
  }

  /// Get ProjecttemplatesApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProjecttemplatesApi getProjecttemplatesApi() {
    return ProjecttemplatesApi(dio, serializers);
  }

  /// Get ProposalsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  ProposalsApi getProposalsApi() {
    return ProposalsApi(dio, serializers);
  }

  /// Get RanksApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  RanksApi getRanksApi() {
    return RanksApi(dio, serializers);
  }

  /// Get SecurityansweradminsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  SecurityansweradminsApi getSecurityansweradminsApi() {
    return SecurityansweradminsApi(dio, serializers);
  }

  /// Get SecurityanswerclientsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  SecurityanswerclientsApi getSecurityanswerclientsApi() {
    return SecurityanswerclientsApi(dio, serializers);
  }

  /// Get SecurityanswerprofessionalsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  SecurityanswerprofessionalsApi getSecurityanswerprofessionalsApi() {
    return SecurityanswerprofessionalsApi(dio, serializers);
  }

  /// Get SecurityquestionsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  SecurityquestionsApi getSecurityquestionsApi() {
    return SecurityquestionsApi(dio, serializers);
  }

  /// Get SupportticketsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  SupportticketsApi getSupportticketsApi() {
    return SupportticketsApi(dio, serializers);
  }

  /// Get TagsApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  TagsApi getTagsApi() {
    return TagsApi(dio, serializers);
  }

  /// Get TagtemplatesApi instance, base route and serializer can be overridden by a given but be careful,
  /// by doing that all interceptors will not be executed
  TagtemplatesApi getTagtemplatesApi() {
    return TagtemplatesApi(dio, serializers);
  }
}
