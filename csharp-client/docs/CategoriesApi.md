# IO.Swagger.Api.CategoriesApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CategoriesGet**](CategoriesApi.md#categoriesget) | **GET** /categories | List categories


<a name="categoriesget"></a>
# **CategoriesGet**
> List<Category> CategoriesGet ()

List categories

Lists all categories in alphabetical order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesGetExample
    {
        public void main()
        {
            var apiInstance = new CategoriesApi();

            try
            {
                // List categories
                List&lt;Category&gt; result = apiInstance.CategoriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Category>**](Category.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

