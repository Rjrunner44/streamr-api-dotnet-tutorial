# IO.Swagger.Model.CreateProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of Product | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Category** | **string** | identifier of Category this Product belong to | [optional] 
**Streams** | **List&lt;string&gt;** | List of Stream identifiers that belong to this Product | [optional] 
**PreviewStream** | **string** | Identifier of Stream selected for preview | [optional] 
**PreviewConfigJson** | **string** | Configuration of previewStream | [optional] 
**OwnerAddress** | **string** | Ethereum address of owner | [optional] 
**BeneficiaryAddress** | **string** | Ethereum address of beneficiary | [optional] 
**PricePerSecond** | **int?** | Unit cost per second | [optional] 
**PriceCurrency** | **string** | Unit currency | [optional] 
**MinimumSubscriptionInSeconds** | **int?** | Minimum subscription length (in seconds) | [optional] 
**Contact** | [**ProductContact**](ProductContact.md) |  | [optional] 
**TermsOfUse** | [**ProductTermsOfUse**](ProductTermsOfUse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

