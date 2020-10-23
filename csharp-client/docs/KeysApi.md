# IO.Swagger.Api.KeysApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StreamsIdKeysGet**](KeysApi.md#streamsidkeysget) | **GET** /streams/{id}/keys | List keys
[**StreamsIdKeysPost**](KeysApi.md#streamsidkeyspost) | **POST** /streams/{id}/keys | Create a key
[**StreamsStreamIdKeysIdDelete**](KeysApi.md#streamsstreamidkeysiddelete) | **DELETE** /streams/{streamId}/keys/{id} | Delete a key
[**StreamsStreamIdKeysIdPut**](KeysApi.md#streamsstreamidkeysidput) | **PUT** /streams/{streamId}/keys/{id} | Update Stream&#39;s Key&#39;s name and permission
[**UsersMeKeysGet**](KeysApi.md#usersmekeysget) | **GET** /users/me/keys | List user&#39;s API keys
[**UsersMeKeysIdDelete**](KeysApi.md#usersmekeysiddelete) | **DELETE** /users/me/keys/{id} | Delete user API key
[**UsersMeKeysIdPut**](KeysApi.md#usersmekeysidput) | **PUT** /users/me/keys/{id} | Update User&#39;s Key&#39;s name
[**UsersMeKeysPost**](KeysApi.md#usersmekeyspost) | **POST** /users/me/keys | Create a new user API key


<a name="streamsidkeysget"></a>
# **StreamsIdKeysGet**
> List<ResourceKey> StreamsIdKeysGet (string id)

List keys

List the keys for a given Stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdKeysGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var id = id_example;  // string | ID of the stream

            try
            {
                // List keys
                List&lt;ResourceKey&gt; result = apiInstance.StreamsIdKeysGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.StreamsIdKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 

### Return type

[**List<ResourceKey>**](ResourceKey.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidkeyspost"></a>
# **StreamsIdKeysPost**
> ResourceKey StreamsIdKeysPost (string id, ResourceKeyCreateRequest body)

Create a key

Creates an API key for the given Stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdKeysPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var id = id_example;  // string | ID of the stream
            var body = new ResourceKeyCreateRequest(); // ResourceKeyCreateRequest | Key to be created

            try
            {
                // Create a key
                ResourceKey result = apiInstance.StreamsIdKeysPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.StreamsIdKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **body** | [**ResourceKeyCreateRequest**](ResourceKeyCreateRequest.md)| Key to be created | 

### Return type

[**ResourceKey**](ResourceKey.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsstreamidkeysiddelete"></a>
# **StreamsStreamIdKeysIdDelete**
> void StreamsStreamIdKeysIdDelete (string streamId, string id)

Delete a key

Deletes an API key from the given Stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsStreamIdKeysIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var streamId = streamId_example;  // string | ID of the stream
            var id = id_example;  // string | ID of the key

            try
            {
                // Delete a key
                apiInstance.StreamsStreamIdKeysIdDelete(streamId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.StreamsStreamIdKeysIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **streamId** | **string**| ID of the stream | 
 **id** | **string**| ID of the key | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsstreamidkeysidput"></a>
# **StreamsStreamIdKeysIdPut**
> void StreamsStreamIdKeysIdPut (UpdateStreamKeyRequest body, string streamId, string id)

Update Stream's Key's name and permission

Update Stream's Key's name and permission.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsStreamIdKeysIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var body = new UpdateStreamKeyRequest(); // UpdateStreamKeyRequest | UpdateStreamKeyRequest object
            var streamId = streamId_example;  // string | ID of the stream
            var id = id_example;  // string | ID of the key to be updated

            try
            {
                // Update Stream's Key's name and permission
                apiInstance.StreamsStreamIdKeysIdPut(body, streamId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.StreamsStreamIdKeysIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateStreamKeyRequest**](UpdateStreamKeyRequest.md)| UpdateStreamKeyRequest object | 
 **streamId** | **string**| ID of the stream | 
 **id** | **string**| ID of the key to be updated | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmekeysget"></a>
# **UsersMeKeysGet**
> List<UserKey> UsersMeKeysGet ()

List user's API keys

List the API keys for the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeKeysGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();

            try
            {
                // List user's API keys
                List&lt;UserKey&gt; result = apiInstance.UsersMeKeysGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.UsersMeKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserKey>**](UserKey.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmekeysiddelete"></a>
# **UsersMeKeysIdDelete**
> void UsersMeKeysIdDelete (string id)

Delete user API key

Revoke and delete a user API key. Can only be called by the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeKeysIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var id = id_example;  // string | ID of the key

            try
            {
                // Delete user API key
                apiInstance.UsersMeKeysIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.UsersMeKeysIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the key | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmekeysidput"></a>
# **UsersMeKeysIdPut**
> void UsersMeKeysIdPut (UpdateUserKeyRequest body, string id)

Update User's Key's name

Update User's Key's name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeKeysIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var body = new UpdateUserKeyRequest(); // UpdateUserKeyRequest | UpdateUserKeyRequest object
            var id = id_example;  // string | ID of the key to be updated

            try
            {
                // Update User's Key's name
                apiInstance.UsersMeKeysIdPut(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.UsersMeKeysIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateUserKeyRequest**](UpdateUserKeyRequest.md)| UpdateUserKeyRequest object | 
 **id** | **string**| ID of the key to be updated | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmekeyspost"></a>
# **UsersMeKeysPost**
> UserKey UsersMeKeysPost (UserKeyCreateRequest body)

Create a new user API key

Creates a key that can be used for authenticating the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeKeysPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi();
            var body = new UserKeyCreateRequest(); // UserKeyCreateRequest | Key to be created

            try
            {
                // Create a new user API key
                UserKey result = apiInstance.UsersMeKeysPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeysApi.UsersMeKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserKeyCreateRequest**](UserKeyCreateRequest.md)| Key to be created | 

### Return type

[**UserKey**](UserKey.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

