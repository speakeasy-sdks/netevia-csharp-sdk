# RefundTransctionV2
(*RefundTransctionV2*)

### Available Operations

* [Create](#create) - How to initiate Refund transaction requests.

## Create

Initiate a <b>Refund</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Refund</b> transaction is used to authorize a refund to a customer's credit card account.
<hr>
<sup>1</sup>Use the examples for different 'Refund' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.RefundTransctionV2.CreateAsync(new RestAPIv2RefundRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RestAPIv2RefundRequest](../../Models/Operations/RestAPIv2RefundRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RestAPIv2RefundResponse](../../Models/Operations/RestAPIv2RefundResponse.md)**

