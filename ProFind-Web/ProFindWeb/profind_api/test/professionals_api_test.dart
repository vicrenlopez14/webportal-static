import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ProfessionalsApi
void main() {
  final instance = ProfindApi().getProfessionalsApi();

  group(ProfessionalsApi, () {
    //Future deleteProfessional(String id) async
    test('test deleteProfessional', () async {
      // TODO
    });

    //Future<Professional> getProfessional(String id) async
    test('test getProfessional', () async {
      // TODO
    });

    //Future<BuiltList<Professional>> getProfessionals() async
    test('test getProfessionals', () async {
      // TODO
    });

    //Future loginProfessional({ Professional professional }) async
    test('test loginProfessional', () async {
      // TODO
    });

    //Future<Professional> postProfessional({ Professional professional }) async
    test('test postProfessional', () async {
      // TODO
    });

    //Future putProfessional(String id, { Professional professional }) async
    test('test putProfessional', () async {
      // TODO
    });

    //Future registerProfessional({ Professional professional }) async
    test('test registerProfessional', () async {
      // TODO
    });

  });
}
