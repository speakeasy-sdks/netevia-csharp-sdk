# APIv2ModifySDK
(*APIv2Modify*)

### Available Operations

* [Rest](#rest) - How to initiate Modify/Adjust/AddTip transaction requests.

## Rest

Initiate a <b>Modify/Adjust/AddTip</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Modify</b> transaction is used to alter the transaction amount of an original transaction, Auth or Sale.<br>
<b>Adjust</b> transaction is used to alter the transaction amount of an original transaction whether or not it has been settled, Auth or Sale.
<b>AddTip</b> transaction is used to add an additional amount to an original transaction, Auth or Sale. If the original transaction is Auth, this operation transfers the Auth to Sale.<br>
<hr>
<sup>1</sup>Use the examples for different 'Modify' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIv2Modify.RestAsync(new RestAPIv2ModifyRequest() {
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
| `request`                                                                   | [RestAPIv2ModifyRequest](../../models/operations/RestAPIv2ModifyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RestAPIv2ModifyResponse](../../models/operations/RestAPIv2ModifyResponse.md)**

