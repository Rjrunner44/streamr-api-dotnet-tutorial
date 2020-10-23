# IO.Swagger.Api.CanvasesApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CanvasesDownloadCsvGet**](CanvasesApi.md#canvasesdownloadcsvget) | **GET** /canvases/downloadCsv | Download CSV file
[**CanvasesGet**](CanvasesApi.md#canvasesget) | **GET** /canvases | List canvases
[**CanvasesIdDelete**](CanvasesApi.md#canvasesiddelete) | **DELETE** /canvases/{id} | Delete a canvas
[**CanvasesIdGet**](CanvasesApi.md#canvasesidget) | **GET** /canvases/{id} | Get canvas by id
[**CanvasesIdPermissionsGet**](CanvasesApi.md#canvasesidpermissionsget) | **GET** /canvases/{id}/permissions | List permissions
[**CanvasesIdPermissionsPidDelete**](CanvasesApi.md#canvasesidpermissionspiddelete) | **DELETE** /canvases/{id}/permissions/{pid} | Delete a canvas permission
[**CanvasesIdPermissionsPidGet**](CanvasesApi.md#canvasesidpermissionspidget) | **GET** /canvases/{id}/permissions/{pid} | Get single permission object
[**CanvasesIdPermissionsPost**](CanvasesApi.md#canvasesidpermissionspost) | **POST** /canvases/{id}/permissions | Grant permission
[**CanvasesIdPut**](CanvasesApi.md#canvasesidput) | **PUT** /canvases/{id} | Update a canvas.
[**CanvasesIdStartPost**](CanvasesApi.md#canvasesidstartpost) | **POST** /canvases/{id}/start | Starts a canvas
[**CanvasesIdStopPost**](CanvasesApi.md#canvasesidstoppost) | **POST** /canvases/{id}/stop | Stop a currently running canvas.
[**CanvasesPost**](CanvasesApi.md#canvasespost) | **POST** /canvases | Create a canvas


<a name="canvasesdownloadcsvget"></a>
# **CanvasesDownloadCsvGet**
> System.IO.Stream CanvasesDownloadCsvGet (string filename)

Download CSV file

Prompts browser to open save file dialog and downloads CSV file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesDownloadCsvGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var filename = filename_example;  // string | Name of the file to download

            try
            {
                // Download CSV file
                System.IO.Stream result = apiInstance.CanvasesDownloadCsvGet(filename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesDownloadCsvGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| Name of the file to download | 

### Return type

**System.IO.Stream**

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesget"></a>
# **CanvasesGet**
> List<Canvas> CanvasesGet (string name = null, string state = null, bool? adhoc = null, string search = null, string sortBy = null, string order = null, int? max = null, int? offset = null, bool? grantedAccess = null, bool? publicAccess = null, string operation = null)

List canvases

Lists (and optionally filters) canvases in your archive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var name = name_example;  // string | Filter results by canvas name. (optional) 
            var state = state_example;  // string | Filter results by canvas state. (optional) 
            var adhoc = true;  // bool? | Filter canvases by their adhoc-ness. Set to false to get the typical list of canvases as seen in the UI. (optional)  (default to false)
            var search = search_example;  // string | Filter by search term in name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort the returned results by the given field. (optional)  (default to id)
            var order = order_example;  // string | Control whether the results are sorted in ascending or descending order. Used with parameter `sortBy`. (optional)  (default to asc)
            var max = 56;  // int? | Maximum number of returned results (capped at 100) (optional)  (default to 100)
            var offset = 56;  // int? | Skip the first (offset) results. Used together with max for paging. (optional)  (default to 0)
            var grantedAccess = true;  // bool? | If false, excludes resources that user has been granted specific permission to from results. (optional)  (default to true)
            var publicAccess = true;  // bool? | If true, includes publicly available resources in the results. (optional)  (default to false)
            var operation = operation_example;  // string | Filter results by Permission (access level) (optional)  (default to canvas_get)

            try
            {
                // List canvases
                List&lt;Canvas&gt; result = apiInstance.CanvasesGet(name, state, adhoc, search, sortBy, order, max, offset, grantedAccess, publicAccess, operation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filter results by canvas name. | [optional] 
 **state** | **string**| Filter results by canvas state. | [optional] 
 **adhoc** | **bool?**| Filter canvases by their adhoc-ness. Set to false to get the typical list of canvases as seen in the UI. | [optional] [default to false]
 **search** | **string**| Filter by search term in name or description | [optional] 
 **sortBy** | **string**| Sort the returned results by the given field. | [optional] [default to id]
 **order** | **string**| Control whether the results are sorted in ascending or descending order. Used with parameter &#x60;sortBy&#x60;. | [optional] [default to asc]
 **max** | **int?**| Maximum number of returned results (capped at 100) | [optional] [default to 100]
 **offset** | **int?**| Skip the first (offset) results. Used together with max for paging. | [optional] [default to 0]
 **grantedAccess** | **bool?**| If false, excludes resources that user has been granted specific permission to from results. | [optional] [default to true]
 **publicAccess** | **bool?**| If true, includes publicly available resources in the results. | [optional] [default to false]
 **operation** | **string**| Filter results by Permission (access level) | [optional] [default to canvas_get]

### Return type

[**List<Canvas>**](Canvas.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesiddelete"></a>
# **CanvasesIdDelete**
> void CanvasesIdDelete (string id)

Delete a canvas

Deletes a canvas by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas to be deleted

            try
            {
                // Delete a canvas
                apiInstance.CanvasesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas to be deleted | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidget"></a>
# **CanvasesIdGet**
> Canvas CanvasesIdGet (string id)

Get canvas by id

Returns a canvas by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas to be fetched

            try
            {
                // Get canvas by id
                Canvas result = apiInstance.CanvasesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas to be fetched | 

### Return type

[**Canvas**](Canvas.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidpermissionsget"></a>
# **CanvasesIdPermissionsGet**
> List<Permission> CanvasesIdPermissionsGet (string id)

List permissions

Lists the permissions to given canvas.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdPermissionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas

            try
            {
                // List permissions
                List&lt;Permission&gt; result = apiInstance.CanvasesIdPermissionsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdPermissionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas | 

### Return type

[**List<Permission>**](Permission.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidpermissionspiddelete"></a>
# **CanvasesIdPermissionsPidDelete**
> void CanvasesIdPermissionsPidDelete (string id, int? pid)

Delete a canvas permission

Deletes a canvas permission by id.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdPermissionsPidDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas
            var pid = 56;  // int? | ID of the permission to be deleted

            try
            {
                // Delete a canvas permission
                apiInstance.CanvasesIdPermissionsPidDelete(id, pid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdPermissionsPidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas | 
 **pid** | **int?**| ID of the permission to be deleted | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidpermissionspidget"></a>
# **CanvasesIdPermissionsPidGet**
> Permission CanvasesIdPermissionsPidGet (string id, int? pid)

Get single permission object

Returns one canvas-user-operation relationship object by its unique id.   Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdPermissionsPidGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas
            var pid = 56;  // int? | ID of the permission to be fetched

            try
            {
                // Get single permission object
                Permission result = apiInstance.CanvasesIdPermissionsPidGet(id, pid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdPermissionsPidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas | 
 **pid** | **int?**| ID of the permission to be fetched | 

### Return type

[**Permission**](Permission.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidpermissionspost"></a>
# **CanvasesIdPermissionsPost**
> Permission CanvasesIdPermissionsPost (string id, Permission body)

Grant permission

Grant a new permission to given canvas.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdPermissionsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas
            var body = new Permission(); // Permission | Requested permission (id ignored)

            try
            {
                // Grant permission
                Permission result = apiInstance.CanvasesIdPermissionsPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdPermissionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas | 
 **body** | [**Permission**](Permission.md)| Requested permission (id ignored) | 

### Return type

[**Permission**](Permission.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidput"></a>
# **CanvasesIdPut**
> void CanvasesIdPut (string id, CanvasCreateRequest body)

Update a canvas.

Updates a canvas. The *id* field can not be updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the canvas to be updated
            var body = new CanvasCreateRequest(); // CanvasCreateRequest | New canvas details

            try
            {
                // Update a canvas.
                apiInstance.CanvasesIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the canvas to be updated | 
 **body** | [**CanvasCreateRequest**](CanvasCreateRequest.md)| New canvas details | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidstartpost"></a>
# **CanvasesIdStartPost**
> Canvas CanvasesIdStartPost (string id, StartRequest body)

Starts a canvas

Starts a canvas changing its state to 'running', or in the case of adhoc=true, creates a copy of the Canvas with state 'running'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdStartPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the live canvas to be started
            var body = new StartRequest(); // StartRequest | runtime options

            try
            {
                // Starts a canvas
                Canvas result = apiInstance.CanvasesIdStartPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdStartPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the live canvas to be started | 
 **body** | [**StartRequest**](StartRequest.md)| runtime options | 

### Return type

[**Canvas**](Canvas.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasesidstoppost"></a>
# **CanvasesIdStopPost**
> Canvas CanvasesIdStopPost (string id)

Stop a currently running canvas.

Stops a canvas that is currently running.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesIdStopPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var id = id_example;  // string | ID of the live canvas to be stopped

            try
            {
                // Stop a currently running canvas.
                Canvas result = apiInstance.CanvasesIdStopPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesIdStopPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the live canvas to be stopped | 

### Return type

[**Canvas**](Canvas.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canvasespost"></a>
# **CanvasesPost**
> Canvas CanvasesPost (CanvasCreateRequest body)

Create a canvas

Creates a new canvas into your archive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CanvasesPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CanvasesApi();
            var body = new CanvasCreateRequest(); // CanvasCreateRequest | Canvas object

            try
            {
                // Create a canvas
                Canvas result = apiInstance.CanvasesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CanvasesApi.CanvasesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CanvasCreateRequest**](CanvasCreateRequest.md)| Canvas object | 

### Return type

[**Canvas**](Canvas.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

