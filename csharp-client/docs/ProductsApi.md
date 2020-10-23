# IO.Swagger.Api.ProductsApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductsGet**](ProductsApi.md#productsget) | **GET** /products | List products
[**ProductsIdDeployFreePost**](ProductsApi.md#productsiddeployfreepost) | **POST** /products/{id}/deployFree | Deploy free Product
[**ProductsIdGet**](ProductsApi.md#productsidget) | **GET** /products/{id} | Get a Product
[**ProductsIdImagesPost**](ProductsApi.md#productsidimagespost) | **POST** /products/{id}/images | Attach image to Product
[**ProductsIdPut**](ProductsApi.md#productsidput) | **PUT** /products/{id} | Update a Product
[**ProductsIdSetDeployedPost**](ProductsApi.md#productsidsetdeployedpost) | **POST** /products/{id}/setDeployed | Transition Product to state DEPLOYED
[**ProductsIdSetDeployingPost**](ProductsApi.md#productsidsetdeployingpost) | **POST** /products/{id}/setDeploying | Transition Product to state DEPLOYING
[**ProductsIdSetPricingPost**](ProductsApi.md#productsidsetpricingpost) | **POST** /products/{id}/setPricing | Update Product pricing data
[**ProductsIdSetUndeployedPost**](ProductsApi.md#productsidsetundeployedpost) | **POST** /products/{id}/setUndeployed | Transition Product to state NOT_DEPLOYED
[**ProductsIdSetUndeployingPost**](ProductsApi.md#productsidsetundeployingpost) | **POST** /products/{id}/setUndeploying | Transition Product to state UNDEPLOYING
[**ProductsIdStreamsGet**](ProductsApi.md#productsidstreamsget) | **GET** /products/{id}/streams | Get Streams of Product
[**ProductsIdStreamsStreamIdDelete**](ProductsApi.md#productsidstreamsstreamiddelete) | **DELETE** /products/{id}/streams/{streamId} | Remove Stream from Product
[**ProductsIdStreamsStreamIdPut**](ProductsApi.md#productsidstreamsstreamidput) | **PUT** /products/{id}/streams/{streamId} | Add Stream to Product
[**ProductsIdUndeployFreePost**](ProductsApi.md#productsidundeployfreepost) | **POST** /products/{id}/undeployFree | Undeploy free Product
[**ProductsPost**](ProductsApi.md#productspost) | **POST** /products | Create a Product
[**ProductsRemoveUsernameDelete**](ProductsApi.md#productsremoveusernamedelete) | **DELETE** /products/remove/{username} | Remove troll users products
[**UsersMeProductsGet**](ProductsApi.md#usersmeproductsget) | **GET** /users/me/products | List my products


<a name="productsget"></a>
# **ProductsGet**
> List<Product> ProductsGet (string search = null, string sortBy = null, string order = null, int? max = null, int? offset = null, bool? grantedAccess = null, bool? publicAccess = null, string operation = null, string categories = null, string states = null, decimal? minPrice = null, decimal? maxPrice = null)

List products

Lists products according to provided parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var search = search_example;  // string | Filter by search term in name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort the returned results by the given field. (optional)  (default to id)
            var order = order_example;  // string | Control whether the results are sorted in ascending or descending order. Used with parameter `sortBy`. (optional)  (default to asc)
            var max = 56;  // int? | Maximum number of returned results (capped at 100) (optional)  (default to 100)
            var offset = 56;  // int? | Skip the first (offset) results. Used together with max for paging. (optional)  (default to 0)
            var grantedAccess = true;  // bool? | If false, excludes resources that user has been granted specific permission to from results. (optional)  (default to true)
            var publicAccess = true;  // bool? | If true, includes publicly available resources in the results. (optional)  (default to false)
            var operation = operation_example;  // string | Filter results by Permission (access level) (optional)  (default to product_get)
            var categories = categories_example;  // string | Filter products by category id(s) (optional) 
            var states = states_example;  // string | Filter products by state(s) (optional) 
            var minPrice = 8.14;  // decimal? | Minimum price (per second) of product (optional) 
            var maxPrice = 8.14;  // decimal? | Maximum price (per second) of product (optional) 

            try
            {
                // List products
                List&lt;Product&gt; result = apiInstance.ProductsGet(search, sortBy, order, max, offset, grantedAccess, publicAccess, operation, categories, states, minPrice, maxPrice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Filter by search term in name or description | [optional] 
 **sortBy** | **string**| Sort the returned results by the given field. | [optional] [default to id]
 **order** | **string**| Control whether the results are sorted in ascending or descending order. Used with parameter &#x60;sortBy&#x60;. | [optional] [default to asc]
 **max** | **int?**| Maximum number of returned results (capped at 100) | [optional] [default to 100]
 **offset** | **int?**| Skip the first (offset) results. Used together with max for paging. | [optional] [default to 0]
 **grantedAccess** | **bool?**| If false, excludes resources that user has been granted specific permission to from results. | [optional] [default to true]
 **publicAccess** | **bool?**| If true, includes publicly available resources in the results. | [optional] [default to false]
 **operation** | **string**| Filter results by Permission (access level) | [optional] [default to product_get]
 **categories** | **string**| Filter products by category id(s) | [optional] 
 **states** | **string**| Filter products by state(s) | [optional] 
 **minPrice** | **decimal?**| Minimum price (per second) of product | [optional] 
 **maxPrice** | **decimal?**| Maximum price (per second) of product | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsiddeployfreepost"></a>
# **ProductsIdDeployFreePost**
> Product ProductsIdDeployFreePost (string id)

Deploy free Product

Deploy a free Product (price = 0) so that it is publicly viewable and purchasable. Its streams are made public as well.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdDeployFreePostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product

            try
            {
                // Deploy free Product
                Product result = apiInstance.ProductsIdDeployFreePost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdDeployFreePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidget"></a>
# **ProductsIdGet**
> Product ProductsIdGet (string id)

Get a Product

Get a Product by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product

            try
            {
                // Get a Product
                Product result = apiInstance.ProductsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidimagespost"></a>
# **ProductsIdImagesPost**
> Product ProductsIdImagesPost (string id, System.IO.Stream _file = null)

Attach image to Product

Upload and attach an image to a Product. Supported formats: JPG or PNG.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdImagesPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var _file = new System.IO.Stream(); // System.IO.Stream | Image file. JPG or PNG. (optional) 

            try
            {
                // Attach image to Product
                Product result = apiInstance.ProductsIdImagesPost(id, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **_file** | **System.IO.Stream**| Image file. JPG or PNG. | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidput"></a>
# **ProductsIdPut**
> Product ProductsIdPut (string id, UpdateProduct body)

Update a Product

Updates the non-Blockchain information of a *deployed* Product. Updates the non-Blockchain and Blockchain information of a *undeployed* and *paid* Product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var body = new UpdateProduct(); // UpdateProduct | Updated Product. When performing on a paid Product with state `DEPLOYED` or a free Product, can leave out fields `ownerAddress`, `beneficiaryAddress`, `pricePerSecond`, `priceCurrency`, and `minimumSubscriptionInSeconds` since they are ignored anyway.

            try
            {
                // Update a Product
                Product result = apiInstance.ProductsIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **body** | [**UpdateProduct**](UpdateProduct.md)| Updated Product. When performing on a paid Product with state &#x60;DEPLOYED&#x60; or a free Product, can leave out fields &#x60;ownerAddress&#x60;, &#x60;beneficiaryAddress&#x60;, &#x60;pricePerSecond&#x60;, &#x60;priceCurrency&#x60;, and &#x60;minimumSubscriptionInSeconds&#x60; since they are ignored anyway. | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidsetdeployedpost"></a>
# **ProductsIdSetDeployedPost**
> Product ProductsIdSetDeployedPost (string id, DeployedProduct body)

Transition Product to state DEPLOYED

Idempotent operation that informs engine-and-editor that a Product has moved from state `NOT_DEPLOYED` / `DEPLOYING` to `DEPLOYED`. Called by *Marketplace Watcher* after it notices that a Product has been added to the marketplace smart contract. Also updates Blockchain-specific information of the Product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdSetDeployedPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var body = new DeployedProduct(); // DeployedProduct | Deployed product and transaction block number information

            try
            {
                // Transition Product to state DEPLOYED
                Product result = apiInstance.ProductsIdSetDeployedPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdSetDeployedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **body** | [**DeployedProduct**](DeployedProduct.md)| Deployed product and transaction block number information | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidsetdeployingpost"></a>
# **ProductsIdSetDeployingPost**
> Product ProductsIdSetDeployingPost (string id)

Transition Product to state DEPLOYING

Inform engine-and-editor that a Product has moved from state `NOT_DEPLOYED` to `DEPLOYING`. Should be called after transaction to submit product to marketplace has been sent to Ethereum.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdSetDeployingPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product

            try
            {
                // Transition Product to state DEPLOYING
                Product result = apiInstance.ProductsIdSetDeployingPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdSetDeployingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidsetpricingpost"></a>
# **ProductsIdSetPricingPost**
> Product ProductsIdSetPricingPost (string id, DeployedProduct body)

Update Product pricing data

Idempotent operation that sets Product's pricing details (basically stuff held in smart contract).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdSetPricingPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var body = new DeployedProduct(); // DeployedProduct | Updated product info and transaction block number

            try
            {
                // Update Product pricing data
                Product result = apiInstance.ProductsIdSetPricingPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdSetPricingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **body** | [**DeployedProduct**](DeployedProduct.md)| Updated product info and transaction block number | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidsetundeployedpost"></a>
# **ProductsIdSetUndeployedPost**
> Product ProductsIdSetUndeployedPost (string id, UndeployedProduct body)

Transition Product to state NOT_DEPLOYED

Idempotent operation that informs engine-and-editor that a Product has moved from state `DEPLOYED` / `UNDEPLOYING` to `NOT_DEPLOYED`. Called by *Marketplace Watcher* after it notices that a Product has been removed from the marketplace contract.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdSetUndeployedPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var body = new UndeployedProduct(); // UndeployedProduct | Transaction block number information

            try
            {
                // Transition Product to state NOT_DEPLOYED
                Product result = apiInstance.ProductsIdSetUndeployedPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdSetUndeployedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **body** | [**UndeployedProduct**](UndeployedProduct.md)| Transaction block number information | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidsetundeployingpost"></a>
# **ProductsIdSetUndeployingPost**
> Product ProductsIdSetUndeployingPost (string id)

Transition Product to state UNDEPLOYING

Inform engine-and-editor that a Product has moved from state `DEPLOYED` to `UNDEPLOYING`. Should be called after transaction to remove product from marketplace has been sent to Ethereum.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdSetUndeployingPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product

            try
            {
                // Transition Product to state UNDEPLOYING
                Product result = apiInstance.ProductsIdSetUndeployingPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdSetUndeployingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidstreamsget"></a>
# **ProductsIdStreamsGet**
> List<Stream> ProductsIdStreamsGet (string id)

Get Streams of Product

Get all the Streams of a Product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdStreamsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product

            try
            {
                // Get Streams of Product
                List&lt;Stream&gt; result = apiInstance.ProductsIdStreamsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdStreamsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 

### Return type

[**List<Stream>**](Stream.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidstreamsstreamiddelete"></a>
# **ProductsIdStreamsStreamIdDelete**
> void ProductsIdStreamsStreamIdDelete (string id, string streamId)

Remove Stream from Product

Remove a Stream from a Product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdStreamsStreamIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var streamId = streamId_example;  // string | unique identifier of a Stream

            try
            {
                // Remove Stream from Product
                apiInstance.ProductsIdStreamsStreamIdDelete(id, streamId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdStreamsStreamIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **streamId** | **string**| unique identifier of a Stream | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidstreamsstreamidput"></a>
# **ProductsIdStreamsStreamIdPut**
> void ProductsIdStreamsStreamIdPut (string id, string streamId)

Add Stream to Product

Add a Stream to a Product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdStreamsStreamIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product
            var streamId = streamId_example;  // string | unique identifier of a Stream

            try
            {
                // Add Stream to Product
                apiInstance.ProductsIdStreamsStreamIdPut(id, streamId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdStreamsStreamIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 
 **streamId** | **string**| unique identifier of a Stream | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsidundeployfreepost"></a>
# **ProductsIdUndeployFreePost**
> Product ProductsIdUndeployFreePost (string id)

Undeploy free Product

Undeploy a free Product (price = 0) so that it is no longer publicly viewable or purchasable. Its streams will be made private as well.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsIdUndeployFreePostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = id_example;  // string | unique identifier of a Product

            try
            {
                // Undeploy free Product
                Product result = apiInstance.ProductsIdUndeployFreePost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdUndeployFreePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| unique identifier of a Product | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productspost"></a>
# **ProductsPost**
> Product ProductsPost (CreateProduct body)

Create a Product

Creates a new Product with state `NOT_DEPLOYED`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var body = new CreateProduct(); // CreateProduct | Product object

            try
            {
                // Create a Product
                Product result = apiInstance.ProductsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateProduct**](CreateProduct.md)| Product object | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsremoveusernamedelete"></a>
# **ProductsRemoveUsernameDelete**
> Product ProductsRemoveUsernameDelete (string username)

Remove troll users products

Removes users all products. Undo is not supported. Admin role is required.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsRemoveUsernameDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var username = username_example;  // string | Username of the product owner

            try
            {
                // Remove troll users products
                Product result = apiInstance.ProductsRemoveUsernameDelete(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsRemoveUsernameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username of the product owner | 

### Return type

[**Product**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmeproductsget"></a>
# **UsersMeProductsGet**
> List<Product> UsersMeProductsGet (string search = null, string sortBy = null, string order = null, int? max = null, int? offset = null, bool? grantedAccess = null, bool? publicAccess = null, string categories = null, string states = null, decimal? minPrice = null, decimal? maxPrice = null)

List my products

Lists products that current user has product_share permission on

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeProductsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var search = search_example;  // string | Filter by search term in name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort the returned results by the given field. (optional)  (default to id)
            var order = order_example;  // string | Control whether the results are sorted in ascending or descending order. Used with parameter `sortBy`. (optional)  (default to asc)
            var max = 56;  // int? | Maximum number of returned results (capped at 100) (optional)  (default to 100)
            var offset = 56;  // int? | Skip the first (offset) results. Used together with max for paging. (optional)  (default to 0)
            var grantedAccess = true;  // bool? | If false, excludes resources that user has been granted specific permission to from results. (optional)  (default to true)
            var publicAccess = true;  // bool? | If true, includes publicly available resources in the results. (optional)  (default to false)
            var categories = categories_example;  // string | Filter products by category id(s) (optional) 
            var states = states_example;  // string | Filter products by state(s) (optional) 
            var minPrice = 8.14;  // decimal? | Minimum price (per second) of product (optional) 
            var maxPrice = 8.14;  // decimal? | Maximum price (per second) of product (optional) 

            try
            {
                // List my products
                List&lt;Product&gt; result = apiInstance.UsersMeProductsGet(search, sortBy, order, max, offset, grantedAccess, publicAccess, categories, states, minPrice, maxPrice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UsersMeProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Filter by search term in name or description | [optional] 
 **sortBy** | **string**| Sort the returned results by the given field. | [optional] [default to id]
 **order** | **string**| Control whether the results are sorted in ascending or descending order. Used with parameter &#x60;sortBy&#x60;. | [optional] [default to asc]
 **max** | **int?**| Maximum number of returned results (capped at 100) | [optional] [default to 100]
 **offset** | **int?**| Skip the first (offset) results. Used together with max for paging. | [optional] [default to 0]
 **grantedAccess** | **bool?**| If false, excludes resources that user has been granted specific permission to from results. | [optional] [default to true]
 **publicAccess** | **bool?**| If true, includes publicly available resources in the results. | [optional] [default to false]
 **categories** | **string**| Filter products by category id(s) | [optional] 
 **states** | **string**| Filter products by state(s) | [optional] 
 **minPrice** | **decimal?**| Minimum price (per second) of product | [optional] 
 **maxPrice** | **decimal?**| Maximum price (per second) of product | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

