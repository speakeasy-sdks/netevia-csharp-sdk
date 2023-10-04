# APIv2BatchSDK
(*APIv2Batch*)

### Available Operations

* [RestAPIv2Batch](#restapiv2batch) - Request batch closing.

## RestAPIv2Batch

Initiate a batch close request to Netevia Gateway

***<span style="color:green">Valid actions:</span>***
---
___
- <span style="color:red">Batch</span> : is used to close the current open batch and settle it. It is supported by terminal capture only .For host capture, merchant don’t need submit batch request. For GMS ACH Credit batch, please check the examples from ACHCredit section.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2Batch.RestAPIv2BatchAsync(new RestAPIv2BatchRequest() {
    Gmid = "Kids quantify",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpExtendInfo() {
        AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
        AuthCode = "OK1234",
        InvoiceNum = "Inv123456",
        OrderNum = "Ord12345",
        VoucherNum = "Voucher12345",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Dejavoo,
    TransType = Gateway.Models.Shared.TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RestAPIv2BatchRequest](../../models/operations/RestAPIv2BatchRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RestAPIv2BatchResponse](../../models/operations/RestAPIv2BatchResponse.md)**

