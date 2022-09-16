# profind_api.api.RanksApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteRank**](RanksApi.md#deleterank) | **DELETE** /api/Ranks/{id} | 
[**filterRanks**](RanksApi.md#filterranks) | **GET** /api/Ranks/filter | 
[**getRank**](RanksApi.md#getrank) | **GET** /api/Ranks/{id} | 
[**getRanks**](RanksApi.md#getranks) | **GET** /api/Ranks | 
[**getRanksPaginated**](RanksApi.md#getrankspaginated) | **GET** /api/Ranks/paginated | 
[**postRank**](RanksApi.md#postrank) | **POST** /api/Ranks | 
[**putRank**](RanksApi.md#putrank) | **PUT** /api/Ranks/{id} | 
[**searchRanks**](RanksApi.md#searchranks) | **GET** /api/Ranks/search | 
[**searchRanksPaginated**](RanksApi.md#searchrankspaginated) | **GET** /api/Ranks/search/paginated | 


# **deleteRank**
> deleteRank(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final int id = 56; // int | 

try {
    api.deleteRank(id);
} catch on DioError (e) {
    print('Exception when calling RanksApi->deleteRank: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filterRanks**
> BuiltList<Rank> filterRanks(nameRanks, idR)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final String nameRanks = nameRanks_example; // String | 
final String idR = idR_example; // String | 

try {
    final response = api.filterRanks(nameRanks, idR);
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->filterRanks: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameRanks** | **String**|  | [optional] 
 **idR** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Rank&gt;**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getRank**
> Rank getRank(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final int id = 56; // int | 

try {
    final response = api.getRank(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->getRank: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Rank**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getRanks**
> BuiltList<Rank> getRanks()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();

try {
    final response = api.getRanks();
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->getRanks: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Rank&gt;**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getRanksPaginated**
> BuiltList<Rank> getRanksPaginated(limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.getRanksPaginated(limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->getRanksPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Rank&gt;**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postRank**
> Rank postRank(rank)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final Rank rank = ; // Rank | 

try {
    final response = api.postRank(rank);
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->postRank: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rank** | [**Rank**](Rank.md)|  | [optional] 

### Return type

[**Rank**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putRank**
> putRank(id, rank)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final int id = 56; // int | 
final Rank rank = ; // Rank | 

try {
    api.putRank(id, rank);
} catch on DioError (e) {
    print('Exception when calling RanksApi->putRank: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **rank** | [**Rank**](Rank.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchRanks**
> BuiltList<Rank> searchRanks(nameRanks)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final String nameRanks = nameRanks_example; // String | 

try {
    final response = api.searchRanks(nameRanks);
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->searchRanks: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameRanks** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Rank&gt;**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchRanksPaginated**
> BuiltList<Rank> searchRanksPaginated(nameRanks, limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getRanksApi();
final String nameRanks = nameRanks_example; // String | 
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.searchRanksPaginated(nameRanks, limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling RanksApi->searchRanksPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameRanks** | **String**|  | [optional] 
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Rank&gt;**](Rank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

