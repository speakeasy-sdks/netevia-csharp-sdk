# APIv2ACHCreditSDK
(*APIv2ACHCredit*)

### Available Operations

* [Rest](#rest) - ACH Credit transactions.

## Rest

Initiate an <b>ACH</b> credit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> credit transaction is used to allow merchants to pay using ACH and transfer money to other bank accounts.<br>
To be more generic and have a similar approach as for Debit ACH, we can also simulate the single PayOut call for a batch of payments with multiple individual credit transactions calls that will be approved offline by us and when batching happens we can generate the PayOut request to GMS as a single API call(batch file upload) as they require. Now GMS processor support.
<hr>
<sup>1</sup>Use the examples for different 'ACH Credit' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIv2ACHCredit.RestAsync(new RestAPIv2ACHCreditRequest() {
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

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RestAPIv2ACHCreditRequest](../../models/operations/RestAPIv2ACHCreditRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[RestAPIv2ACHCreditResponse](../../models/operations/RestAPIv2ACHCreditResponse.md)**

