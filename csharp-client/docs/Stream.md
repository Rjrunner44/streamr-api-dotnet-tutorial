# IO.Swagger.Model.Stream
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this stream. | [optional] 
**Name** | **string** | Name of this stream. | 
**Description** | **string** | Description of this stream. | [optional] 
**Config** | [**StreamConfig**](StreamConfig.md) |  | [optional] 
**UiChannel** | **bool?** | Indicates whether this stream is an UI channel: a stream used internally to push updates to UI widgets. | [optional] 
**Partitions** | **int?** | Number of partitions in this stream. Defaults to 1 (unpartitioned). | [optional] 
**RequireSignedData** | **bool?** | If true, all messages in this stream must be cryptographically signed. Client&#39;s should not accept unsigned messages. | [optional] 
**RequireEncryptedData** | **bool?** | If true, all data in this stream must be encrypted. | [optional] 
**Inbox** | **bool?** | If true, this stream is a user&#39;s inbox. | [optional] 
**DateCreated** | **string** | ISO-8601 timestamp of when stream was created. | [optional] 
**LastUpdated** | **string** | ISO-8601 timestamp of when stream details were updated. | [optional] 
**AutoConfigure** | **bool?** | If true, always try to automatically configure field names and types. | [optional] 
**StorageDays** | **int?** | Historical data storage period (days) | [optional] 
**InactivityThresholdHours** | **int?** | Inactivity period for a stream in hours. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

