# IO.Swagger.Api.SubscriptionsApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubscriptionsGet**](SubscriptionsApi.md#subscriptionsget) | **GET** /subscriptions | Fetch subscriptions of user
[**SubscriptionsPost**](SubscriptionsApi.md#subscriptionspost) | **POST** /subscriptions | Purchase free Product / Inform engine-and-editor of Product purchase


<a name="subscriptionsget"></a>
# **SubscriptionsGet**
> List<Subscription> SubscriptionsGet ()

Fetch subscriptions of user

Fetch a list of all the subscriptions of the authenticated user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubscriptionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionsApi();

            try
            {
                // Fetch subscriptions of user
                List&lt;Subscription&gt; result = apiInstance.SubscriptionsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Subscription>**](Subscription.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionspost"></a>
# **SubscriptionsPost**
> void SubscriptionsPost (CreateSubscription body)

Purchase free Product / Inform engine-and-editor of Product purchase

If not given field 'address', assumes user is purchasing a *free Product*. If field 'address' is given, is an idempotent operation that informs engine-and-editor that a *paid Product* has been purchased and is called by Marketplace Watcher. In both cases creates or updates an existing Subscription and related Permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubscriptionsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionsApi();
            var body = new CreateSubscription(); // CreateSubscription | Information about Product purchase

            try
            {
                // Purchase free Product / Inform engine-and-editor of Product purchase
                apiInstance.SubscriptionsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSubscription**](CreateSubscription.md)| Information about Product purchase | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

