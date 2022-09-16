import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ClientsApi
void main() {
  final instance = ProfindApi().getClientsApi();

  group(ClientsApi, () {
    //Future deleteClient(String id) async
    test('test deleteClient', () async {
      // TODO
    });

    //Future<BuiltList<Client>> filterClients({ String name, String name1, String idclien }) async
    test('test filterClients', () async {
      // TODO
    });

    //Future<Client> getClient(String id) async
    test('test getClient', () async {
      // TODO
    });

    //Future<BuiltList<Client>> getClientPaginated({ String limit, String offset }) async
    test('test getClientPaginated', () async {
      // TODO
    });

    //Future<BuiltList<Client>> getClients() async
    test('test getClients', () async {
      // TODO
    });

    //Future loginClient({ Client client }) async
    test('test loginClient', () async {
      // TODO
    });

    //Future<Client> postClient({ Client client }) async
    test('test postClient', () async {
      // TODO
    });

    //Future putClient(String id, { Client client }) async
    test('test putClient', () async {
      // TODO
    });

    //Future registerClient({ Client client }) async
    test('test registerClient', () async {
      // TODO
    });

    //Future<BuiltList<Client>> searchCliens({ String idC, String name }) async
    test('test searchCliens', () async {
      // TODO
    });

    //Future<BuiltList<Client>> searchClient({ String idC, String name, String limit, String offset }) async
    test('test searchClient', () async {
      // TODO
    });

  });
}
