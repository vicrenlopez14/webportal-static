import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for TagsApi
void main() {
  final instance = ProfindApi().getTagsApi();

  group(TagsApi, () {
    //Future deleteTag(String id) async
    test('test deleteTag', () async {
      // TODO
    });

    //Future<BuiltList<Tag>> filterTags({ String idTag, String nameTag }) async
    test('test filterTags', () async {
      // TODO
    });

    //Future<Tag> getTag(String id) async
    test('test getTag', () async {
      // TODO
    });

    //Future<BuiltList<Tag>> getTagPaginated({ String limit, String offset }) async
    test('test getTagPaginated', () async {
      // TODO
    });

    //Future<BuiltList<Tag>> getTags() async
    test('test getTags', () async {
      // TODO
    });

    //Future<Tag> postTag({ Tag tag }) async
    test('test postTag', () async {
      // TODO
    });

    //Future putTag(String id, { Tag tag }) async
    test('test putTag', () async {
      // TODO
    });

    //Future<BuiltList<Tag>> searchTagPaginated({ String tagId, String nameTag, String limit, String offset }) async
    test('test searchTagPaginated', () async {
      // TODO
    });

    //Future<BuiltList<Tag>> searchTags({ String tagId, String nameTag }) async
    test('test searchTags', () async {
      // TODO
    });

  });
}
