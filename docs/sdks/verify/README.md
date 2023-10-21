# VerifySDK
(*Verify*)

### Available Operations

* [RestAPIVerifyInquiry](#restapiverifyinquiry) - How to initiate Verify/Inquiry transaction requests.

## RestAPIVerifyInquiry

Initiate a <b>Verify/Inquiry</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Inquiry</b> transaction is used to query the balance amount of a card.<br>
A <b>Verify</b> transaction is used to check if the card is valid.
<hr>
<sup>1</sup>Use the examples for different request samples.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;

var sdk = new GatewaySDK();

var res = await sdk.Verify.RestAPIVerifyInquiryAsync("string");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIVerifyInquiryResponse](../../models/operations/RestAPIVerifyInquiryResponse.md)**

