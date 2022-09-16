# profind_api.api.AdminsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteAdmin**](AdminsApi.md#deleteadmin) | **DELETE** /api/Admins/{id} | 
[**filterAdmins**](AdminsApi.md#filteradmins) | **GET** /api/Admins/filter | 
[**getAdmin**](AdminsApi.md#getadmin) | **GET** /api/Admins/{id} | 
[**getAdmins**](AdminsApi.md#getadmins) | **GET** /api/Admins | 
[**getAdminsPaginated**](AdminsApi.md#getadminspaginated) | **GET** /api/Admins/paginated | 
[**loginAdmin**](AdminsApi.md#loginadmin) | **POST** /api/Admins/Login | 
[**postAdmin**](AdminsApi.md#postadmin) | **POST** /api/Admins | 
[**putAdmin**](AdminsApi.md#putadmin) | **PUT** /api/Admins/{id} | 
[**registerAdmin**](AdminsApi.md#registeradmin) | **POST** /api/Admins/Register | 
[**searchAdmins**](AdminsApi.md#searchadmins) | **GET** /api/Admins/search | 
[**searchAdminsPaginated**](AdminsApi.md#searchadminspaginated) | **GET** /api/Admins/search/paginated | 
[**sendRecoveryEmail**](AdminsApi.md#sendrecoveryemail) | **POST** /api/Admins/SendRecoveryEmail | 
[**verifyRecoveryCode**](AdminsApi.md#verifyrecoverycode) | **POST** /api/Admins/VerifyRecoveryCode | 


# **deleteAdmin**
> deleteAdmin(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String id = id_example; // String | 

try {
    api.deleteAdmin(id);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->deleteAdmin: $e\n');
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

# **filterAdmins**
> BuiltList<Admin> filterAdmins(name, name1, idAdmin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String name = name_example; // String | 
final String name1 = name1_example; // String | 
final String idAdmin = idAdmin_example; // String | 

try {
    final response = api.filterAdmins(name, name1, idAdmin);
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->filterAdmins: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**|  | [optional] 
 **name1** | **String**|  | [optional] 
 **idAdmin** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Admin&gt;**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getAdmin**
> Admin getAdmin(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String id = id_example; // String | 

try {
    final response = api.getAdmin(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->getAdmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Admin**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getAdmins**
> BuiltList<Admin> getAdmins()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();

try {
    final response = api.getAdmins();
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->getAdmins: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Admin&gt;**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getAdminsPaginated**
> BuiltList<Admin> getAdminsPaginated(limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.getAdminsPaginated(limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->getAdminsPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Admin&gt;**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **loginAdmin**
> loginAdmin(admin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final Admin admin = ; // Admin | 

try {
    api.loginAdmin(admin);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->loginAdmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **admin** | [**Admin**](Admin.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postAdmin**
> Admin postAdmin(admin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final Admin admin = ; // Admin | 

try {
    final response = api.postAdmin(admin);
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->postAdmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **admin** | [**Admin**](Admin.md)|  | [optional] 

### Return type

[**Admin**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putAdmin**
> putAdmin(id, admin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String id = id_example; // String | 
final Admin admin = ; // Admin | 

try {
    api.putAdmin(id, admin);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->putAdmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **admin** | [**Admin**](Admin.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **registerAdmin**
> registerAdmin(admin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final Admin admin = ; // Admin | 

try {
    api.registerAdmin(admin);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->registerAdmin: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **admin** | [**Admin**](Admin.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchAdmins**
> BuiltList<Admin> searchAdmins(idA, name)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String idA = idA_example; // String | 
final String name = name_example; // String | 

try {
    final response = api.searchAdmins(idA, name);
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->searchAdmins: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idA** | **String**|  | [optional] 
 **name** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Admin&gt;**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchAdminsPaginated**
> BuiltList<Admin> searchAdminsPaginated(idA, name, limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String idA = idA_example; // String | 
final String name = name_example; // String | 
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.searchAdminsPaginated(idA, name, limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->searchAdminsPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idA** | **String**|  | [optional] 
 **name** | **String**|  | [optional] 
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Admin&gt;**](Admin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sendRecoveryEmail**
> sendRecoveryEmail(email)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String email = email_example; // String | 

try {
    api.sendRecoveryEmail(email);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->sendRecoveryEmail: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **verifyRecoveryCode**
> verifyRecoveryCode(code)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getAdminsApi();
final String code = code_example; // String | 

try {
    api.verifyRecoveryCode(code);
} catch on DioError (e) {
    print('Exception when calling AdminsApi->verifyRecoveryCode: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **String**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

