# profind_api.api.ProjectsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteProject**](ProjectsApi.md#deleteproject) | **DELETE** /api/Projects/{id} | 
[**getProject**](ProjectsApi.md#getproject) | **GET** /api/Projects/{id} | 
[**getProjects**](ProjectsApi.md#getprojects) | **GET** /api/Projects | 
[**postProject**](ProjectsApi.md#postproject) | **POST** /api/Projects | 
[**putProject**](ProjectsApi.md#putproject) | **PUT** /api/Projects/{id} | 


# **deleteProject**
> deleteProject(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectsApi();
final String id = id_example; // String | 

try {
    api.deleteProject(id);
} catch on DioError (e) {
    print('Exception when calling ProjectsApi->deleteProject: $e\n');
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

# **getProject**
> Project getProject(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectsApi();
final String id = id_example; // String | 

try {
    final response = api.getProject(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectsApi->getProject: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getProjects**
> BuiltList<Project> getProjects()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectsApi();

try {
    final response = api.getProjects();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectsApi->getProjects: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Project&gt;**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postProject**
> Project postProject(project)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectsApi();
final Project project = ; // Project | 

try {
    final response = api.postProject(project);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ProjectsApi->postProject: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **project** | [**Project**](Project.md)|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putProject**
> putProject(id, project)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getProjectsApi();
final String id = id_example; // String | 
final Project project = ; // Project | 

try {
    api.putProject(id, project);
} catch on DioError (e) {
    print('Exception when calling ProjectsApi->putProject: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **project** | [**Project**](Project.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

