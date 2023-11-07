# ACHCreditTransactionV2
(*.ACHCreditTransactionV2*)

### Available Operations

* [Create](#create) - ACH Credit transactions.

## Create

Initiate an <b>ACH</b> credit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> credit transaction is used to allow merchants to pay using ACH and transfer money to other bank accounts.<br>
To be more generic and have a similar approach as for Debit ACH, we can also simulate the single PayOut call for a batch of payments with multiple individual credit transactions calls that will be approved offline by us and when batching happens we can generate the PayOut request to GMS as a single API call(batch file upload) as they require. Now GMS processor support.
<hr>
<sup>1</sup>Use the examples for different 'ACH Credit' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.ACHCreditTransactionV2.CreateAsync(new RestAPIv2ACHCreditRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RestAPIv2ACHCreditRequest](../../models/operations/RestAPIv2ACHCreditRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[RestAPIv2ACHCreditResponse](../../models/operations/RestAPIv2ACHCreditResponse.md)**

