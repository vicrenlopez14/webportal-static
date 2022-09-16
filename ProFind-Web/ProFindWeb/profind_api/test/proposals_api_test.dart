import 'package:test/test.dart';
import 'package:profind_api/profind_api.dart';


/// tests for ProposalsApi
void main() {
  final instance = ProfindApi().getProposalsApi();

  group(ProposalsApi, () {
    //Future deleteProposal(String id) async
    test('test deleteProposal', () async {
      // TODO
    });

    //Future<BuiltList<Proposal>> filterProposals({ DateTime suggestedStart, String suggestedStarRel, DateTime suggestedEnd, String suggestedEndRel, String idProfessional, String idClient }) async
    test('test filterProposals', () async {
      // TODO
    });

    //Future<Proposal> getProposal(String id) async
    test('test getProposal', () async {
      // TODO
    });

    //Future<BuiltList<Proposal>> getProposals() async
    test('test getProposals', () async {
      // TODO
    });

    //Future<BuiltList<Proposal>> getProposalsPaginated({ String limit, String offset }) async
    test('test getProposalsPaginated', () async {
      // TODO
    });

    //Future<Proposal> postProposal({ Proposal proposal }) async
    test('test postProposal', () async {
      // TODO
    });

    //Future putProposal(String id, { Proposal proposal }) async
    test('test putProposal', () async {
      // TODO
    });

    //Future<BuiltList<Proposal>> searchProposals({ String proposalsId, String titleProposals }) async
    test('test searchProposals', () async {
      // TODO
    });

    //Future<BuiltList<Proposal>> searchProposalsPaginated({ String proposalsId, String titleProposals, String limit, String offset }) async
    test('test searchProposalsPaginated', () async {
      // TODO
    });

  });
}
