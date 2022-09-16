# profind_api.api.SecurityanswerclientsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteSecurityanswerclient**](SecurityanswerclientsApi.md#deletesecurityanswerclient) | **DELETE** /api/Securityanswerclients/{id} | 
[**getSecurityanswerclient**](SecurityanswerclientsApi.md#getsecurityanswerclient) | **GET** /api/Securityanswerclients/{id} | 
[**getSecurityanswerclients**](SecurityanswerclientsApi.md#getsecurityanswerclients) | **GET** /api/Securityanswerclients | 
[**postSecurityanswerclient**](SecurityanswerclientsApi.md#postsecurityanswerclient) | **POST** /api/Securityanswerclients | 
[**putSecurityanswerclient**](SecurityanswerclientsApi.md#putsecurityanswerclient) | **PUT** /api/Securityanswerclients/{id} | 


# **deleteSecurityanswerclient**
> deleteSecurityanswerclient(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerclientsApi();
final String id = id_example; // String | 

try {
    api.deleteSecurityanswerclient(id);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerclientsApi->deleteSecurityanswerclient: $e\n');
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

# **getSecurityanswerclient**
> Securityanswerclient getSecurityanswerclient(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerclientsApi();
final String id = id_example; // String | 

try {
    final response = api.getSecurityanswerclient(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerclientsApi->getSecurityanswerclient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Securityanswerclient**](Securityanswerclient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getSecurityanswerclients**
> BuiltList<Securityanswerclient> getSecurityanswerclients()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerclientsApi();

try {
    final response = api.getSecurityanswerclients();
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerclientsApi->getSecurityanswerclients: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Securityanswerclient&gt;**](Securityanswerclient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postSecurityanswerclient**
> Securityanswerclient postSecurityanswerclient(securityanswerclient)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerclientsApi();
final Securityanswerclient securityanswerclient = ; // Securityanswerclient | 

try {
    final response = api.postSecurityanswerclient(securityanswerclient);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerclientsApi->postSecurityanswerclient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **securityanswerclient** | [**Securityanswerclient**](Securityanswerclient.md)|  | [optional] 

### Return type

[**Securityanswerclient**](Securityanswerclient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putSecurityanswerclient**
> putSecurityanswerclient(id, securityanswerclient)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityanswerclientsApi();
final String id = id_example; // String | 
final Securityanswerclient securityanswerclient = ; // Securityanswerclient | 

try {
    api.putSecurityanswerclient(id, securityanswerclient);
} catch on DioError (e) {
    print('Exception when calling SecurityanswerclientsApi->putSecurityanswerclient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **securityanswerclient** | [**Securityanswerclient**](Securityanswerclient.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

