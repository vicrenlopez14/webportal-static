# profind_api.api.LoginAdminApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**login**](LoginAdminApi.md#login) | **POST** /api/LoginAdmin | 


# **login**
> login(adminLogin)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getLoginAdminApi();
final AdminLogin adminLogin = ; // AdminLogin | 

try {
    api.login(adminLogin);
} catch on DioError (e) {
    print('Exception when calling LoginAdminApi->login: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **adminLogin** | [**AdminLogin**](AdminLogin.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

