import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ActivitiesApi
void main() {
  final instance = ProfindApi().getActivitiesApi();

  group(ActivitiesApi, () {
    //Future deleteActivity(String id) async
    test('test deleteActivity', () async {
      // TODO
    });

    //Future<BuiltList<Activity>> filterActivities({ DateTime expectedBegin, String expectedBeginRel, DateTime expectedEnd, String expectedEndRel, String idProject, String idTag }) async
    test('test filterActivities', () async {
      // TODO
    });

    //Future<BuiltList<Activity>> getActivities() async
    test('test getActivities', () async {
      // TODO
    });

    //Future<BuiltList<Activity>> getActivitiesPaginated({ String limit, String offset }) async
    test('test getActivitiesPaginated', () async {
      // TODO
    });

    //Future<Activity> getActivity(String id) async
    test('test getActivity', () async {
      // TODO
    });

    //Future<Activity> postActivity({ Activity activity }) async
    test('test postActivity', () async {
      // TODO
    });

    //Future putActivity(String id, { Activity activity }) async
    test('test putActivity', () async {
      // TODO
    });

    //Future<BuiltList<Activity>> searchActivities({ String projectId, String title }) async
    test('test searchActivities', () async {
      // TODO
    });

    //Future<BuiltList<Activity>> searchActivitiesPaginated({ String projectId, String title, String limit, String offset }) async
    test('test searchActivitiesPaginated', () async {
      // TODO
    });

  });
}
