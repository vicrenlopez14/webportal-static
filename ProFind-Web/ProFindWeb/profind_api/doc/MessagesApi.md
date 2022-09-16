# profind_api.api.MessagesApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteMessage**](MessagesApi.md#deletemessage) | **DELETE** /api/Messages/{id} | 
[**getMessage**](MessagesApi.md#getmessage) | **GET** /api/Messages/{id} | 
[**getMessages**](MessagesApi.md#getmessages) | **GET** /api/Messages | 
[**postMessage**](MessagesApi.md#postmessage) | **POST** /api/Messages | 
[**putMessage**](MessagesApi.md#putmessage) | **PUT** /api/Messages/{id} | 


# **deleteMessage**
> deleteMessage(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getMessagesApi();
final String id = id_example; // String | 

try {
    api.deleteMessage(id);
} catch on DioError (e) {
    print('Exception when calling MessagesApi->deleteMessage: $e\n');
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

# **getMessage**
> Message getMessage(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getMessagesApi();
final String id = id_example; // String | 

try {
    final response = api.getMessage(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling MessagesApi->getMessage: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Message**](Message.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getMessages**
> BuiltList<Message> getMessages()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getMessagesApi();

try {
    final response = api.getMessages();
    print(response);
} catch on DioError (e) {
    print('Exception when calling MessagesApi->getMessages: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Message&gt;**](Message.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postMessage**
> Message postMessage(message)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getMessagesApi();
final Message message = ; // Message | 

try {
    final response = api.postMessage(message);
    print(response);
} catch on DioError (e) {
    print('Exception when calling MessagesApi->postMessage: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **message** | [**Message**](Message.md)|  | [optional] 

### Return type

[**Message**](Message.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putMessage**
> putMessage(id, message)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getMessagesApi();
final String id = id_example; // String | 
final Message message = ; // Message | 

try {
    api.putMessage(id, message);
} catch on DioError (e) {
    print('Exception when calling MessagesApi->putMessage: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **message** | [**Message**](Message.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

