# VerifyTransactionV2SDK
(*VerifyTransactionV2*)

### Available Operations

* [Create](#create) - How to initiate Verify/Inquiry transaction requests.

## Create

Initiate a <b>Verify/Inquiry</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Inquiry</b> transaction is used to query the balance amount of a card.<br>
A <b>Verify</b> transaction is used to check if the card is valid.
<hr>
<sup>1</sup>Use the examples for different request samples.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.VerifyTransactionV2.CreateAsync(new RestAPIv2VerifyInquiryRequest() {
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

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [RestAPIv2VerifyInquiryRequest](../../models/operations/RestAPIv2VerifyInquiryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[RestAPIv2VerifyInquiryResponse](../../models/operations/RestAPIv2VerifyInquiryResponse.md)**

