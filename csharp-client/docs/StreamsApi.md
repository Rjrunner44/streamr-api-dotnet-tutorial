# IO.Swagger.Api.StreamsApi

All URIs are relative to *https://www.streamr.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StreamsGet**](StreamsApi.md#streamsget) | **GET** /streams | List streams
[**StreamsIdDataPartitionsPartitionFromGet**](StreamsApi.md#streamsiddatapartitionspartitionfromget) | **GET** /streams/{id}/data/partitions/{partition}/from | Get events from a timestamp or reference from the stream
[**StreamsIdDataPartitionsPartitionLastGet**](StreamsApi.md#streamsiddatapartitionspartitionlastget) | **GET** /streams/{id}/data/partitions/{partition}/last | Get most recent events from a stream
[**StreamsIdDataPartitionsPartitionRangeGet**](StreamsApi.md#streamsiddatapartitionspartitionrangeget) | **GET** /streams/{id}/data/partitions/{partition}/range | Get events between a range from the stream
[**StreamsIdDataPost**](StreamsApi.md#streamsiddatapost) | **POST** /streams/{id}/data | Add new event to stream
[**StreamsIdDelete**](StreamsApi.md#streamsiddelete) | **DELETE** /streams/{id} | Delete a stream
[**StreamsIdDetectFieldsGet**](StreamsApi.md#streamsiddetectfieldsget) | **GET** /streams/{id}/detectFields | Detect stream&#39;s field types.
[**StreamsIdDetectFieldsPost**](StreamsApi.md#streamsiddetectfieldspost) | **POST** /streams/{id}/detectFields | Detect stream&#39;s field types.
[**StreamsIdGet**](StreamsApi.md#streamsidget) | **GET** /streams/{id} | Get stream by id
[**StreamsIdKeysGet**](StreamsApi.md#streamsidkeysget) | **GET** /streams/{id}/keys | List keys
[**StreamsIdKeysPost**](StreamsApi.md#streamsidkeyspost) | **POST** /streams/{id}/keys | Create a key
[**StreamsIdPermissionsGet**](StreamsApi.md#streamsidpermissionsget) | **GET** /streams/{id}/permissions | List permissions
[**StreamsIdPermissionsPidDelete**](StreamsApi.md#streamsidpermissionspiddelete) | **DELETE** /streams/{id}/permissions/{pid} | Delete a stream permission
[**StreamsIdPermissionsPidGet**](StreamsApi.md#streamsidpermissionspidget) | **GET** /streams/{id}/permissions/{pid} | Get single permission object
[**StreamsIdPermissionsPost**](StreamsApi.md#streamsidpermissionspost) | **POST** /streams/{id}/permissions | Grant permission
[**StreamsIdPut**](StreamsApi.md#streamsidput) | **PUT** /streams/{id} | Update a stream
[**StreamsPost**](StreamsApi.md#streamspost) | **POST** /streams | Create a new stream
[**StreamsStreamIdKeysIdDelete**](StreamsApi.md#streamsstreamidkeysiddelete) | **DELETE** /streams/{streamId}/keys/{id} | Delete a key
[**StreamsStreamIdKeysIdPut**](StreamsApi.md#streamsstreamidkeysidput) | **PUT** /streams/{streamId}/keys/{id} | Update Stream&#39;s Key&#39;s name and permission
[**UsersMeKeysIdDelete**](StreamsApi.md#usersmekeysiddelete) | **DELETE** /users/me/keys/{id} | Delete user API key


<a name="streamsget"></a>
# **StreamsGet**
> List<Stream> StreamsGet (string name = null, bool? uiChannel = null, bool? noConfig = null, string search = null, string sortBy = null, string order = null, int? max = null, int? offset = null, bool? grantedAccess = null, bool? publicAccess = null, string operation = null)

List streams

Lists the streams available to the user. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var name = name_example;  // string | Only return streams that exactly match the given name. (optional) 
            var uiChannel = true;  // bool? | Filter by whether this stream is an UI channel or not. UI channels are streams used to push updates to visualisation widgets. For the typical list of streams, set this to false. (optional)  (default to false)
            var noConfig = true;  // bool? | Remove config object from JSON response. (optional)  (default to false)
            var search = search_example;  // string | Filter by search term in name or description (optional) 
            var sortBy = sortBy_example;  // string | Sort the returned results by the given field. (optional)  (default to id)
            var order = order_example;  // string | Control whether the results are sorted in ascending or descending order. Used with parameter `sortBy`. (optional)  (default to asc)
            var max = 56;  // int? | Maximum number of returned results (capped at 100) (optional)  (default to 100)
            var offset = 56;  // int? | Skip the first (offset) results. Used together with max for paging. (optional)  (default to 0)
            var grantedAccess = true;  // bool? | If false, excludes resources that user has been granted specific permission to from results. (optional)  (default to true)
            var publicAccess = true;  // bool? | If true, includes publicly available resources in the results. (optional)  (default to false)
            var operation = operation_example;  // string | Filter results by Permission (access level) (optional)  (default to stream_get)

            try
            {
                // List streams
                List&lt;Stream&gt; result = apiInstance.StreamsGet(name, uiChannel, noConfig, search, sortBy, order, max, offset, grantedAccess, publicAccess, operation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Only return streams that exactly match the given name. | [optional] 
 **uiChannel** | **bool?**| Filter by whether this stream is an UI channel or not. UI channels are streams used to push updates to visualisation widgets. For the typical list of streams, set this to false. | [optional] [default to false]
 **noConfig** | **bool?**| Remove config object from JSON response. | [optional] [default to false]
 **search** | **string**| Filter by search term in name or description | [optional] 
 **sortBy** | **string**| Sort the returned results by the given field. | [optional] [default to id]
 **order** | **string**| Control whether the results are sorted in ascending or descending order. Used with parameter &#x60;sortBy&#x60;. | [optional] [default to asc]
 **max** | **int?**| Maximum number of returned results (capped at 100) | [optional] [default to 100]
 **offset** | **int?**| Skip the first (offset) results. Used together with max for paging. | [optional] [default to 0]
 **grantedAccess** | **bool?**| If false, excludes resources that user has been granted specific permission to from results. | [optional] [default to true]
 **publicAccess** | **bool?**| If true, includes publicly available resources in the results. | [optional] [default to false]
 **operation** | **string**| Filter results by Permission (access level) | [optional] [default to stream_get]

### Return type

[**List<Stream>**](Stream.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddatapartitionspartitionfromget"></a>
# **StreamsIdDataPartitionsPartitionFromGet**
> void StreamsIdDataPartitionsPartitionFromGet (string id, int? partition, int? fromTimestamp, int? fromSequenceNumber = null, string publisherId = null)

Get events from a timestamp or reference from the stream

Get events from a timestamp or reference from the stream. The starting point can be defined by a timestamp or by a message reference (timestamp and sequence number). The publisher must be specified in the case of message reference.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDataPartitionsPartitionFromGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var partition = 56;  // int? | Partition number
            var fromTimestamp = 56;  // int? | Timestamp lower bound in milliseconds since Jan 1st 1970 UTC
            var fromSequenceNumber = 56;  // int? | Sequence number lower bound of fromTimestamp (optional) 
            var publisherId = publisherId_example;  // string | Id of the publisher of the two message references, in case sequence numbers are defined (optional) 

            try
            {
                // Get events from a timestamp or reference from the stream
                apiInstance.StreamsIdDataPartitionsPartitionFromGet(id, partition, fromTimestamp, fromSequenceNumber, publisherId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDataPartitionsPartitionFromGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **partition** | **int?**| Partition number | 
 **fromTimestamp** | **int?**| Timestamp lower bound in milliseconds since Jan 1st 1970 UTC | 
 **fromSequenceNumber** | **int?**| Sequence number lower bound of fromTimestamp | [optional] 
 **publisherId** | **string**| Id of the publisher of the two message references, in case sequence numbers are defined | [optional] 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddatapartitionspartitionlastget"></a>
# **StreamsIdDataPartitionsPartitionLastGet**
> void StreamsIdDataPartitionsPartitionLastGet (string id, int? partition, int? count = null)

Get most recent events from a stream

Get the N most recent events from a stream.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDataPartitionsPartitionLastGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var partition = 56;  // int? | Partition number
            var count = 56;  // int? | Number of messages to fetch (optional)  (default to 1)

            try
            {
                // Get most recent events from a stream
                apiInstance.StreamsIdDataPartitionsPartitionLastGet(id, partition, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDataPartitionsPartitionLastGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **partition** | **int?**| Partition number | 
 **count** | **int?**| Number of messages to fetch | [optional] [default to 1]

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddatapartitionspartitionrangeget"></a>
# **StreamsIdDataPartitionsPartitionRangeGet**
> void StreamsIdDataPartitionsPartitionRangeGet (string id, int? partition, int? fromTimestamp, int? toTimestamp, int? fromSequenceNumber = null, int? toSequenceNumber = null, string publisherId = null)

Get events between a range from the stream

Get events between a range from the stream. The range can be defined between two timestamps or between two message references (timestamp and sequence number). The publisher must be specified in the case of message references.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDataPartitionsPartitionRangeGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var partition = 56;  // int? | Partition number
            var fromTimestamp = 56;  // int? | Timestamp lower bound in milliseconds since Jan 1st 1970 UTC
            var toTimestamp = 56;  // int? | Timestamp upper bound in milliseconds since Jan 1st 1970 UTC
            var fromSequenceNumber = 56;  // int? | Sequence number lower bound of fromTimestamp (optional) 
            var toSequenceNumber = 56;  // int? | Sequence number upper bound of toTimestamp (optional) 
            var publisherId = publisherId_example;  // string | Id of the publisher of the two message references, in case sequence numbers are defined (optional) 

            try
            {
                // Get events between a range from the stream
                apiInstance.StreamsIdDataPartitionsPartitionRangeGet(id, partition, fromTimestamp, toTimestamp, fromSequenceNumber, toSequenceNumber, publisherId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDataPartitionsPartitionRangeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **partition** | **int?**| Partition number | 
 **fromTimestamp** | **int?**| Timestamp lower bound in milliseconds since Jan 1st 1970 UTC | 
 **toTimestamp** | **int?**| Timestamp upper bound in milliseconds since Jan 1st 1970 UTC | 
 **fromSequenceNumber** | **int?**| Sequence number lower bound of fromTimestamp | [optional] 
 **toSequenceNumber** | **int?**| Sequence number upper bound of toTimestamp | [optional] 
 **publisherId** | **string**| Id of the publisher of the two message references, in case sequence numbers are defined | [optional] 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddatapost"></a>
# **StreamsIdDataPost**
> void StreamsIdDataPost (string id, int? ttl = null, string pkey = null, int? signatureType = null, string address = null, string signature = null)

Add new event to stream

Add a new event to the stream identified by id. Requires a write permission on the stream.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDataPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var ttl = 56;  // int? | Time-To-Live, in seconds. The event will be deleted after this time has passed. If not given, the event storage period will be the stream default. (optional) 
            var pkey = pkey_example;  // string | For partitioned streams, provides the key to partition by. Can be eg. a customer id to make all events for that customer to go to the same Canvas for processing. If not given, a random partition is selected. (optional) 
            var signatureType = 56;  // int? | Signature type of the signature query parameter. 1 for Ethereum signature, 0 for no signature. If not given, defaults to 0. (optional) 
            var address = address_example;  // string | Ethereum address of the publisher in case the signature type is 1. The parameter is not needed if the signature type is 0. (optional) 
            var signature = signature_example;  // string | If the signature type is 1, this parameter is the hex string representation of the Ethereum signature produced by the Ethereum address provided in the 'address' query parameter. This parameter is not needed if the signature type is 0. (optional) 

            try
            {
                // Add new event to stream
                apiInstance.StreamsIdDataPost(id, ttl, pkey, signatureType, address, signature);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDataPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **ttl** | **int?**| Time-To-Live, in seconds. The event will be deleted after this time has passed. If not given, the event storage period will be the stream default. | [optional] 
 **pkey** | **string**| For partitioned streams, provides the key to partition by. Can be eg. a customer id to make all events for that customer to go to the same Canvas for processing. If not given, a random partition is selected. | [optional] 
 **signatureType** | **int?**| Signature type of the signature query parameter. 1 for Ethereum signature, 0 for no signature. If not given, defaults to 0. | [optional] 
 **address** | **string**| Ethereum address of the publisher in case the signature type is 1. The parameter is not needed if the signature type is 0. | [optional] 
 **signature** | **string**| If the signature type is 1, this parameter is the hex string representation of the Ethereum signature produced by the Ethereum address provided in the &#39;address&#39; query parameter. This parameter is not needed if the signature type is 0. | [optional] 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddelete"></a>
# **StreamsIdDelete**
> void StreamsIdDelete (string id)

Delete a stream

Deletes a stream by id. This will also delete all data for this stream. Use with caution!

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream to be deleted

            try
            {
                // Delete a stream
                apiInstance.StreamsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream to be deleted | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddetectfieldsget"></a>
# **StreamsIdDetectFieldsGet**
> void StreamsIdDetectFieldsGet (string id, bool? flatten = null)

Detect stream's field types.

Automatically detects fields of given Stream by analyzing recent data. Do not save fields to stream details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDetectFieldsGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var flatten = true;  // bool? | Flatten hierarchies. (optional)  (default to false)

            try
            {
                // Detect stream's field types.
                apiInstance.StreamsIdDetectFieldsGet(id, flatten);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDetectFieldsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **flatten** | **bool?**| Flatten hierarchies. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsiddetectfieldspost"></a>
# **StreamsIdDetectFieldsPost**
> void StreamsIdDetectFieldsPost (string id, bool? flatten = null)

Detect stream's field types.

Automatically detects fields of given Stream by analyzing recent data. Save fields to stream details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdDetectFieldsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var flatten = true;  // bool? | Flatten hierarchies. (optional)  (default to false)

            try
            {
                // Detect stream's field types.
                apiInstance.StreamsIdDetectFieldsPost(id, flatten);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdDetectFieldsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **flatten** | **bool?**| Flatten hierarchies. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidget"></a>
# **StreamsIdGet**
> Stream StreamsIdGet (string id)

Get stream by id

Returns a stream by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream to be fetched

            try
            {
                // Get stream by id
                Stream result = apiInstance.StreamsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream to be fetched | 

### Return type

[**Stream**](Stream.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidkeysget"></a>
# **StreamsIdKeysGet**
> List<ResourceKey> StreamsIdKeysGet (string id)

List keys

List the keys for a given Stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdKeysGetExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream

            try
            {
                // List keys
                List&lt;ResourceKey&gt; result = apiInstance.StreamsIdKeysGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdKeysGet: " + e.Message );
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

[**List<ResourceKey>**](ResourceKey.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsidkeyspost"></a>
# **StreamsIdKeysPost**
> ResourceKey StreamsIdKeysPost (string id, ResourceKeyCreateRequest body)

Create a key

Creates an API key for the given Stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdKeysPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var body = new ResourceKeyCreateRequest(); // ResourceKeyCreateRequest | Key to be created

            try
            {
                // Create a key
                ResourceKey result = apiInstance.StreamsIdKeysPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream | 
 **body** | [**ResourceKeyCreateRequest**](ResourceKeyCreateRequest.md)| Key to be created | 

### Return type

[**ResourceKey**](ResourceKey.md)

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

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream

            try
            {
                // List permissions
                List&lt;Permission&gt; result = apiInstance.StreamsIdPermissionsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdPermissionsGet: " + e.Message );
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

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream
            var pid = 56;  // int? | ID of the permission to be deleted

            try
            {
                // Delete a stream permission
                apiInstance.StreamsIdPermissionsPidDelete(id, pid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdPermissionsPidDelete: " + e.Message );
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

            var apiInstance = new StreamsApi();
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
                Debug.Print("Exception when calling StreamsApi.StreamsIdPermissionsPidGet: " + e.Message );
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

            var apiInstance = new StreamsApi();
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
                Debug.Print("Exception when calling StreamsApi.StreamsIdPermissionsPost: " + e.Message );
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

<a name="streamsidput"></a>
# **StreamsIdPut**
> Stream StreamsIdPut (string id, StreamCreateRequest body)

Update a stream

Updates a stream.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the stream to be updated
            var body = new StreamCreateRequest(); // StreamCreateRequest | StreamCreateRequest object

            try
            {
                // Update a stream
                Stream result = apiInstance.StreamsIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the stream to be updated | 
 **body** | [**StreamCreateRequest**](StreamCreateRequest.md)| StreamCreateRequest object | 

### Return type

[**Stream**](Stream.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamspost"></a>
# **StreamsPost**
> Stream StreamsPost (StreamCreateRequest body)

Create a new stream

Creates a new stream. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsPostExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var body = new StreamCreateRequest(); // StreamCreateRequest | Stream object

            try
            {
                // Create a new stream
                Stream result = apiInstance.StreamsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StreamCreateRequest**](StreamCreateRequest.md)| Stream object | 

### Return type

[**Stream**](Stream.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsstreamidkeysiddelete"></a>
# **StreamsStreamIdKeysIdDelete**
> void StreamsStreamIdKeysIdDelete (string streamId, string id)

Delete a key

Deletes an API key from the given Stream.  Requires 'share' permission or ownership.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsStreamIdKeysIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var streamId = streamId_example;  // string | ID of the stream
            var id = id_example;  // string | ID of the key

            try
            {
                // Delete a key
                apiInstance.StreamsStreamIdKeysIdDelete(streamId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsStreamIdKeysIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **streamId** | **string**| ID of the stream | 
 **id** | **string**| ID of the key | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamsstreamidkeysidput"></a>
# **StreamsStreamIdKeysIdPut**
> void StreamsStreamIdKeysIdPut (UpdateStreamKeyRequest body, string streamId, string id)

Update Stream's Key's name and permission

Update Stream's Key's name and permission.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StreamsStreamIdKeysIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var body = new UpdateStreamKeyRequest(); // UpdateStreamKeyRequest | UpdateStreamKeyRequest object
            var streamId = streamId_example;  // string | ID of the stream
            var id = id_example;  // string | ID of the key to be updated

            try
            {
                // Update Stream's Key's name and permission
                apiInstance.StreamsStreamIdKeysIdPut(body, streamId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.StreamsStreamIdKeysIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateStreamKeyRequest**](UpdateStreamKeyRequest.md)| UpdateStreamKeyRequest object | 
 **streamId** | **string**| ID of the stream | 
 **id** | **string**| ID of the key to be updated | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmekeysiddelete"></a>
# **UsersMeKeysIdDelete**
> void UsersMeKeysIdDelete (string id)

Delete user API key

Revoke and delete a user API key. Can only be called by the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersMeKeysIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StreamsApi();
            var id = id_example;  // string | ID of the key

            try
            {
                // Delete user API key
                apiInstance.UsersMeKeysIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamsApi.UsersMeKeysIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the key | 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

