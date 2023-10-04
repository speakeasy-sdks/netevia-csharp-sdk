# APIACHCreditSDK
(*APIACHCredit*)

### Available Operations

* [RestAPIACHCredit](#restapiachcredit) - ACH Credit transactions.

## RestAPIACHCredit

Initiate an <b>ACH</b> credit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> credit transaction is used to allow merchants to pay using ACH and transfer money to other bank accounts.<br>
To be more generic and have a similar approach as for Debit ACH, we can also simulate the single PayOut call for a batch of payments with multiple individual credit transactions calls that will be approved offline by us and when batching happens we can generate the PayOut request to GMS as a single API call(batch file upload) as they require. Now GMS processor support.
<hr>
<sup>1</sup>Use the examples for different 'ACH Credit' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIACHCredit.RestAPIACHCreditAsync(new GrpTrace() {
    Gtrc = "e134bff9203f44e8974a11b2aef7665d",
    NewGTRC = "fe31047eca6b47f2a07ead29be5a7672",
    SourceTraceNum = "123456",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIACHCreditResponse](../../models/operations/RestAPIACHCreditResponse.md)**

