# IO.Swagger.Model.Canvas
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for Canvas | [optional] 
**Name** | **string** |  | 
**Modules** | [**List&lt;Module&gt;**](Module.md) |  | 
**Settings** | [**CanvasSettings**](CanvasSettings.md) |  | [optional] 
**Created** | **DateTime?** | when Canvas was created | [optional] 
**Updated** | **DateTime?** | when Canvas was last updated | [optional] 
**HasExports** | **bool?** | whether module uses exported inputs or outputs | [optional] 
**UiChannel** | [**UiChannel**](UiChannel.md) |  | [optional] 
**State** | **CanvasState** |  | [optional] 
**Adhoc** | **bool?** | adhoc canvases are temporary canvases used for eg. historical runs. | [optional] 
**Serialized** | **bool?** | indicates whether there exists a serialization of this canvas | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

