# CloudPDCv2SaleSDK
(*CloudPDCv2Sale*)

### Available Operations

* [Initiate](#initiate) - Initiate a transaction request.

## Initiate

Initiate a transaction request to Netevia Payment Device Controller. For more samples please review the /restApi endpoint as all transaction types can be used also on this endpoint(without card data). 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCv2Sale.InitiateAsync(new InitiateCloudPDCv2SaleRequest() {
    Gmid = "Chevrolet neque Hybrid",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = "Passaic",
    TerminalType = Gateway.Models.Shared.TerminalType.Pax,
    TransType = Gateway.Models.Shared.TransType.SelBatch,
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [InitiateCloudPDCv2SaleRequest](../../models/operations/InitiateCloudPDCv2SaleRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[InitiateCloudPDCv2SaleResponse](../../models/operations/InitiateCloudPDCv2SaleResponse.md)**

