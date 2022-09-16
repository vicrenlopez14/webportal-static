# profind_api.api.SupportticketsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteSupportticket**](SupportticketsApi.md#deletesupportticket) | **DELETE** /api/Supporttickets/{id} | 
[**getSupportticket**](SupportticketsApi.md#getsupportticket) | **GET** /api/Supporttickets/{id} | 
[**getSupporttickets**](SupportticketsApi.md#getsupporttickets) | **GET** /api/Supporttickets | 
[**postSupportticket**](SupportticketsApi.md#postsupportticket) | **POST** /api/Supporttickets | 
[**putSupportticket**](SupportticketsApi.md#putsupportticket) | **PUT** /api/Supporttickets/{id} | 


# **deleteSupportticket**
> deleteSupportticket(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSupportticketsApi();
final String id = id_example; // String | 

try {
    api.deleteSupportticket(id);
} catch on DioError (e) {
    print('Exception when calling SupportticketsApi->deleteSupportticket: $e\n');
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

# **getSupportticket**
> Supportticket getSupportticket(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSupportticketsApi();
final String id = id_example; // String | 

try {
    final response = api.getSupportticket(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SupportticketsApi->getSupportticket: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Supportticket**](Supportticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getSupporttickets**
> BuiltList<Supportticket> getSupporttickets()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSupportticketsApi();

try {
    final response = api.getSupporttickets();
    print(response);
} catch on DioError (e) {
    print('Exception when calling SupportticketsApi->getSupporttickets: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Supportticket&gt;**](Supportticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postSupportticket**
> Supportticket postSupportticket(supportticket)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSupportticketsApi();
final Supportticket supportticket = ; // Supportticket | 

try {
    final response = api.postSupportticket(supportticket);
    print(response);
} catch on DioError (e) {
    print('Exception when calling SupportticketsApi->postSupportticket: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supportticket** | [**Supportticket**](Supportticket.md)|  | [optional] 

### Return type

[**Supportticket**](Supportticket.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putSupportticket**
> putSupportticket(id, supportticket)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getSupportticketsApi();
final String id = id_example; // String | 
final Supportticket supportticket = ; // Supportticket | 

try {
    api.putSupportticket(id, supportticket);
} catch on DioError (e) {
    print('Exception when calling SupportticketsApi->putSupportticket: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **supportticket** | [**Supportticket**](Supportticket.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

