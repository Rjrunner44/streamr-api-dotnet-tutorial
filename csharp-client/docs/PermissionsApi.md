# IO.Swagger.Api.PermissionsApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CanvasesIdPermissionsGet**](PermissionsApi.md#canvasesidpermissionsget) | **GET** /canvases/{id}/permissions | List permissions
[**CanvasesIdPermissionsPidDelete**](PermissionsApi.md#canvasesidpermissionspiddelete) | **DELETE** /canvases/{id}/permissions/{pid} | Delete a canvas permission
[**CanvasesIdPermissionsPidGet**](PermissionsApi.md#canvasesidpermissionspidget) | **GET** /canvases/{id}/permissions/{pid} | Get single permission object
[**CanvasesIdPermissionsPost**](PermissionsApi.md#canvasesidpermissionspost) | **POST** /canvases/{id}/permissions | Grant permission
[**StreamsIdPermissionsGet**](PermissionsApi.md#streamsidpermissionsget) | **GET** /streams/{id}/permissions | List permissions
[**StreamsIdPermissionsPidDelete**](PermissionsApi.md#streamsidpermissionspiddelete) | **DELETE** /streams/{id}/permissions/{pid} | Delete a stream permission
[**StreamsIdPermissionsPidGet**](PermissionsApi.md#streamsidpermissionspidget) | **GET** /streams/{id}/permissions/{pid} | Get single permission object
[**StreamsIdPermissionsPost**](PermissionsApi.md#streamsidpermissionspost) | **POST** /streams/{id}/permissions | Grant permission


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

            var apiInstance = new PermissionsApi();
            var id = id_example;  // string | ID of the canvas

            try
            {
                // List permissions
                List&lt;Permission&gt; result = apiInstance.CanvasesIdPermissionsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.CanvasesIdPermissionsGet: " + e.Message );
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

            var apiInstance = new PermissionsApi();
            var id = id_example;  // string | ID of the canvas
            var pid = 56;  // int? | ID of the permission to be deleted

            try
            {
                // Delete a canvas permission
                apiInstance.CanvasesIdPermissionsPidDelete(id, pid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.CanvasesIdPermissionsPidDelete: " + e.Message );
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

            var apiInstance = new PermissionsApi();
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
                Debug.Print("Exception when calling PermissionsApi.CanvasesIdPermissionsPidGet: " + e.Message );
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

            var apiInstance = new PermissionsApi();
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
                Debug.Print("Exception when calling PermissionsApi.CanvasesIdPermissionsPost: " + e.Message );
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

<a name="streamsidpermissionsget"></a>
# **StreamsIdPermissionsGet**
> List<Permission> StreamsIdPermissionsGet (string id)

List permissions

Lists the permissions to given stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdPermissionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PermissionsApi();
            var id = id_example;  // string | ID of the stream

            try
            {
                // List permissions
                List&lt;Permission&gt; result = apiInstance.StreamsIdPermissionsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.StreamsIdPermissionsGet: " + e.Message );
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

[**List<Permission>**](Permission.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidpermissionspiddelete"></a>
# **StreamsIdPermissionsPidDelete**
> void StreamsIdPermissionsPidDelete (string id, int? pid)

Delete a stream permission

Deletes a stream permission by id.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdPermissionsPidDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PermissionsApi();
            var id = id_example;  // string | ID of the stream
            var pid = 56;  // int? | ID of the permission to be deleted

            try
            {
                // Delete a stream permission
                apiInstance.StreamsIdPermissionsPidDelete(id, pid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.StreamsIdPermissionsPidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **pid** | **int?**| ID of the permission to be deleted | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidpermissionspidget"></a>
# **StreamsIdPermissionsPidGet**
> Permission StreamsIdPermissionsPidGet (string id, int? pid)

Get single permission object

Returns one stream-user-operation relationship object by its unique id.   Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdPermissionsPidGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PermissionsApi();
            var id = id_example;  // string | ID of the stream
            var pid = 56;  // int? | ID of the permission to be fetched

            try
            {
                // Get single permission object
                Permission result = apiInstance.StreamsIdPermissionsPidGet(id, pid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.StreamsIdPermissionsPidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **pid** | **int?**| ID of the permission to be fetched | 

### Return type

[**Permission**](Permission.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidpermissionspost"></a>
# **StreamsIdPermissionsPost**
> Permission StreamsIdPermissionsPost (string id, Permission body)

Grant permission

Grant a new permission to given stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdPermissionsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PermissionsApi();
            var id = id_example;  // string | ID of the stream
            var body = new Permission(); // Permission | Requested permission (id ignored)

            try
            {
                // Grant permission
                Permission result = apiInstance.StreamsIdPermissionsPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.StreamsIdPermissionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **body** | [**Permission**](Permission.md)| Requested permission (id ignored) | 

### Return type

[**Permission**](Permission.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

