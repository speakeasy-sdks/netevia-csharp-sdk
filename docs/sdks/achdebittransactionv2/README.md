# ACHDebitTransactionV2SDK
(*ACHDebitTransactionV2*)

### Available Operations

* [Create](#create) - ACH Debit transactions.

## Create

Initiate an <b>ACH</b> debit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> debit transaction is used to allow customers to pay using checks. The data from the check is digitaly converted and the transaction is posted to the customer bank account.
<hr>
<sup>1</sup>Use the examples for different 'ACH Debit' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.ACHDebitTransactionV2.CreateAsync(new RestAPIv2ACHDebitRequest() {
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

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [RestAPIv2ACHDebitRequest](../../models/operations/RestAPIv2ACHDebitRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[RestAPIv2ACHDebitResponse](../../models/operations/RestAPIv2ACHDebitResponse.md)**

