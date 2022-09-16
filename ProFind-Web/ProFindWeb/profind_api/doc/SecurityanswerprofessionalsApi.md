# profind_api.api.SecurityanswerprofessionalsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteSecurityanswerprofessional**](SecurityanswerprofessionalsApi.md#deletesecurityanswerprofessional) | **DELETE** /api/Securityanswerprofessionals/{id} | 
[**getSecurityanswerprofessional**](SecurityanswerprofessionalsApi.md#getsecurityanswerprofessional) | **GET** /api/Securityanswerprofessionals/{id} | 
[**getSecurityanswerprofessionals**](SecurityanswerprofessionalsApi.md#getsecurityanswerprofessionals) | **GET** /api/Securityanswerprofessionals | 
[**postSecurityanswerprofessional**](SecurityanswerprofessionalsApi.md#postsecurityanswerprofessional) | **POST** /api/Securityanswerprofessionals | 
[**putSecurityanswerprofessional**](SecurityanswerprofessionalsApi.md#putsecurityanswerprofessional) | **PUT** /api/Securityanswerprofessionals/{id} | 


# **deleteSecurityanswerprofessional**
> deleteSecurityanswerprofessional(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerprofessionalsApi();
final String id = id_example; // String | 

try {
    api.deleteSecurityanswerprofessional(id);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerprofessionalsApi->deleteSecurityanswerprofessional: $e\n');
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

# **getSecurityanswerprofessional**
> Securityanswerprofessional getSecurityanswerprofessional(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerprofessionalsApi();
final String id = id_example; // String | 

try {
    final response = api.getSecurityanswerprofessional(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerprofessionalsApi->getSecurityanswerprofessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Securityanswerprofessional**](Securityanswerprofessional.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getSecurityanswerprofessionals**
> BuiltList<Securityanswerprofessional> getSecurityanswerprofessionals()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerprofessionalsApi();

try {
    final response = api.getSecurityanswerprofessionals();
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerprofessionalsApi->getSecurityanswerprofessionals: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Securityanswerprofessional&gt;**](Securityanswerprofessional.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postSecurityanswerprofessional**
> Securityanswerprofessional postSecurityanswerprofessional(securityanswerprofessional)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerprofessionalsApi();
final Securityanswerprofessional securityanswerprofessional = ; // Securityanswerprofessional | 

try {
    final response = api.postSecurityanswerprofessional(securityanswerprofessional);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerprofessionalsApi->postSecurityanswerprofessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **securityanswerprofessional** | [**Securityanswerprofessional**](Securityanswerprofessional.md)|  | [optional] 

### Return type

[**Securityanswerprofessional**](Securityanswerprofessional.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putSecurityanswerprofessional**
> putSecurityanswerprofessional(id, securityanswerprofessional)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerprofessionalsApi();
final String id = id_example; // String | 
final Securityanswerprofessional securityanswerprofessional = ; // Securityanswerprofessional | 

try {
    api.putSecurityanswerprofessional(id, securityanswerprofessional);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerprofessionalsApi->putSecurityanswerprofessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **securityanswerprofessional** | [**Securityanswerprofessional**](Securityanswerprofessional.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

