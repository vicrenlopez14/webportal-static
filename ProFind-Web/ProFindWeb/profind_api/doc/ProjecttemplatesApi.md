# profind_api.api.ProjecttemplatesApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProjecttemplate**](ProjecttemplatesApi.md#deleteprojecttemplate) | **DELETE** /api/Projecttemplates/{id} | 
[**getProjecttemplate**](ProjecttemplatesApi.md#getprojecttemplate) | **GET** /api/Projecttemplates/{id} | 
[**getProjecttemplates**](ProjecttemplatesApi.md#getprojecttemplates) | **GET** /api/Projecttemplates | 
[**postProjecttemplate**](ProjecttemplatesApi.md#postprojecttemplate) | **POST** /api/Projecttemplates | 
[**putProjecttemplate**](ProjecttemplatesApi.md#putprojecttemplate) | **PUT** /api/Projecttemplates/{id} | 


# **deleteProjecttemplate**
> deleteProjecttemplate(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjecttemplatesApi();
final String id = id_example; // String | 

try {
    api.deleteProjecttemplate(id);
} catch on DioError (e) {
    print('Exception when calling ProjecttemplatesApi->deleteProjecttemplate: $e\n');
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

# **getProjecttemplate**
> Projecttemplate getProjecttemplate(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjecttemplatesApi();
final String id = id_example; // String | 

try {
    final response = api.getProjecttemplate(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjecttemplatesApi->getProjecttemplate: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Projecttemplate**](Projecttemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProjecttemplates**
> BuiltList<Projecttemplate> getProjecttemplates()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjecttemplatesApi();

try {
    final response = api.getProjecttemplates();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjecttemplatesApi->getProjecttemplates: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Projecttemplate&gt;**](Projecttemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProjecttemplate**
> Projecttemplate postProjecttemplate(projecttemplate)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjecttemplatesApi();
final Projecttemplate projecttemplate = ; // Projecttemplate | 

try {
    final response = api.postProjecttemplate(projecttemplate);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjecttemplatesApi->postProjecttemplate: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projecttemplate** | [**Projecttemplate**](Projecttemplate.md)|  | [optional] 

### Return type

[**Projecttemplate**](Projecttemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProjecttemplate**
> putProjecttemplate(id, projecttemplate)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjecttemplatesApi();
final String id = id_example; // String | 
final Projecttemplate projecttemplate = ; // Projecttemplate | 

try {
    api.putProjecttemplate(id, projecttemplate);
} catch on DioError (e) {
    print('Exception when calling ProjecttemplatesApi->putProjecttemplate: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **projecttemplate** | [**Projecttemplate**](Projecttemplate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

