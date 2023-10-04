# APIv2VoidSDK
(*APIv2Void*)

### Available Operations

* [RestAPIv2Void](#restapiv2void) - How to initiate Void/Reverse/Cancel transaction requests.

## RestAPIv2Void

Initiate a <b>Void/Reverse/Cancel</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Void</b> transaction is used to cancel an authorized transaction before it has been settled.<br>
<b>Reverse</b> transaction is used to cancel an authorized transaction whether or not it has been settled.<br>
<b>Cancel</b> transaction is used to cancel an authorized transaction before it has been settled.
<hr>
<sup>1</sup>Use the examples for different 'Void/Reverse/Cancel' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2Void.RestAPIv2VoidAsync(new RestAPIv2VoidRequest() {
    Gmid = "Market Northwest Northeast",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpACH() {
        AccountType = Gateway.Models.Shared.GrpACHAccountType.Savings,
        EleCheckAccountNumber = "125401754499",
        EleCheckRoutingNumber = "102000021",
        EleCheckServiceProvider = Gateway.Models.Shared.GrpACHEleCheckServiceProvider.ElecCheckWEB,
        EleCheckTransactionType = Gateway.Models.Shared.GrpACHEleCheckTransactionType.EleCheckConversion,
        TotalCreditAmt = "25000",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Dejavoo,
    TransType = Gateway.Models.Shared.TransType.Unregister,
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2VoidRequest](../../models/operations/RestAPIv2VoidRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2VoidResponse](../../models/operations/RestAPIv2VoidResponse.md)**

