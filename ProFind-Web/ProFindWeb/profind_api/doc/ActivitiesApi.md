# profind_api.api.ActivitiesApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteActivity**](ActivitiesApi.md#deleteactivity) | **DELETE** /api/Activities/{id} | 
[**filterActivities**](ActivitiesApi.md#filteractivities) | **GET** /api/Activities/filter | 
[**getActivities**](ActivitiesApi.md#getactivities) | **GET** /api/Activities | 
[**getActivitiesPaginated**](ActivitiesApi.md#getactivitiespaginated) | **GET** /api/Activities/paginated | 
[**getActivity**](ActivitiesApi.md#getactivity) | **GET** /api/Activities/{id} | 
[**postActivity**](ActivitiesApi.md#postactivity) | **POST** /api/Activities | 
[**putActivity**](ActivitiesApi.md#putactivity) | **PUT** /api/Activities/{id} | 
[**searchActivities**](ActivitiesApi.md#searchactivities) | **GET** /api/Activities/search | 
[**searchActivitiesPaginated**](ActivitiesApi.md#searchactivitiespaginated) | **GET** /api/Activities/search/paginated | 


# **deleteActivity**
> deleteActivity(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final String id = id_example; // String | 

try {
    api.deleteActivity(id);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->deleteActivity: $e\n');
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

# **filterActivities**
> BuiltList<Activity> filterActivities(expectedBegin, expectedBeginRel, expectedEnd, expectedEndRel, idProject, idTag)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final DateTime expectedBegin = 2013-10-20T19:20:30+01:00; // DateTime | 
final String expectedBeginRel = expectedBeginRel_example; // String | 
final DateTime expectedEnd = 2013-10-20T19:20:30+01:00; // DateTime | 
final String expectedEndRel = expectedEndRel_example; // String | 
final String idProject = idProject_example; // String | 
final String idTag = idTag_example; // String | 

try {
    final response = api.filterActivities(expectedBegin, expectedBeginRel, expectedEnd, expectedEndRel, idProject, idTag);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->filterActivities: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expectedBegin** | **DateTime**|  | [optional] 
 **expectedBeginRel** | **String**|  | [optional] 
 **expectedEnd** | **DateTime**|  | [optional] 
 **expectedEndRel** | **String**|  | [optional] 
 **idProject** | **String**|  | [optional] 
 **idTag** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Activity&gt;**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getActivities**
> BuiltList<Activity> getActivities()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();

try {
    final response = api.getActivities();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->getActivities: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Activity&gt;**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getActivitiesPaginated**
> BuiltList<Activity> getActivitiesPaginated(limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.getActivitiesPaginated(limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->getActivitiesPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Activity&gt;**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getActivity**
> Activity getActivity(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final String id = id_example; // String | 

try {
    final response = api.getActivity(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->getActivity: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postActivity**
> Activity postActivity(activity)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final Activity activity = ; // Activity | 

try {
    final response = api.postActivity(activity);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->postActivity: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activity** | [**Activity**](Activity.md)|  | [optional] 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putActivity**
> putActivity(id, activity)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final String id = id_example; // String | 
final Activity activity = ; // Activity | 

try {
    api.putActivity(id, activity);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->putActivity: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **activity** | [**Activity**](Activity.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchActivities**
> BuiltList<Activity> searchActivities(projectId, title)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final String projectId = projectId_example; // String | 
final String title = title_example; // String | 

try {
    final response = api.searchActivities(projectId, title);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->searchActivities: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **String**|  | [optional] 
 **title** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Activity&gt;**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchActivitiesPaginated**
> BuiltList<Activity> searchActivitiesPaginated(projectId, title, limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getActivitiesApi();
final String projectId = projectId_example; // String | 
final String title = title_example; // String | 
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.searchActivitiesPaginated(projectId, title, limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ActivitiesApi->searchActivitiesPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **String**|  | [optional] 
 **title** | **String**|  | [optional] 
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Activity&gt;**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

