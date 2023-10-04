# CloudPDCSaleTransactionV2SDK
(*CloudPDCSaleTransactionV2*)

### Available Operations

* [Create](#create) - Initiate a transaction request.

## Create

Initiate a transaction request to Netevia Payment Device Controller. For more samples please review the /restApi endpoint as all transaction types can be used also on this endpoint(without card data). 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCSaleTransactionV2.CreateAsync(new InitiateCloudPDCv2SaleRequest() {
    Gmid = "bluetooth Extended",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpCardDataEncryption() {
        EncrptBlock = "shred",
        EncrptTrgt = Gateway.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
        KeyID = "66257982464",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.WinPDC,
    TransType = Gateway.Models.Shared.TransType.GetSessionKey,
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [InitiateCloudPDCv2SaleRequest](../../models/operations/InitiateCloudPDCv2SaleRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[InitiateCloudPDCv2SaleResponse](../../models/operations/InitiateCloudPDCv2SaleResponse.md)**

