# profind_api.api.SecurityansweradminsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteSecurityansweradmin**](SecurityansweradminsApi.md#deletesecurityansweradmin) | **DELETE** /api/Securityansweradmins/{id} | 
[**getSecurityansweradmin**](SecurityansweradminsApi.md#getsecurityansweradmin) | **GET** /api/Securityansweradmins/{id} | 
[**getSecurityansweradmins**](SecurityansweradminsApi.md#getsecurityansweradmins) | **GET** /api/Securityansweradmins | 
[**postSecurityansweradmin**](SecurityansweradminsApi.md#postsecurityansweradmin) | **POST** /api/Securityansweradmins | 
[**putSecurityansweradmin**](SecurityansweradminsApi.md#putsecurityansweradmin) | **PUT** /api/Securityansweradmins/{id} | 


# **deleteSecurityansweradmin**
> deleteSecurityansweradmin(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityansweradminsApi();
final String id = id_example; // String | 

try {
    api.deleteSecurityansweradmin(id);
} catch on DioError (e) {
    print('Exception when calling SecurityansweradminsApi->deleteSecurityansweradmin: $e\n');
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

# **getSecurityansweradmin**
> Securityansweradmin getSecurityansweradmin(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityansweradminsApi();
final String id = id_example; // String | 

try {
    final response = api.getSecurityansweradmin(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityansweradminsApi->getSecurityansweradmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Securityansweradmin**](Securityansweradmin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getSecurityansweradmins**
> BuiltList<Securityansweradmin> getSecurityansweradmins()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityansweradminsApi();

try {
    final response = api.getSecurityansweradmins();
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityansweradminsApi->getSecurityansweradmins: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Securityansweradmin&gt;**](Securityansweradmin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postSecurityansweradmin**
> Securityansweradmin postSecurityansweradmin(securityansweradmin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityansweradminsApi();
final Securityansweradmin securityansweradmin = ; // Securityansweradmin | 

try {
    final response = api.postSecurityansweradmin(securityansweradmin);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityansweradminsApi->postSecurityansweradmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **securityansweradmin** | [**Securityansweradmin**](Securityansweradmin.md)|  | [optional] 

### Return type

[**Securityansweradmin**](Securityansweradmin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putSecurityansweradmin**
> putSecurityansweradmin(id, securityansweradmin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityansweradminsApi();
final String id = id_example; // String | 
final Securityansweradmin securityansweradmin = ; // Securityansweradmin | 

try {
    api.putSecurityansweradmin(id, securityansweradmin);
} catch on DioError (e) {
    print('Exception when calling SecurityansweradminsApi->putSecurityansweradmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **securityansweradmin** | [**Securityansweradmin**](Securityansweradmin.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

