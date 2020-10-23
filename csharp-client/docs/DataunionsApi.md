# IO.Swagger.Api.DataunionsApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataunionsContractAddressJoinRequestsGet**](DataunionsApi.md#dataunionscontractaddressjoinrequestsget) | **GET** /dataunions/{contractAddress}/joinRequests | List all join requests
[**DataunionsContractAddressJoinRequestsJoinRequestIdDelete**](DataunionsApi.md#dataunionscontractaddressjoinrequestsjoinrequestiddelete) | **DELETE** /dataunions/{contractAddress}/joinRequests/{joinRequestId} | Delete join request
[**DataunionsContractAddressJoinRequestsJoinRequestIdGet**](DataunionsApi.md#dataunionscontractaddressjoinrequestsjoinrequestidget) | **GET** /dataunions/{contractAddress}/joinRequests/{joinRequestId} | Find join request by id
[**DataunionsContractAddressJoinRequestsJoinRequestIdPut**](DataunionsApi.md#dataunionscontractaddressjoinrequestsjoinrequestidput) | **PUT** /dataunions/{contractAddress}/joinRequests/{joinRequestId} | Update join request state
[**DataunionsContractAddressJoinRequestsPost**](DataunionsApi.md#dataunionscontractaddressjoinrequestspost) | **POST** /dataunions/{contractAddress}/joinRequests | Create join request
[**DataunionsContractAddressMembersGet**](DataunionsApi.md#dataunionscontractaddressmembersget) | **GET** /dataunions/{contractAddress}/members | Proxy calls to to data union server.
[**DataunionsContractAddressMembersMemberAddressGet**](DataunionsApi.md#dataunionscontractaddressmembersmemberaddressget) | **GET** /dataunions/{contractAddress}/members/{memberAddress} | Proxy calls to to data union server.
[**DataunionsContractAddressSecretsDataUnionSecretIdDelete**](DataunionsApi.md#dataunionscontractaddresssecretsdataunionsecretiddelete) | **DELETE** /dataunions/{contractAddress}/secrets/{dataUnionSecretId} | Delete secret
[**DataunionsContractAddressSecretsDataUnionSecretIdGet**](DataunionsApi.md#dataunionscontractaddresssecretsdataunionsecretidget) | **GET** /dataunions/{contractAddress}/secrets/{dataUnionSecretId} | Find secret by id
[**DataunionsContractAddressSecretsDataUnionSecretIdPut**](DataunionsApi.md#dataunionscontractaddresssecretsdataunionsecretidput) | **PUT** /dataunions/{contractAddress}/secrets/{dataUnionSecretId} | Update secret
[**DataunionsContractAddressSecretsGet**](DataunionsApi.md#dataunionscontractaddresssecretsget) | **GET** /dataunions/{contractAddress}/secrets | List all data union secrets
[**DataunionsContractAddressSecretsPost**](DataunionsApi.md#dataunionscontractaddresssecretspost) | **POST** /dataunions/{contractAddress}/secrets | Create secret
[**DataunionsContractAddressStatsGet**](DataunionsApi.md#dataunionscontractaddressstatsget) | **GET** /dataunions/{contractAddress}/stats | Proxy calls to to data union server.


<a name="dataunionscontractaddressjoinrequestsget"></a>
# **DataunionsContractAddressJoinRequestsGet**
> void DataunionsContractAddressJoinRequestsGet (string contractAddress, string state = null)

List all join requests

List all join requests for this data union.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressJoinRequestsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var state = state_example;  // string | Filter listing by state of the join request (optional) 

            try
            {
                // List all join requests
                apiInstance.DataunionsContractAddressJoinRequestsGet(contractAddress, state);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressJoinRequestsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **state** | **string**| Filter listing by state of the join request | [optional] 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressjoinrequestsjoinrequestiddelete"></a>
# **DataunionsContractAddressJoinRequestsJoinRequestIdDelete**
> void DataunionsContractAddressJoinRequestsJoinRequestIdDelete (string contractAddress, string joinRequestId)

Delete join request

Delete data union join request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressJoinRequestsJoinRequestIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var joinRequestId = joinRequestId_example;  // string | ID of the join request

            try
            {
                // Delete join request
                apiInstance.DataunionsContractAddressJoinRequestsJoinRequestIdDelete(contractAddress, joinRequestId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressJoinRequestsJoinRequestIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **joinRequestId** | **string**| ID of the join request | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressjoinrequestsjoinrequestidget"></a>
# **DataunionsContractAddressJoinRequestsJoinRequestIdGet**
> void DataunionsContractAddressJoinRequestsJoinRequestIdGet (string contractAddress, string joinRequestId)

Find join request by id

Find data union join request by join request id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressJoinRequestsJoinRequestIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var joinRequestId = joinRequestId_example;  // string | ID of the join request

            try
            {
                // Find join request by id
                apiInstance.DataunionsContractAddressJoinRequestsJoinRequestIdGet(contractAddress, joinRequestId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressJoinRequestsJoinRequestIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **joinRequestId** | **string**| ID of the join request | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressjoinrequestsjoinrequestidput"></a>
# **DataunionsContractAddressJoinRequestsJoinRequestIdPut**
> void DataunionsContractAddressJoinRequestsJoinRequestIdPut (string contractAddress, string joinRequestId, UpdateDataUnionJoinRequest body)

Update join request state

Update state attribute of the join request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressJoinRequestsJoinRequestIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var joinRequestId = joinRequestId_example;  // string | ID of the join request
            var body = new UpdateDataUnionJoinRequest(); // UpdateDataUnionJoinRequest | Data union join request state

            try
            {
                // Update join request state
                apiInstance.DataunionsContractAddressJoinRequestsJoinRequestIdPut(contractAddress, joinRequestId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressJoinRequestsJoinRequestIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **joinRequestId** | **string**| ID of the join request | 
 **body** | [**UpdateDataUnionJoinRequest**](UpdateDataUnionJoinRequest.md)| Data union join request state | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressjoinrequestspost"></a>
# **DataunionsContractAddressJoinRequestsPost**
> void DataunionsContractAddressJoinRequestsPost (string contractAddress, CreateDataUnionJoinRequest body)

Create join request

Create data union join request from given json body

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressJoinRequestsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var body = new CreateDataUnionJoinRequest(); // CreateDataUnionJoinRequest | Data union join request details

            try
            {
                // Create join request
                apiInstance.DataunionsContractAddressJoinRequestsPost(contractAddress, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressJoinRequestsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **body** | [**CreateDataUnionJoinRequest**](CreateDataUnionJoinRequest.md)| Data union join request details | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressmembersget"></a>
# **DataunionsContractAddressMembersGet**
> void DataunionsContractAddressMembersGet (string contractAddress)

Proxy calls to to data union server.

Return a list of members

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressMembersGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract

            try
            {
                // Proxy calls to to data union server.
                apiInstance.DataunionsContractAddressMembersGet(contractAddress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressmembersmemberaddressget"></a>
# **DataunionsContractAddressMembersMemberAddressGet**
> void DataunionsContractAddressMembersMemberAddressGet (string contractAddress, string memberAddress)

Proxy calls to to data union server.

Return stats for individual members

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressMembersMemberAddressGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var memberAddress = memberAddress_example;  // string | Ethereum address of the member

            try
            {
                // Proxy calls to to data union server.
                apiInstance.DataunionsContractAddressMembersMemberAddressGet(contractAddress, memberAddress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressMembersMemberAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **memberAddress** | **string**| Ethereum address of the member | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddresssecretsdataunionsecretiddelete"></a>
# **DataunionsContractAddressSecretsDataUnionSecretIdDelete**
> void DataunionsContractAddressSecretsDataUnionSecretIdDelete (string contractAddress, string dataUnionSecretId)

Delete secret

Delete data union secret.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressSecretsDataUnionSecretIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var dataUnionSecretId = dataUnionSecretId_example;  // string | ID of the secret

            try
            {
                // Delete secret
                apiInstance.DataunionsContractAddressSecretsDataUnionSecretIdDelete(contractAddress, dataUnionSecretId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressSecretsDataUnionSecretIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **dataUnionSecretId** | **string**| ID of the secret | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddresssecretsdataunionsecretidget"></a>
# **DataunionsContractAddressSecretsDataUnionSecretIdGet**
> DataUnionSecret DataunionsContractAddressSecretsDataUnionSecretIdGet (string contractAddress, string dataUnionSecretId)

Find secret by id

Find data union secret by id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressSecretsDataUnionSecretIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var dataUnionSecretId = dataUnionSecretId_example;  // string | ID of the data union secret

            try
            {
                // Find secret by id
                DataUnionSecret result = apiInstance.DataunionsContractAddressSecretsDataUnionSecretIdGet(contractAddress, dataUnionSecretId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressSecretsDataUnionSecretIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **dataUnionSecretId** | **string**| ID of the data union secret | 

### Return type

[**DataUnionSecret**](DataUnionSecret.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddresssecretsdataunionsecretidput"></a>
# **DataunionsContractAddressSecretsDataUnionSecretIdPut**
> DataUnionSecret DataunionsContractAddressSecretsDataUnionSecretIdPut (string contractAddress, string dataUnionSecretId, Body body)

Update secret

Most useful for changing the name of the secret. Note that the randomly generated secret itself cannot be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressSecretsDataUnionSecretIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var dataUnionSecretId = dataUnionSecretId_example;  // string | ID of the secret
            var body = new Body(); // Body | Updated data union secret details

            try
            {
                // Update secret
                DataUnionSecret result = apiInstance.DataunionsContractAddressSecretsDataUnionSecretIdPut(contractAddress, dataUnionSecretId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressSecretsDataUnionSecretIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **dataUnionSecretId** | **string**| ID of the secret | 
 **body** | [**Body**](Body.md)| Updated data union secret details | 

### Return type

[**DataUnionSecret**](DataUnionSecret.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddresssecretsget"></a>
# **DataunionsContractAddressSecretsGet**
> void DataunionsContractAddressSecretsGet (string contractAddress)

List all data union secrets

List all secrets for this data union.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressSecretsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract

            try
            {
                // List all data union secrets
                apiInstance.DataunionsContractAddressSecretsGet(contractAddress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressSecretsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddresssecretspost"></a>
# **DataunionsContractAddressSecretsPost**
> DataUnionSecret DataunionsContractAddressSecretsPost (string contractAddress, CreateDataUnionSecret body)

Create secret

Create data union secret

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressSecretsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract
            var body = new CreateDataUnionSecret(); // CreateDataUnionSecret | Create data union secret details

            try
            {
                // Create secret
                DataUnionSecret result = apiInstance.DataunionsContractAddressSecretsPost(contractAddress, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressSecretsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 
 **body** | [**CreateDataUnionSecret**](CreateDataUnionSecret.md)| Create data union secret details | 

### Return type

[**DataUnionSecret**](DataUnionSecret.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataunionscontractaddressstatsget"></a>
# **DataunionsContractAddressStatsGet**
> void DataunionsContractAddressStatsGet (string contractAddress)

Proxy calls to to data union server.

Return operator stats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataunionsContractAddressStatsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataunionsApi();
            var contractAddress = contractAddress_example;  // string | Ethereum address of the data union smart contract

            try
            {
                // Proxy calls to to data union server.
                apiInstance.DataunionsContractAddressStatsGet(contractAddress);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataunionsApi.DataunionsContractAddressStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractAddress** | **string**| Ethereum address of the data union smart contract | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

