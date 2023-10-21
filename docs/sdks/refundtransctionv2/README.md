# RefundTransctionV2SDK
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
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.RefundTransctionV2.CreateAsync(new RestAPIv2RefundRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = Gateway.Models.Shared.TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RestAPIv2RefundRequest](../../models/operations/RestAPIv2RefundRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RestAPIv2RefundResponse](../../models/operations/RestAPIv2RefundResponse.md)**

