# APIv2AuthSDK
(*APIv2Auth*)

### Available Operations

* [Rest](#rest) - How to initiate different Auth/Finalize transaction requests.

## Rest

Initiate an <b>Auth/Finalize</b> transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>Auth</b> transaction places a temporary hold on the customer’s account. Approvals on authorizations are used later to transfer funds by Finalize or AddTip.<br>
A <b>Finalize</b> transaction is used to change an <b>Auth</b> transaction to a <b>Sale</b> transaction.
<hr>
<sup>1</sup>Use the examples for different 'Auth/Finalize' flavours 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIv2Auth.RestAsync(new RestAPIv2AuthRequest() {
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

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2AuthRequest](../../models/operations/RestAPIv2AuthRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2AuthResponse](../../models/operations/RestAPIv2AuthResponse.md)**

