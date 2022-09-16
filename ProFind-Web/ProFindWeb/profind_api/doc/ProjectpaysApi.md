# profind_api.api.ProjectpaysApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProjectpay**](ProjectpaysApi.md#deleteprojectpay) | **DELETE** /api/Projectpays/{id} | 
[**getProjectpay**](ProjectpaysApi.md#getprojectpay) | **GET** /api/Projectpays/{id} | 
[**getProjectpays**](ProjectpaysApi.md#getprojectpays) | **GET** /api/Projectpays | 
[**postProjectpay**](ProjectpaysApi.md#postprojectpay) | **POST** /api/Projectpays | 
[**putProjectpay**](ProjectpaysApi.md#putprojectpay) | **PUT** /api/Projectpays/{id} | 


# **deleteProjectpay**
> deleteProjectpay(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectpaysApi();
final String id = id_example; // String | 

try {
    api.deleteProjectpay(id);
} catch on DioError (e) {
    print('Exception when calling ProjectpaysApi->deleteProjectpay: $e\n');
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

# **getProjectpay**
> Projectpay getProjectpay(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectpaysApi();
final String id = id_example; // String | 

try {
    final response = api.getProjectpay(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectpaysApi->getProjectpay: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Projectpay**](Projectpay.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProjectpays**
> BuiltList<Projectpay> getProjectpays()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectpaysApi();

try {
    final response = api.getProjectpays();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectpaysApi->getProjectpays: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Projectpay&gt;**](Projectpay.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProjectpay**
> Projectpay postProjectpay(projectpay)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectpaysApi();
final Projectpay projectpay = ; // Projectpay | 

try {
    final response = api.postProjectpay(projectpay);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectpaysApi->postProjectpay: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectpay** | [**Projectpay**](Projectpay.md)|  | [optional] 

### Return type

[**Projectpay**](Projectpay.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProjectpay**
> putProjectpay(id, projectpay)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectpaysApi();
final String id = id_example; // String | 
final Projectpay projectpay = ; // Projectpay | 

try {
    api.putProjectpay(id, projectpay);
} catch on DioError (e) {
    print('Exception when calling ProjectpaysApi->putProjectpay: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **projectpay** | [**Projectpay**](Projectpay.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

