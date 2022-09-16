import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for DepartmentsApi
void main() {
  final instance = ProfindApi().getDepartmentsApi();

  group(DepartmentsApi, () {
    //Future deleteDepartment(int id) async
    test('test deleteDepartment', () async {
      // TODO
    });

    //Future<Department> getDepartment(int id) async
    test('test getDepartment', () async {
      // TODO
    });

    //Future<BuiltList<Department>> getDepartments() async
    test('test getDepartments', () async {
      // TODO
    });

    //Future<Department> postDepartment({ Department department }) async
    test('test postDepartment', () async {
      // TODO
    });

    //Future putDepartment(int id, { Department department }) async
    test('test putDepartment', () async {
      // TODO
    });

  });
}
