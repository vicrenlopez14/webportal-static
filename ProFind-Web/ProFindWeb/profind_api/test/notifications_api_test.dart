import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for NotificationsApi
void main() {
  final instance = ProfindApi().getNotificationsApi();

  group(NotificationsApi, () {
    //Future deleteNotification(String id) async
    test('test deleteNotification', () async {
      // TODO
    });

    //Future<Notification> getNotification(String id) async
    test('test getNotification', () async {
      // TODO
    });

    //Future<BuiltList<Notification>> getNotifications() async
    test('test getNotifications', () async {
      // TODO
    });

    //Future<Notification> postNotification({ Notification notification }) async
    test('test postNotification', () async {
      // TODO
    });

    //Future putNotification(String id, { Notification notification }) async
    test('test putNotification', () async {
      // TODO
    });

  });
}
