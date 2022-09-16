import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for SupportticketsApi
void main() {
  final instance = ProfindApi().getSupportticketsApi();

  group(SupportticketsApi, () {
    //Future deleteSupportticket(String id) async
    test('test deleteSupportticket', () async {
      // TODO
    });

    //Future<Supportticket> getSupportticket(String id) async
    test('test getSupportticket', () async {
      // TODO
    });

    //Future<BuiltList<Supportticket>> getSupporttickets() async
    test('test getSupporttickets', () async {
      // TODO
    });

    //Future<Supportticket> postSupportticket({ Supportticket supportticket }) async
    test('test postSupportticket', () async {
      // TODO
    });

    //Future putSupportticket(String id, { Supportticket supportticket }) async
    test('test putSupportticket', () async {
      // TODO
    });

  });
}
