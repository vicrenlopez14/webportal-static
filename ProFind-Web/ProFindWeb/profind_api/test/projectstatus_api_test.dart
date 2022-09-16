import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ProjectstatusApi
void main() {
  final instance = ProfindApi().getProjectstatusApi();

  group(ProjectstatusApi, () {
    //Future deleteProjectstatus(int id) async
    test('test deleteProjectstatus', () async {
      // TODO
    });

    //Future<Projectstatus> getProjectstatus(int id) async
    test('test getProjectstatus', () async {
      // TODO
    });

    //Future<BuiltList<Projectstatus>> getProjectstatuses() async
    test('test getProjectstatuses', () async {
      // TODO
    });

    //Future<Projectstatus> postProjectstatus({ Projectstatus projectstatus }) async
    test('test postProjectstatus', () async {
      // TODO
    });

    //Future putProjectstatus(String id, { Projectstatus projectstatus }) async
    test('test putProjectstatus', () async {
      // TODO
    });

  });
}
