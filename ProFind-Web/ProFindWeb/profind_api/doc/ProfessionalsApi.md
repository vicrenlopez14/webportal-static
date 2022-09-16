# profind_api.api.ProfessionalsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProfessional**](ProfessionalsApi.md#deleteprofessional) | **DELETE** /api/Professionals/{id} | 
[**getProfessional**](ProfessionalsApi.md#getprofessional) | **GET** /api/Professionals/{id} | 
[**getProfessionals**](ProfessionalsApi.md#getprofessionals) | **GET** /api/Professionals | 
[**loginProfessional**](ProfessionalsApi.md#loginprofessional) | **POST** /api/Professionals/Login | 
[**postProfessional**](ProfessionalsApi.md#postprofessional) | **POST** /api/Professionals | 
[**putProfessional**](ProfessionalsApi.md#putprofessional) | **PUT** /api/Professionals/{id} | 
[**registerProfessional**](ProfessionalsApi.md#registerprofessional) | **POST** /api/Professionals/Register | 


# **deleteProfessional**
> deleteProfessional(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();
final String id = id_example; // String | 

try {
    api.deleteProfessional(id);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->deleteProfessional: $e\n');
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

# **getProfessional**
> Professional getProfessional(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();
final String id = id_example; // String | 

try {
    final response = api.getProfessional(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->getProfessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Professional**](Professional.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProfessionals**
> BuiltList<Professional> getProfessionals()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();

try {
    final response = api.getProfessionals();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->getProfessionals: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Professional&gt;**](Professional.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **loginProfessional**
> loginProfessional(professional)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();
final Professional professional = ; // Professional | 

try {
    api.loginProfessional(professional);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->loginProfessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **professional** | [**Professional**](Professional.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProfessional**
> Professional postProfessional(professional)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();
final Professional professional = ; // Professional | 

try {
    final response = api.postProfessional(professional);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->postProfessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **professional** | [**Professional**](Professional.md)|  | [optional] 

### Return type

[**Professional**](Professional.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProfessional**
> putProfessional(id, professional)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();
final String id = id_example; // String | 
final Professional professional = ; // Professional | 

try {
    api.putProfessional(id, professional);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->putProfessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **professional** | [**Professional**](Professional.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **registerProfessional**
> registerProfessional(professional)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionalsApi();
final Professional professional = ; // Professional | 

try {
    api.registerProfessional(professional);
} catch on DioError (e) {
    print('Exception when calling ProfessionalsApi->registerProfessional: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **professional** | [**Professional**](Professional.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

