# CloudPDCv2RefundSDK
(*CloudPDCv2Refund*)

### Available Operations

* [Initiate](#initiate) - Initiate a Refund request.

## Initiate

Initiate a Refund request to Netevia Payment Device Controller.   
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.CloudPDCv2Refund.InitiateAsync(new InitiateCloudPDCv2RefundRequest() {
    Gmid = "Chevrolet neque Hybrid",
    NeedSwipeCard = Speakeasybar.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpAmount() {
        IncCashBackAmt = 10000,
        IncTaxAmt = 10000,
        MainAmt = 10000,
        TaxIndicator = Speakeasybar.Models.Shared.GrpAmountTaxIndicator.Ntprvd,
        TipAmt = 10000,
    },
    TerminalType = Speakeasybar.Models.Shared.TerminalType.Dejavoo,
    TransType = Speakeasybar.Models.Shared.TransType.Ping,
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [InitiateCloudPDCv2RefundRequest](../../models/operations/InitiateCloudPDCv2RefundRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[InitiateCloudPDCv2RefundResponse](../../models/operations/InitiateCloudPDCv2RefundResponse.md)**

