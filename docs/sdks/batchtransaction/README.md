# BatchTransactionSDK
(*BatchTransaction*)

### Available Operations

* [Create](#create) - Request batch closing.

## Create

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

var res = await sdk.BatchTransaction.CreateAsync(new RestAPIv2BatchRequest() {
    Gmid = "bluetooth Extended",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpPIN() {
        Ksn = "FFFF6543210000A00029",
        PinBlock = "F652B46D04B5D191",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.None,
    TransType = Gateway.Models.Shared.TransType.ReAuth,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RestAPIv2BatchRequest](../../models/operations/RestAPIv2BatchRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RestAPIv2BatchResponse](../../models/operations/RestAPIv2BatchResponse.md)**

