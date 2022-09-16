# profind_api.api.ProposalsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProposal**](ProposalsApi.md#deleteproposal) | **DELETE** /api/Proposals/{id} | 
[**filterProposals**](ProposalsApi.md#filterproposals) | **GET** /api/Proposals/filter | 
[**getProposal**](ProposalsApi.md#getproposal) | **GET** /api/Proposals/{id} | 
[**getProposals**](ProposalsApi.md#getproposals) | **GET** /api/Proposals | 
[**getProposalsPaginated**](ProposalsApi.md#getproposalspaginated) | **GET** /api/Proposals/paginated | 
[**postProposal**](ProposalsApi.md#postproposal) | **POST** /api/Proposals | 
[**putProposal**](ProposalsApi.md#putproposal) | **PUT** /api/Proposals/{id} | 
[**searchProposals**](ProposalsApi.md#searchproposals) | **GET** /api/Proposals/search | 
[**searchProposalsPaginated**](ProposalsApi.md#searchproposalspaginated) | **GET** /api/Proposals/search/paginated | 


# **deleteProposal**
> deleteProposal(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final String id = id_example; // String | 

try {
    api.deleteProposal(id);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->deleteProposal: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filterProposals**
> BuiltList<Proposal> filterProposals(suggestedStart, suggestedStarRel, suggestedEnd, suggestedEndRel, idProfessional, idClient)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final DateTime suggestedStart = 2013-10-20T19:20:30+01:00; // DateTime | 
final String suggestedStarRel = suggestedStarRel_example; // String | 
final DateTime suggestedEnd = 2013-10-20T19:20:30+01:00; // DateTime | 
final String suggestedEndRel = suggestedEndRel_example; // String | 
final String idProfessional = idProfessional_example; // String | 
final String idClient = idClient_example; // String | 

try {
    final response = api.filterProposals(suggestedStart, suggestedStarRel, suggestedEnd, suggestedEndRel, idProfessional, idClient);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->filterProposals: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **suggestedStart** | **DateTime**|  | [optional] 
 **suggestedStarRel** | **String**|  | [optional] 
 **suggestedEnd** | **DateTime**|  | [optional] 
 **suggestedEndRel** | **String**|  | [optional] 
 **idProfessional** | **String**|  | [optional] 
 **idClient** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Proposal&gt;**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProposal**
> Proposal getProposal(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final String id = id_example; // String | 

try {
    final response = api.getProposal(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->getProposal: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Proposal**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProposals**
> BuiltList<Proposal> getProposals()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();

try {
    final response = api.getProposals();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->getProposals: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Proposal&gt;**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProposalsPaginated**
> BuiltList<Proposal> getProposalsPaginated(limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.getProposalsPaginated(limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->getProposalsPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Proposal&gt;**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProposal**
> Proposal postProposal(proposal)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final Proposal proposal = ; // Proposal | 

try {
    final response = api.postProposal(proposal);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->postProposal: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **proposal** | [**Proposal**](Proposal.md)|  | [optional] 

### Return type

[**Proposal**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProposal**
> putProposal(id, proposal)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final String id = id_example; // String | 
final Proposal proposal = ; // Proposal | 

try {
    api.putProposal(id, proposal);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->putProposal: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **proposal** | [**Proposal**](Proposal.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchProposals**
> BuiltList<Proposal> searchProposals(proposalsId, titleProposals)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final String proposalsId = proposalsId_example; // String | 
final String titleProposals = titleProposals_example; // String | 

try {
    final response = api.searchProposals(proposalsId, titleProposals);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->searchProposals: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **proposalsId** | **String**|  | [optional] 
 **titleProposals** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Proposal&gt;**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchProposalsPaginated**
> BuiltList<Proposal> searchProposalsPaginated(proposalsId, titleProposals, limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProposalsApi();
final String proposalsId = proposalsId_example; // String | 
final String titleProposals = titleProposals_example; // String | 
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.searchProposalsPaginated(proposalsId, titleProposals, limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProposalsApi->searchProposalsPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **proposalsId** | **String**|  | [optional] 
 **titleProposals** | **String**|  | [optional] 
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Proposal&gt;**](Proposal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

