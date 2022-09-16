# profind_api.api.NotificationsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteNotification**](NotificationsApi.md#deletenotification) | **DELETE** /api/Notifications/{id} | 
[**getNotification**](NotificationsApi.md#getnotification) | **GET** /api/Notifications/{id} | 
[**getNotifications**](NotificationsApi.md#getnotifications) | **GET** /api/Notifications | 
[**postNotification**](NotificationsApi.md#postnotification) | **POST** /api/Notifications | 
[**putNotification**](NotificationsApi.md#putnotification) | **PUT** /api/Notifications/{id} | 


# **deleteNotification**
> deleteNotification(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getNotificationsApi();
final String id = id_example; // String | 

try {
    api.deleteNotification(id);
} catch on DioError (e) {
    print('Exception when calling NotificationsApi->deleteNotification: $e\n');
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

# **getNotification**
> Notification getNotification(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getNotificationsApi();
final String id = id_example; // String | 

try {
    final response = api.getNotification(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling NotificationsApi->getNotification: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getNotifications**
> BuiltList<Notification> getNotifications()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getNotificationsApi();

try {
    final response = api.getNotifications();
    print(response);
} catch on DioError (e) {
    print('Exception when calling NotificationsApi->getNotifications: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Notification&gt;**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postNotification**
> Notification postNotification(notification)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getNotificationsApi();
final Notification notification = ; // Notification | 

try {
    final response = api.postNotification(notification);
    print(response);
} catch on DioError (e) {
    print('Exception when calling NotificationsApi->postNotification: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**Notification**](Notification.md)|  | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putNotification**
> putNotification(id, notification)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getNotificationsApi();
final String id = id_example; // String | 
final Notification notification = ; // Notification | 

try {
    api.putNotification(id, notification);
} catch on DioError (e) {
    print('Exception when calling NotificationsApi->putNotification: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **notification** | [**Notification**](Notification.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

