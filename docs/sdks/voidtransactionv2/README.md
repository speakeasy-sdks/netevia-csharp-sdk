# VoidTransactionV2
(*VoidTransactionV2*)

### Available Operations

* [Create](#create) - How to initiate Void/Reverse/Cancel transaction requests.

## Create

Initiate a <b>Void/Reverse/Cancel</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Void</b> transaction is used to cancel an authorized transaction before it has been settled.<br>
<b>Reverse</b> transaction is used to cancel an authorized transaction whether or not it has been settled.<br>
<b>Cancel</b> transaction is used to cancel an authorized transaction before it has been settled.
<hr>
<sup>1</sup>Use the examples for different 'Void/Reverse/Cancel' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2VoidRequest req = new RestAPIv2VoidRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.VoidTransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2VoidRequest](../../Models/Operations/RestAPIv2VoidRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2VoidResponse](../../Models/Operations/RestAPIv2VoidResponse.md)**

