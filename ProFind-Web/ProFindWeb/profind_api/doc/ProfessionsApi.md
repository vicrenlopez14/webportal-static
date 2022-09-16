# profind_api.api.ProfessionsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProfession**](ProfessionsApi.md#deleteprofession) | **DELETE** /api/Professions/{id} | 
[**getProfession**](ProfessionsApi.md#getprofession) | **GET** /api/Professions/{id} | 
[**getProfessions**](ProfessionsApi.md#getprofessions) | **GET** /api/Professions | 
[**postProfession**](ProfessionsApi.md#postprofession) | **POST** /api/Professions | 
[**putProfession**](ProfessionsApi.md#putprofession) | **PUT** /api/Professions/{id} | 


# **deleteProfession**
> deleteProfession(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionsApi();
final int id = 56; // int | 

try {
    api.deleteProfession(id);
} catch on DioError (e) {
    print('Exception when calling ProfessionsApi->deleteProfession: $e\n');
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

# **getProfession**
> Profession getProfession(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionsApi();
final int id = 56; // int | 

try {
    final response = api.getProfession(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProfessionsApi->getProfession: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Profession**](Profession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProfessions**
> BuiltList<Profession> getProfessions()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionsApi();

try {
    final response = api.getProfessions();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProfessionsApi->getProfessions: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Profession&gt;**](Profession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProfession**
> Profession postProfession(profession)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionsApi();
final Profession profession = ; // Profession | 

try {
    final response = api.postProfession(profession);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProfessionsApi->postProfession: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profession** | [**Profession**](Profession.md)|  | [optional] 

### Return type

[**Profession**](Profession.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProfession**
> putProfession(id, profession)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProfessionsApi();
final int id = 56; // int | 
final Profession profession = ; // Profession | 

try {
    api.putProfession(id, profession);
} catch on DioError (e) {
    print('Exception when calling ProfessionsApi->putProfession: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **profession** | [**Profession**](Profession.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

