# APIRefundSDK
(*APIRefund*)

### Available Operations

* [RestAPIRefund](#restapirefund) - How to initiate Refund transaction requests.

## RestAPIRefund

Initiate a <b>Refund</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Refund</b> transaction is used to authorize a refund to a customer's credit card account.
<hr>
<sup>1</sup>Use the examples for different 'Refund' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIRefund.RestAPIRefundAsync(new GrpACH() {
    AccountType = Gateway.Models.Shared.GrpACHAccountType.Savings,
    EleCheckAccountNumber = "125401754499",
    EleCheckRoutingNumber = "102000021",
    EleCheckServiceProvider = Gateway.Models.Shared.GrpACHEleCheckServiceProvider.ElecCheckWEB,
    EleCheckTransactionType = Gateway.Models.Shared.GrpACHEleCheckTransactionType.EleCheckConversion,
    TotalCreditAmt = "25000",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIRefundResponse](../../models/operations/RestAPIRefundResponse.md)**

