# APIv2RefundSDK
(*APIv2Refund*)

### Available Operations

* [Rest](#rest) - How to initiate Refund transaction requests.

## Rest

Initiate a <b>Refund</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Refund</b> transaction is used to authorize a refund to a customer's credit card account.
<hr>
<sup>1</sup>Use the examples for different 'Refund' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIv2Refund.RestAsync(new RestAPIv2RefundRequest() {
    Gmid = "so Fantastic online",
    NeedSwipeCard = Speakeasybar.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpCardDataEncryption() {
        EncrptBlock = "Coupe mobile Chrysler",
        EncrptTrgt = Speakeasybar.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
        KeyID = "66257982464",
    },
    TerminalType = Speakeasybar.Models.Shared.TerminalType.M6Plus,
    TransType = Speakeasybar.Models.Shared.TransType.Refund,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RestAPIv2RefundRequest](../../models/operations/RestAPIv2RefundRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RestAPIv2RefundResponse](../../models/operations/RestAPIv2RefundResponse.md)**

