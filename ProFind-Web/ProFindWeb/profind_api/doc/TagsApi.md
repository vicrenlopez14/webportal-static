# profind_api.api.TagsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteTag**](TagsApi.md#deletetag) | **DELETE** /api/Tags/{id} | 
[**filterTags**](TagsApi.md#filtertags) | **GET** /api/Tags/filter | 
[**getTag**](TagsApi.md#gettag) | **GET** /api/Tags/{id} | 
[**getTagPaginated**](TagsApi.md#gettagpaginated) | **GET** /api/Tags/paginated | 
[**getTags**](TagsApi.md#gettags) | **GET** /api/Tags | 
[**postTag**](TagsApi.md#posttag) | **POST** /api/Tags | 
[**putTag**](TagsApi.md#puttag) | **PUT** /api/Tags/{id} | 
[**searchTagPaginated**](TagsApi.md#searchtagpaginated) | **GET** /api/Tags/search/paginated | 
[**searchTags**](TagsApi.md#searchtags) | **GET** /api/Tags/search | 


# **deleteTag**
> deleteTag(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String id = id_example; // String | 

try {
    api.deleteTag(id);
} catch on DioError (e) {
    print('Exception when calling TagsApi->deleteTag: $e\n');
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

# **filterTags**
> BuiltList<Tag> filterTags(idTag, nameTag)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String idTag = idTag_example; // String | 
final String nameTag = nameTag_example; // String | 

try {
    final response = api.filterTags(idTag, nameTag);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->filterTags: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idTag** | **String**|  | [optional] 
 **nameTag** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Tag&gt;**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getTag**
> Tag getTag(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String id = id_example; // String | 

try {
    final response = api.getTag(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->getTag: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getTagPaginated**
> BuiltList<Tag> getTagPaginated(limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.getTagPaginated(limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->getTagPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Tag&gt;**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getTags**
> BuiltList<Tag> getTags()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();

try {
    final response = api.getTags();
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->getTags: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Tag&gt;**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postTag**
> Tag postTag(tag)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final Tag tag = ; // Tag | 

try {
    final response = api.postTag(tag);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->postTag: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | [**Tag**](Tag.md)|  | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putTag**
> putTag(id, tag)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String id = id_example; // String | 
final Tag tag = ; // Tag | 

try {
    api.putTag(id, tag);
} catch on DioError (e) {
    print('Exception when calling TagsApi->putTag: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **tag** | [**Tag**](Tag.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchTagPaginated**
> BuiltList<Tag> searchTagPaginated(tagId, nameTag, limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String tagId = tagId_example; // String | 
final String nameTag = nameTag_example; // String | 
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.searchTagPaginated(tagId, nameTag, limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->searchTagPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagId** | **String**|  | [optional] 
 **nameTag** | **String**|  | [optional] 
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Tag&gt;**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchTags**
> BuiltList<Tag> searchTags(tagId, nameTag)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagsApi();
final String tagId = tagId_example; // String | 
final String nameTag = nameTag_example; // String | 

try {
    final response = api.searchTags(tagId, nameTag);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagsApi->searchTags: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagId** | **String**|  | [optional] 
 **nameTag** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Tag&gt;**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

