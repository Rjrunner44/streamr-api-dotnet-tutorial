# IO.Swagger.Api.DashboardsApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DashboardsDashboardIdItemsIdDelete**](DashboardsApi.md#dashboardsdashboardiditemsiddelete) | **DELETE** /dashboards/{dashboardId}/items/{id} | Delete a Dashboard Item
[**DashboardsDashboardIdItemsIdGet**](DashboardsApi.md#dashboardsdashboardiditemsidget) | **GET** /dashboards/{dashboardId}/items/{id} | Get Dashboard Item
[**DashboardsDashboardIdItemsIdPut**](DashboardsApi.md#dashboardsdashboardiditemsidput) | **PUT** /dashboards/{dashboardId}/items/{id} | Update a Dashboard Item
[**DashboardsGet**](DashboardsApi.md#dashboardsget) | **GET** /dashboards | List dashboards
[**DashboardsIdDelete**](DashboardsApi.md#dashboardsiddelete) | **DELETE** /dashboards/{id} | Delete a Dashboard
[**DashboardsIdGet**](DashboardsApi.md#dashboardsidget) | **GET** /dashboards/{id} | Get Dashboard
[**DashboardsIdItemsGet**](DashboardsApi.md#dashboardsiditemsget) | **GET** /dashboards/{id}/items | List Items of Dashboard
[**DashboardsIdItemsPost**](DashboardsApi.md#dashboardsiditemspost) | **POST** /dashboards/{id}/items | Create a new Dashboard Item
[**DashboardsIdPut**](DashboardsApi.md#dashboardsidput) | **PUT** /dashboards/{id} | Update a Dashboard
[**DashboardsPost**](DashboardsApi.md#dashboardspost) | **POST** /dashboards | Create a Dashboard


<a name="dashboardsdashboardiditemsiddelete"></a>
# **DashboardsDashboardIdItemsIdDelete**
> void DashboardsDashboardIdItemsIdDelete (string dashboardId, string id)

Delete a Dashboard Item

Deletes a Dashboard Item and disassociates it from its parent Dashboard

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsDashboardIdItemsIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var dashboardId = dashboardId_example;  // string | ID of the Dashboard
            var id = id_example;  // string | ID of the Dashboard Item

            try
            {
                // Delete a Dashboard Item
                apiInstance.DashboardsDashboardIdItemsIdDelete(dashboardId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsDashboardIdItemsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dashboardId** | **string**| ID of the Dashboard | 
 **id** | **string**| ID of the Dashboard Item | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsdashboardiditemsidget"></a>
# **DashboardsDashboardIdItemsIdGet**
> DashboardItem DashboardsDashboardIdItemsIdGet (string dashboardId, string id)

Get Dashboard Item

Get Dashboard Item from associated Dashboard

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsDashboardIdItemsIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var dashboardId = dashboardId_example;  // string | ID of the Dashboard
            var id = id_example;  // string | ID of the Dashboard Item

            try
            {
                // Get Dashboard Item
                DashboardItem result = apiInstance.DashboardsDashboardIdItemsIdGet(dashboardId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsDashboardIdItemsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dashboardId** | **string**| ID of the Dashboard | 
 **id** | **string**| ID of the Dashboard Item | 

### Return type

[**DashboardItem**](DashboardItem.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsdashboardiditemsidput"></a>
# **DashboardsDashboardIdItemsIdPut**
> DashboardItem DashboardsDashboardIdItemsIdPut (string dashboardId, string id, SaveDashboardItemRequest body)

Update a Dashboard Item

Updates an existing Dashboard Item associated with a Dashboard

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsDashboardIdItemsIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var dashboardId = dashboardId_example;  // string | ID of the Dashboard
            var id = id_example;  // string | ID of the Dashboard Item
            var body = new SaveDashboardItemRequest(); // SaveDashboardItemRequest | New Dashboard Item details

            try
            {
                // Update a Dashboard Item
                DashboardItem result = apiInstance.DashboardsDashboardIdItemsIdPut(dashboardId, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsDashboardIdItemsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dashboardId** | **string**| ID of the Dashboard | 
 **id** | **string**| ID of the Dashboard Item | 
 **body** | [**SaveDashboardItemRequest**](SaveDashboardItemRequest.md)| New Dashboard Item details | 

### Return type

[**DashboardItem**](DashboardItem.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsget"></a>
# **DashboardsGet**
> List<DashboardSummary> DashboardsGet (string name = null, string search = null, string sortBy = null, string order = null, int? max = null, int? offset = null, bool? grantedAccess = null, bool? publicAccess = null, string operation = null)

List dashboards

Lists your dashboards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var name = name_example;  // string | Only return dashboards that exactly match the given name. (optional) 
            var search = search_example;  // string | Filter by search term in name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort the returned results by the given field. (optional)  (default to id)
            var order = order_example;  // string | Control whether the results are sorted in ascending or descending order. Used with parameter `sortBy`. (optional)  (default to asc)
            var max = 56;  // int? | Maximum number of returned results (capped at 100) (optional)  (default to 100)
            var offset = 56;  // int? | Skip the first (offset) results. Used together with max for paging. (optional)  (default to 0)
            var grantedAccess = true;  // bool? | If false, excludes resources that user has been granted specific permission to from results. (optional)  (default to true)
            var publicAccess = true;  // bool? | If true, includes publicly available resources in the results. (optional)  (default to false)
            var operation = operation_example;  // string | Filter results by Permission (access level) (optional)  (default to dashboard_get)

            try
            {
                // List dashboards
                List&lt;DashboardSummary&gt; result = apiInstance.DashboardsGet(name, search, sortBy, order, max, offset, grantedAccess, publicAccess, operation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Only return dashboards that exactly match the given name. | [optional] 
 **search** | **string**| Filter by search term in name or description | [optional] 
 **sortBy** | **string**| Sort the returned results by the given field. | [optional] [default to id]
 **order** | **string**| Control whether the results are sorted in ascending or descending order. Used with parameter &#x60;sortBy&#x60;. | [optional] [default to asc]
 **max** | **int?**| Maximum number of returned results (capped at 100) | [optional] [default to 100]
 **offset** | **int?**| Skip the first (offset) results. Used together with max for paging. | [optional] [default to 0]
 **grantedAccess** | **bool?**| If false, excludes resources that user has been granted specific permission to from results. | [optional] [default to true]
 **publicAccess** | **bool?**| If true, includes publicly available resources in the results. | [optional] [default to false]
 **operation** | **string**| Filter results by Permission (access level) | [optional] [default to dashboard_get]

### Return type

[**List<DashboardSummary>**](DashboardSummary.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsiddelete"></a>
# **DashboardsIdDelete**
> void DashboardsIdDelete (string id)

Delete a Dashboard

Deletes a Dashboard by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var id = id_example;  // string | ID of the Dashboard to be deleted

            try
            {
                // Delete a Dashboard
                apiInstance.DashboardsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the Dashboard to be deleted | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsidget"></a>
# **DashboardsIdGet**
> Dashboard DashboardsIdGet (string id)

Get Dashboard

Get Dashboard by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var id = id_example;  // string | ID of the Dashboard to be fetched

            try
            {
                // Get Dashboard
                Dashboard result = apiInstance.DashboardsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the Dashboard to be fetched | 

### Return type

[**Dashboard**](Dashboard.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsiditemsget"></a>
# **DashboardsIdItemsGet**
> List<DashboardItem> DashboardsIdItemsGet (string id)

List Items of Dashboard

Get Items of Dashboard by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsIdItemsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var id = id_example;  // string | ID of the Dashboard whose Items are to be fetched

            try
            {
                // List Items of Dashboard
                List&lt;DashboardItem&gt; result = apiInstance.DashboardsIdItemsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsIdItemsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the Dashboard whose Items are to be fetched | 

### Return type

[**List<DashboardItem>**](DashboardItem.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsiditemspost"></a>
# **DashboardsIdItemsPost**
> DashboardItem DashboardsIdItemsPost (string id, SaveDashboardItemRequest body)

Create a new Dashboard Item

Creates a new Dashboard Item associated with a Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsIdItemsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var id = id_example;  // string | ID of the associated Dashboard
            var body = new SaveDashboardItemRequest(); // SaveDashboardItemRequest | Dashboard Item

            try
            {
                // Create a new Dashboard Item
                DashboardItem result = apiInstance.DashboardsIdItemsPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsIdItemsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the associated Dashboard | 
 **body** | [**SaveDashboardItemRequest**](SaveDashboardItemRequest.md)| Dashboard Item | 

### Return type

[**DashboardItem**](DashboardItem.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardsidput"></a>
# **DashboardsIdPut**
> Dashboard DashboardsIdPut (string id, DashboardSaveRequest body)

Update a Dashboard

Updates an existing Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var id = id_example;  // string | ID of the Dashboard to be updated
            var body = new DashboardSaveRequest(); // DashboardSaveRequest | New Dashboard details

            try
            {
                // Update a Dashboard
                Dashboard result = apiInstance.DashboardsIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the Dashboard to be updated | 
 **body** | [**DashboardSaveRequest**](DashboardSaveRequest.md)| New Dashboard details | 

### Return type

[**Dashboard**](Dashboard.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dashboardspost"></a>
# **DashboardsPost**
> Dashboard DashboardsPost (DashboardSaveRequest body)

Create a Dashboard

Creates a new empty Dashboard.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DashboardsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi();
            var body = new DashboardSaveRequest(); // DashboardSaveRequest | Dashboard object

            try
            {
                // Create a Dashboard
                Dashboard result = apiInstance.DashboardsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DashboardsApi.DashboardsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DashboardSaveRequest**](DashboardSaveRequest.md)| Dashboard object | 

### Return type

[**Dashboard**](Dashboard.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

