import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for MessagesApi
void main() {
  final instance = ProfindApi().getMessagesApi();

  group(MessagesApi, () {
    //Future deleteMessage(String id) async
    test('test deleteMessage', () async {
      // TODO
    });

    //Future<Message> getMessage(String id) async
    test('test getMessage', () async {
      // TODO
    });

    //Future<BuiltList<Message>> getMessages() async
    test('test getMessages', () async {
      // TODO
    });

    //Future<Message> postMessage({ Message message }) async
    test('test postMessage', () async {
      // TODO
    });

    //Future putMessage(String id, { Message message }) async
    test('test putMessage', () async {
      // TODO
    });

  });
}
