# profind_api.api.ClientsApi

## Load the API package
```dart
import 'package:profind_api/api.dart';
```

All URIs are relative to *https://localhost:7073*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteClient**](ClientsApi.md#deleteclient) | **DELETE** /api/Clients/{id} | 
[**filterClients**](ClientsApi.md#filterclients) | **GET** /api/Clients/filter | 
[**getClient**](ClientsApi.md#getclient) | **GET** /api/Clients/{id} | 
[**getClientPaginated**](ClientsApi.md#getclientpaginated) | **GET** /api/Clients/paginated | 
[**getClients**](ClientsApi.md#getclients) | **GET** /api/Clients | 
[**loginClient**](ClientsApi.md#loginclient) | **POST** /api/Clients/Login | 
[**postClient**](ClientsApi.md#postclient) | **POST** /api/Clients | 
[**putClient**](ClientsApi.md#putclient) | **PUT** /api/Clients/{id} | 
[**registerClient**](ClientsApi.md#registerclient) | **POST** /api/Clients/Register | 
[**searchCliens**](ClientsApi.md#searchcliens) | **GET** /api/Clients/search | 
[**searchClient**](ClientsApi.md#searchclient) | **GET** /api/Clients/search/paginated | 


# **deleteClient**
> deleteClient(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String id = id_example; // String | 

try {
    api.deleteClient(id);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->deleteClient: $e\n');
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

# **filterClients**
> BuiltList<Client> filterClients(name, name1, idclien)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String name = name_example; // String | 
final String name1 = name1_example; // String | 
final String idclien = idclien_example; // String | 

try {
    final response = api.filterClients(name, name1, idclien);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->filterClients: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**|  | [optional] 
 **name1** | **String**|  | [optional] 
 **idclien** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Client&gt;**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getClient**
> Client getClient(id)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String id = id_example; // String | 

try {
    final response = api.getClient(id);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->getClient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**Client**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getClientPaginated**
> BuiltList<Client> getClientPaginated(limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.getClientPaginated(limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->getClientPaginated: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Client&gt;**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getClients**
> BuiltList<Client> getClients()



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();

try {
    final response = api.getClients();
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->getClients: $e\n');
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BuiltList&lt;Client&gt;**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **loginClient**
> loginClient(client)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final Client client = ; // Client | 

try {
    api.loginClient(client);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->loginClient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **client** | [**Client**](Client.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postClient**
> Client postClient(client)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final Client client = ; // Client | 

try {
    final response = api.postClient(client);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->postClient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **client** | [**Client**](Client.md)|  | [optional] 

### Return type

[**Client**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **putClient**
> putClient(id, client)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String id = id_example; // String | 
final Client client = ; // Client | 

try {
    api.putClient(id, client);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->putClient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 
 **client** | [**Client**](Client.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **registerClient**
> registerClient(client)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final Client client = ; // Client | 

try {
    api.registerClient(client);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->registerClient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **client** | [**Client**](Client.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchCliens**
> BuiltList<Client> searchCliens(idC, name)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String idC = idC_example; // String | 
final String name = name_example; // String | 

try {
    final response = api.searchCliens(idC, name);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->searchCliens: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idC** | **String**|  | [optional] 
 **name** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Client&gt;**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchClient**
> BuiltList<Client> searchClient(idC, name, limit, offset)



### Example
```dart
import 'package:profind_api/api.dart';

final api = ProfindApi().getClientsApi();
final String idC = idC_example; // String | 
final String name = name_example; // String | 
final String limit = limit_example; // String | 
final String offset = offset_example; // String | 

try {
    final response = api.searchClient(idC, name, limit, offset);
    print(response);
} catch on DioError (e) {
    print('Exception when calling ClientsApi->searchClient: $e\n');
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idC** | **String**|  | [optional] 
 **name** | **String**|  | [optional] 
 **limit** | **String**|  | [optional] 
 **offset** | **String**|  | [optional] 

### Return type

[**BuiltList&lt;Client&gt;**](Client.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

