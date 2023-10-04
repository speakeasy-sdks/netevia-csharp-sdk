# APIVoidSDK
(*APIVoid*)

### Available Operations

* [Rest](#rest) - How to initiate Void/Reverse/Cancel transaction requests.

## Rest

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
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIVoid.RestAsync(new GrpACH() {
    AccountType = Gateway.Models.Shared.GrpACHAccountType.Savings,
    EleCheckAccountNumber = "125401754499",
    EleCheckRoutingNumber = "102000021",
    EleCheckServiceProvider = Gateway.Models.Shared.GrpACHEleCheckServiceProvider.ElecCheckWEB,
    EleCheckTransactionType = Gateway.Models.Shared.GrpACHEleCheckTransactionType.EleCheckConversion,
    TotalCreditAmt = "25000",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIVoidResponse](../../models/operations/RestAPIVoidResponse.md)**

