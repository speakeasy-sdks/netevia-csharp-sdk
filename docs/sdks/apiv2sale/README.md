# APIv2SaleSDK
(*APIv2Sale*)

### Available Operations

* [Rest](#rest) - How to initiate different Sale transaction requests.

## Rest

Initiate a <b>Sale</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Sale</b> transaction authorizes a sale purchased. This action decreases the cardholder's limit to buy. It authorizes a transfer of funds from the cardholder's account to merchant's account.
<hr>
<sup>1</sup>Use the examples for different 'Sale' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2Sale.RestAsync(new RestAPIv2SaleRequest() {
    Gmid = "so Fantastic online",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpCardDataEncryption() {
        EncrptBlock = "Coupe mobile Chrysler",
        EncrptTrgt = Gateway.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
        KeyID = "66257982464",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.M6Plus,
    TransType = Gateway.Models.Shared.TransType.Refund,
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2SaleRequest](../../models/operations/RestAPIv2SaleRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2SaleResponse](../../models/operations/RestAPIv2SaleResponse.md)**

