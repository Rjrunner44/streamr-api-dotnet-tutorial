# IO.Swagger.Api.ModulesApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ModuleCategoriesGet**](ModulesApi.md#modulecategoriesget) | **GET** /module_categories | Get list of module categories and the modules within them
[**ModulesIdGet**](ModulesApi.md#modulesidget) | **GET** /modules/{id} | Get module configuration by id
[**ModulesIdPost**](ModulesApi.md#modulesidpost) | **POST** /modules/{id} | Get module configuration by id


<a name="modulecategoriesget"></a>
# **ModuleCategoriesGet**
> void ModuleCategoriesGet (bool? modulesFirst = null)

Get list of module categories and the modules within them

Get list of module categories and the modules within them

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModuleCategoriesGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModulesApi();
            var modulesFirst = true;  // bool? | Order list of children by modules first (optional)  (default to false)

            try
            {
                // Get list of module categories and the modules within them
                apiInstance.ModuleCategoriesGet(modulesFirst);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModulesApi.ModuleCategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modulesFirst** | **bool?**| Order list of children by modules first | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modulesidget"></a>
# **ModulesIdGet**
> Module ModulesIdGet (int? id)

Get module configuration by id

Instantiate a fresh module by id and get its configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModulesIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModulesApi();
            var id = 56;  // int? | ID of the module

            try
            {
                // Get module configuration by id
                Module result = apiInstance.ModulesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModulesApi.ModulesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the module | 

### Return type

[**Module**](Module.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modulesidpost"></a>
# **ModulesIdPost**
> Module ModulesIdPost (string id, Module body = null)

Get module configuration by id

Instantiate a module (with pre-existing config) by id and get its configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModulesIdPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModulesApi();
            var id = id_example;  // string | ID of the module
            var body = new Module(); // Module | Module object (optional) 

            try
            {
                // Get module configuration by id
                Module result = apiInstance.ModulesIdPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModulesApi.ModulesIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the module | 
 **body** | [**Module**](Module.md)| Module object | [optional] 

### Return type

[**Module**](Module.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

