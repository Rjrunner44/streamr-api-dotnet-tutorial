# IO.Swagger.Api.UsersApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersMeBalanceGet**](UsersApi.md#usersmebalanceget) | **GET** /users/me/balance | Get user&#39;s DATA coin balance
[**UsersMeDelete**](UsersApi.md#usersmedelete) | **DELETE** /users/me | Delete user&#39;s profile
[**UsersMeGet**](UsersApi.md#usersmeget) | **GET** /users/me | Get the authenticated user
[**UsersMeImagePost**](UsersApi.md#usersmeimagepost) | **POST** /users/me/image | Upload user&#39;s avatar image
[**UsersMeKeysGet**](UsersApi.md#usersmekeysget) | **GET** /users/me/keys | List user&#39;s API keys
[**UsersMeKeysIdPut**](UsersApi.md#usersmekeysidput) | **PUT** /users/me/keys/{id} | Update User&#39;s Key&#39;s name
[**UsersMeKeysPost**](UsersApi.md#usersmekeyspost) | **POST** /users/me/keys | Create a new user API key
[**UsersMePut**](UsersApi.md#usersmeput) | **PUT** /users/me | Update user profile


<a name="usersmebalanceget"></a>
# **UsersMeBalanceGet**
> List<Balance> UsersMeBalanceGet ()

Get user's DATA coin balance

Get user's DATA coin balance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeBalanceGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                // Get user's DATA coin balance
                List&lt;Balance&gt; result = apiInstance.UsersMeBalanceGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeBalanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Balance>**](Balance.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmedelete"></a>
# **UsersMeDelete**
> void UsersMeDelete ()

Delete user's profile

Delete user's profile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                // Delete user's profile
                apiInstance.UsersMeDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmeget"></a>
# **UsersMeGet**
> List<User> UsersMeGet ()

Get the authenticated user

Returns information on the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                // Get the authenticated user
                List&lt;User&gt; result = apiInstance.UsersMeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<User>**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmeimagepost"></a>
# **UsersMeImagePost**
> List<User> UsersMeImagePost (System.IO.Stream _file = null)

Upload user's avatar image

Upload user's avatar image for the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeImagePostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var _file = new System.IO.Stream(); // System.IO.Stream | Image file. JPG or PNG. (optional) 

            try
            {
                // Upload user's avatar image
                List&lt;User&gt; result = apiInstance.UsersMeImagePost(_file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeImagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_file** | **System.IO.Stream**| Image file. JPG or PNG. | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
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

            var apiInstance = new UsersApi();

            try
            {
                // List user's API keys
                List&lt;UserKey&gt; result = apiInstance.UsersMeKeysGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeKeysGet: " + e.Message );
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

            var apiInstance = new UsersApi();
            var body = new UpdateUserKeyRequest(); // UpdateUserKeyRequest | UpdateUserKeyRequest object
            var id = id_example;  // string | ID of the key to be updated

            try
            {
                // Update User's Key's name
                apiInstance.UsersMeKeysIdPut(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeKeysIdPut: " + e.Message );
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

            var apiInstance = new UsersApi();
            var body = new UserKeyCreateRequest(); // UserKeyCreateRequest | Key to be created

            try
            {
                // Create a new user API key
                UserKey result = apiInstance.UsersMeKeysPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeKeysPost: " + e.Message );
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

<a name="usersmeput"></a>
# **UsersMePut**
> List<User> UsersMePut ()

Update user profile

Updates user's profile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMePutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();

            try
            {
                // Update user profile
                List&lt;User&gt; result = apiInstance.UsersMePut();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMePut: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<User>**](User.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

