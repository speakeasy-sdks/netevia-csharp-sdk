# SaleTransactionV2
(*.SaleTransactionV2*)

### Available Operations

* [Create](#create) - How to initiate different Sale transaction requests.

## Create

Initiate a <b>Sale</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Sale</b> transaction authorizes a sale purchased. This action decreases the cardholder's limit to buy. It authorizes a transfer of funds from the cardholder's account to merchant's account.
<hr>
<sup>1</sup>Use the examples for different 'Sale' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.SaleTransactionV2.CreateAsync(new RestAPIv2SaleRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2SaleRequest](../../models/operations/RestAPIv2SaleRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2SaleResponse](../../models/operations/RestAPIv2SaleResponse.md)**

