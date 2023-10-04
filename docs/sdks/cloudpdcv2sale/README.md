# CloudPDCv2SaleSDK
(*CloudPDCv2Sale*)

### Available Operations

* [InitiateCloudPDCv2Sale](#initiatecloudpdcv2sale) - Initiate a transaction request.

## InitiateCloudPDCv2Sale

Initiate a transaction request to Netevia Payment Device Controller. For more samples please review the /restApi endpoint as all transaction types can be used also on this endpoint(without card data). 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCv2Sale.InitiateCloudPDCv2SaleAsync(new InitiateCloudPDCv2SaleRequest() {
    Gmid = "oof maroon",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpExtendInfo() {
        AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
        AuthCode = "OK1234",
        InvoiceNum = "Inv123456",
        OrderNum = "Ord12345",
        VoucherNum = "Voucher12345",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Ingenico,
    TransType = Gateway.Models.Shared.TransType.GetCardToken,
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [InitiateCloudPDCv2SaleRequest](../../models/operations/InitiateCloudPDCv2SaleRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[InitiateCloudPDCv2SaleResponse](../../models/operations/InitiateCloudPDCv2SaleResponse.md)**

