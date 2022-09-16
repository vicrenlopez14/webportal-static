import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for RanksApi
void main() {
  final instance = ProfindApi().getRanksApi();

  group(RanksApi, () {
    //Future deleteRank(int id) async
    test('test deleteRank', () async {
      // TODO
    });

    //Future<BuiltList<Rank>> filterRanks({ String nameRanks, String idR }) async
    test('test filterRanks', () async {
      // TODO
    });

    //Future<Rank> getRank(int id) async
    test('test getRank', () async {
      // TODO
    });

    //Future<BuiltList<Rank>> getRanks() async
    test('test getRanks', () async {
      // TODO
    });

    //Future<BuiltList<Rank>> getRanksPaginated({ String limit, String offset }) async
    test('test getRanksPaginated', () async {
      // TODO
    });

    //Future<Rank> postRank({ Rank rank }) async
    test('test postRank', () async {
      // TODO
    });

    //Future putRank(int id, { Rank rank }) async
    test('test putRank', () async {
      // TODO
    });

    //Future<BuiltList<Rank>> searchRanks({ String nameRanks }) async
    test('test searchRanks', () async {
      // TODO
    });

    //Future<BuiltList<Rank>> searchRanksPaginated({ String nameRanks, String limit, String offset }) async
    test('test searchRanksPaginated', () async {
      // TODO
    });

  });
}
