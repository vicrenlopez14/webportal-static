# profind_api.api.TagtemplatesApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteTagtemplate**](TagtemplatesApi.md#deletetagtemplate) | **DELETE** /api/Tagtemplates/{id} | 
[**getTagtemplate**](TagtemplatesApi.md#gettagtemplate) | **GET** /api/Tagtemplates/{id} | 
[**getTagtemplates**](TagtemplatesApi.md#gettagtemplates) | **GET** /api/Tagtemplates | 
[**postTagtemplate**](TagtemplatesApi.md#posttagtemplate) | **POST** /api/Tagtemplates | 
[**putTagtemplate**](TagtemplatesApi.md#puttagtemplate) | **PUT** /api/Tagtemplates/{id} | 


# **deleteTagtemplate**
> deleteTagtemplate(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagtemplatesApi();
final String id = id_example; // String | 

try {
    api.deleteTagtemplate(id);
} catch on DioError (e) {
    print('Exception when calling TagtemplatesApi->deleteTagtemplate: $e\n');
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

# **getTagtemplate**
> Tagtemplate getTagtemplate(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagtemplatesApi();
final String id = id_example; // String | 

try {
    final response = api.getTagtemplate(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagtemplatesApi->getTagtemplate: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Tagtemplate**](Tagtemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getTagtemplates**
> BuiltList<Tagtemplate> getTagtemplates()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagtemplatesApi();

try {
    final response = api.getTagtemplates();
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagtemplatesApi->getTagtemplates: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Tagtemplate&gt;**](Tagtemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postTagtemplate**
> Tagtemplate postTagtemplate(tagtemplate)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagtemplatesApi();
final Tagtemplate tagtemplate = ; // Tagtemplate | 

try {
    final response = api.postTagtemplate(tagtemplate);
    print(response);
} catch on DioError (e) {
    print('Exception when calling TagtemplatesApi->postTagtemplate: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagtemplate** | [**Tagtemplate**](Tagtemplate.md)|  | [optional] 

### Return type

[**Tagtemplate**](Tagtemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putTagtemplate**
> putTagtemplate(id, tagtemplate)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getTagtemplatesApi();
final String id = id_example; // String | 
final Tagtemplate tagtemplate = ; // Tagtemplate | 

try {
    api.putTagtemplate(id, tagtemplate);
} catch on DioError (e) {
    print('Exception when calling TagtemplatesApi->putTagtemplate: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **tagtemplate** | [**Tagtemplate**](Tagtemplate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

