# VerifyTransactionV2
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
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2VerifyInquiryRequest req = new RestAPIv2VerifyInquiryRequest() {
    Gmid = "<value>",
    RequestBody = "<value>",
    TransType = TransType.Register,
};

var res = await sdk.VerifyTransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [RestAPIv2VerifyInquiryRequest](../../Models/Operations/RestAPIv2VerifyInquiryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[RestAPIv2VerifyInquiryResponse](../../Models/Operations/RestAPIv2VerifyInquiryResponse.md)**

