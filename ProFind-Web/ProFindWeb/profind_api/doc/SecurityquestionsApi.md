# profind_api.api.SecurityquestionsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteSecurityquestion**](SecurityquestionsApi.md#deletesecurityquestion) | **DELETE** /api/Securityquestions/{id} | 
[**getSecurityquestion**](SecurityquestionsApi.md#getsecurityquestion) | **GET** /api/Securityquestions/{id} | 
[**getSecurityquestions**](SecurityquestionsApi.md#getsecurityquestions) | **GET** /api/Securityquestions | 
[**postSecurityquestion**](SecurityquestionsApi.md#postsecurityquestion) | **POST** /api/Securityquestions | 
[**putSecurityquestion**](SecurityquestionsApi.md#putsecurityquestion) | **PUT** /api/Securityquestions/{id} | 


# **deleteSecurityquestion**
> deleteSecurityquestion(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityquestionsApi();
final String id = id_example; // String | 

try {
    api.deleteSecurityquestion(id);
} catch on DioError (e) {
    print('Exception when calling SecurityquestionsApi->deleteSecurityquestion: $e\n');
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

# **getSecurityquestion**
> Securityquestion getSecurityquestion(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityquestionsApi();
final String id = id_example; // String | 

try {
    final response = api.getSecurityquestion(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityquestionsApi->getSecurityquestion: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Securityquestion**](Securityquestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getSecurityquestions**
> BuiltList<Securityquestion> getSecurityquestions()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityquestionsApi();

try {
    final response = api.getSecurityquestions();
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityquestionsApi->getSecurityquestions: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Securityquestion&gt;**](Securityquestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postSecurityquestion**
> Securityquestion postSecurityquestion(securityquestion)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityquestionsApi();
final Securityquestion securityquestion = ; // Securityquestion | 

try {
    final response = api.postSecurityquestion(securityquestion);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SecurityquestionsApi->postSecurityquestion: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **securityquestion** | [**Securityquestion**](Securityquestion.md)|  | [optional] 

### Return type

[**Securityquestion**](Securityquestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putSecurityquestion**
> putSecurityquestion(id, securityquestion)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSecurityquestionsApi();
final String id = id_example; // String | 
final Securityquestion securityquestion = ; // Securityquestion | 

try {
    api.putSecurityquestion(id, securityquestion);
} catch on DioError (e) {
    print('Exception when calling SecurityquestionsApi->putSecurityquestion: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **securityquestion** | [**Securityquestion**](Securityquestion.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

