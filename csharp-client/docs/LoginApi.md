# IO.Swagger.Api.LoginApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoginApikeyPost**](LoginApi.md#loginapikeypost) | **POST** /login/apikey | Log in with API key verification
[**LoginChallengeAddressPost**](LoginApi.md#loginchallengeaddresspost) | **POST** /login/challenge/{address} | Generate challenge
[**LoginPasswordPost**](LoginApi.md#loginpasswordpost) | **POST** /login/password | Log in with password verification
[**LoginResponsePost**](LoginApi.md#loginresponsepost) | **POST** /login/response | Log in with challenge verification


<a name="loginapikeypost"></a>
# **LoginApikeyPost**
> SessionToken LoginApikeyPost (APIKey body)

Log in with API key verification

Verifies that an API key belongs to the user. If it does, generates a session token for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginApikeyPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoginApi();
            var body = new APIKey(); // APIKey | API Key

            try
            {
                // Log in with API key verification
                SessionToken result = apiInstance.LoginApikeyPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.LoginApikeyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**APIKey**](APIKey.md)| API Key | 

### Return type

[**SessionToken**](SessionToken.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginchallengeaddresspost"></a>
# **LoginChallengeAddressPost**
> Challenge LoginChallengeAddressPost (string address)

Generate challenge

Generates a challenge to be signed by an Ethereum private key to prove possession of an Ethereum account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginChallengeAddressPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoginApi();
            var address = address_example;  // string | Public Ethereum address of the account for signature verification

            try
            {
                // Generate challenge
                Challenge result = apiInstance.LoginChallengeAddressPost(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.LoginChallengeAddressPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Public Ethereum address of the account for signature verification | 

### Return type

[**Challenge**](Challenge.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginpasswordpost"></a>
# **LoginPasswordPost**
> SessionToken LoginPasswordPost (UsernamePassword body)

Log in with password verification

Verifies a username/password combination. If correct, generates a session token for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginPasswordPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoginApi();
            var body = new UsernamePassword(); // UsernamePassword | Username and password combination

            try
            {
                // Log in with password verification
                SessionToken result = apiInstance.LoginPasswordPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.LoginPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsernamePassword**](UsernamePassword.md)| Username and password combination | 

### Return type

[**SessionToken**](SessionToken.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginresponsepost"></a>
# **LoginResponsePost**
> SessionToken LoginResponsePost (ChallengeResponse body)

Log in with challenge verification

Verifies a signature against a challenge. If it matches, generates a session token for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginResponsePostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoginApi();
            var body = new ChallengeResponse(); // ChallengeResponse | Challenge response

            try
            {
                // Log in with challenge verification
                SessionToken result = apiInstance.LoginResponsePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.LoginResponsePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChallengeResponse**](ChallengeResponse.md)| Challenge response | 

### Return type

[**SessionToken**](SessionToken.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

