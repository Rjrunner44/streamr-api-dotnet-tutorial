# IO.Swagger.Model.Product
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | unique identifier | 
**Type** | **string** | Type of Product | 
**State** | **string** | State of Product | 
**Created** | **string** | ISO-8601 datetime | 
**Updated** | **string** | ISO-8601 datetime | 
**Owner** | **string** | Username of the creator of this Product | 
**ImageUrl** | **string** | URL of image | 
**ThumbnailUrl** | **string** | URL of thumbnail image | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**Category** | **string** | identifier of Category this Product belong to | 
**Streams** | **List&lt;string&gt;** | List of Stream identifiers that belong to this Product | 
**PreviewStream** | **string** | Identifier of Stream selected for preview | [optional] 
**PreviewConfigJson** | **string** | Configuration of previewStream | [optional] 
**OwnerAddress** | **string** | Ethereum address of owner | 
**BeneficiaryAddress** | **string** | Ethereum address of beneficiary | 
**PricePerSecond** | **int?** | Unit cost per second | 
**PriceCurrency** | **string** | Unit currency | 
**MinimumSubscriptionInSeconds** | **int?** | Minimum subscription length (in seconds) | 
**PendingChanges** | **string** | Pending changes that are not published to blockchain | [optional] 
**Contact** | [**ProductContact**](ProductContact.md) |  | [optional] 
**TermsOfUse** | [**ProductTermsOfUse**](ProductTermsOfUse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

