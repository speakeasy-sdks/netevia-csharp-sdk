# APIv2RefundSDK
(*APIv2Refund*)

### Available Operations

* [RestAPIv2Refund](#restapiv2refund) - How to initiate Refund transaction requests.

## RestAPIv2Refund

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

var res = await sdk.APIv2Refund.RestAPIv2RefundAsync(new RestAPIv2RefundRequest() {
    Gmid = "second henry",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpExtendInfo() {
        AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
        AuthCode = "OK1234",
        InvoiceNum = "Inv123456",
        OrderNum = "Ord12345",
        VoucherNum = "Voucher12345",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Dejavoo,
    TransType = Gateway.Models.Shared.TransType.AddTip,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RestAPIv2RefundRequest](../../models/operations/RestAPIv2RefundRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RestAPIv2RefundResponse](../../models/operations/RestAPIv2RefundResponse.md)**

