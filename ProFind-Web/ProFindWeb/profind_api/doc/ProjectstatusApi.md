# profind_api.api.ProjectstatusApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProjectstatus**](ProjectstatusApi.md#deleteprojectstatus) | **DELETE** /api/Projectstatus/{id} | 
[**getProjectstatus**](ProjectstatusApi.md#getprojectstatus) | **GET** /api/Projectstatus/{id} | 
[**getProjectstatuses**](ProjectstatusApi.md#getprojectstatuses) | **GET** /api/Projectstatus | 
[**postProjectstatus**](ProjectstatusApi.md#postprojectstatus) | **POST** /api/Projectstatus | 
[**putProjectstatus**](ProjectstatusApi.md#putprojectstatus) | **PUT** /api/Projectstatus/{id} | 


# **deleteProjectstatus**
> deleteProjectstatus(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectstatusApi();
final int id = 56; // int | 

try {
    api.deleteProjectstatus(id);
} catch on DioError (e) {
    print('Exception when calling ProjectstatusApi->deleteProjectstatus: $e\n');
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

# **getProjectstatus**
> Projectstatus getProjectstatus(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectstatusApi();
final int id = 56; // int | 

try {
    final response = api.getProjectstatus(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectstatusApi->getProjectstatus: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Projectstatus**](Projectstatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProjectstatuses**
> BuiltList<Projectstatus> getProjectstatuses()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectstatusApi();

try {
    final response = api.getProjectstatuses();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectstatusApi->getProjectstatuses: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Projectstatus&gt;**](Projectstatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProjectstatus**
> Projectstatus postProjectstatus(projectstatus)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectstatusApi();
final Projectstatus projectstatus = ; // Projectstatus | 

try {
    final response = api.postProjectstatus(projectstatus);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectstatusApi->postProjectstatus: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectstatus** | [**Projectstatus**](Projectstatus.md)|  | [optional] 

### Return type

[**Projectstatus**](Projectstatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProjectstatus**
> putProjectstatus(id, projectstatus)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectstatusApi();
final String id = id_example; // String | 
final Projectstatus projectstatus = ; // Projectstatus | 

try {
    api.putProjectstatus(id, projectstatus);
} catch on DioError (e) {
    print('Exception when calling ProjectstatusApi->putProjectstatus: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **projectstatus** | [**Projectstatus**](Projectstatus.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

