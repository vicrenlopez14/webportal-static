import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ProfessionsApi
void main() {
  final instance = ProfindApi().getProfessionsApi();

  group(ProfessionsApi, () {
    //Future deleteProfession(int id) async
    test('test deleteProfession', () async {
      // TODO
    });

    //Future<Profession> getProfession(int id) async
    test('test getProfession', () async {
      // TODO
    });

    //Future<BuiltList<Profession>> getProfessions() async
    test('test getProfessions', () async {
      // TODO
    });

    //Future<Profession> postProfession({ Profession profession }) async
    test('test postProfession', () async {
      // TODO
    });

    //Future putProfession(int id, { Profession profession }) async
    test('test putProfession', () async {
      // TODO
    });

  });
}
