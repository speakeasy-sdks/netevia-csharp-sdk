# APIv2ACHDebitSDK
(*APIv2ACHDebit*)

### Available Operations

* [Rest](#rest) - ACH Debit transactions.

## Rest

Initiate an <b>ACH</b> debit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> debit transaction is used to allow customers to pay using checks. The data from the check is digitaly converted and the transaction is posted to the customer bank account.
<hr>
<sup>1</sup>Use the examples for different 'ACH Debit' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIv2ACHDebit.RestAsync(new RestAPIv2ACHDebitRequest() {
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

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [RestAPIv2ACHDebitRequest](../../models/operations/RestAPIv2ACHDebitRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[RestAPIv2ACHDebitResponse](../../models/operations/RestAPIv2ACHDebitResponse.md)**

