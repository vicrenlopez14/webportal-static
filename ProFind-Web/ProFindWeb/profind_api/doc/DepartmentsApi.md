# profind_api.api.DepartmentsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteDepartment**](DepartmentsApi.md#deletedepartment) | **DELETE** /api/Departments/{id} | 
[**getDepartment**](DepartmentsApi.md#getdepartment) | **GET** /api/Departments/{id} | 
[**getDepartments**](DepartmentsApi.md#getdepartments) | **GET** /api/Departments | 
[**postDepartment**](DepartmentsApi.md#postdepartment) | **POST** /api/Departments | 
[**putDepartment**](DepartmentsApi.md#putdepartment) | **PUT** /api/Departments/{id} | 


# **deleteDepartment**
> deleteDepartment(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getDepartmentsApi();
final int id = 56; // int | 

try {
    api.deleteDepartment(id);
} catch on DioError (e) {
    print('Exception when calling DepartmentsApi->deleteDepartment: $e\n');
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

# **getDepartment**
> Department getDepartment(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getDepartmentsApi();
final int id = 56; // int | 

try {
    final response = api.getDepartment(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling DepartmentsApi->getDepartment: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Department**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getDepartments**
> BuiltList<Department> getDepartments()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getDepartmentsApi();

try {
    final response = api.getDepartments();
    print(response);
} catch on DioError (e) {
    print('Exception when calling DepartmentsApi->getDepartments: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Department&gt;**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postDepartment**
> Department postDepartment(department)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getDepartmentsApi();
final Department department = ; // Department | 

try {
    final response = api.postDepartment(department);
    print(response);
} catch on DioError (e) {
    print('Exception when calling DepartmentsApi->postDepartment: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **department** | [**Department**](Department.md)|  | [optional] 

### Return type

[**Department**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putDepartment**
> putDepartment(id, department)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getDepartmentsApi();
final int id = 56; // int | 
final Department department = ; // Department | 

try {
    api.putDepartment(id, department);
} catch on DioError (e) {
    print('Exception when calling DepartmentsApi->putDepartment: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **department** | [**Department**](Department.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

