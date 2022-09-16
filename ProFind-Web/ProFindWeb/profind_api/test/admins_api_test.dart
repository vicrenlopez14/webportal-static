import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for AdminsApi
void main() {
  final instance = ProfindApi().getAdminsApi();

  group(AdminsApi, () {
    //Future deleteAdmin(String id) async
    test('test deleteAdmin', () async {
      // TODO
    });

    //Future<BuiltList<Admin>> filterAdmins({ String name, String name1, String idAdmin }) async
    test('test filterAdmins', () async {
      // TODO
    });

    //Future<Admin> getAdmin(String id) async
    test('test getAdmin', () async {
      // TODO
    });

    //Future<BuiltList<Admin>> getAdmins() async
    test('test getAdmins', () async {
      // TODO
    });

    //Future<BuiltList<Admin>> getAdminsPaginated({ String limit, String offset }) async
    test('test getAdminsPaginated', () async {
      // TODO
    });

    //Future loginAdmin({ Admin admin }) async
    test('test loginAdmin', () async {
      // TODO
    });

    //Future<Admin> postAdmin({ Admin admin }) async
    test('test postAdmin', () async {
      // TODO
    });

    //Future putAdmin(String id, { Admin admin }) async
    test('test putAdmin', () async {
      // TODO
    });

    //Future registerAdmin({ Admin admin }) async
    test('test registerAdmin', () async {
      // TODO
    });

    //Future<BuiltList<Admin>> searchAdmins({ String idA, String name }) async
    test('test searchAdmins', () async {
      // TODO
    });

    //Future<BuiltList<Admin>> searchAdminsPaginated({ String idA, String name, String limit, String offset }) async
    test('test searchAdminsPaginated', () async {
      // TODO
    });

    //Future sendRecoveryEmail({ String email }) async
    test('test sendRecoveryEmail', () async {
      // TODO
    });

    //Future verifyRecoveryCode({ String code }) async
    test('test verifyRecoveryCode', () async {
      // TODO
    });

  });
}
