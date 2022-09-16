import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ProjectsApi
void main() {
  final instance = ProfindApi().getProjectsApi();

  group(ProjectsApi, () {
    //Future deleteProject(String id) async
    test('test deleteProject', () async {
      // TODO
    });

    //Future<Project> getProject(String id) async
    test('test getProject', () async {
      // TODO
    });

    //Future<BuiltList<Project>> getProjects() async
    test('test getProjects', () async {
      // TODO
    });

    //Future<Project> postProject({ Project project }) async
    test('test postProject', () async {
      // TODO
    });

    //Future putProject(String id, { Project project }) async
    test('test putProject', () async {
      // TODO
    });

  });
}
