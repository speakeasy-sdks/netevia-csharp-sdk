# BatchTransaction
(*BatchTransaction*)

### Available Operations

* [Create](#create) - Request batch closing.

## Create

Initiate a batch close request to Netevia Gateway

***<span style="color:green">Valid actions:</span>***
---
___
- <span style="color:red">Batch</span> : is used to close the current open batch and settle it. It is supported by terminal capture only .For host capture, merchant don’t need submit batch request. For GMS ACH Credit batch, please check the examples from ACHCredit section.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.BatchTransaction.CreateAsync(new RestAPIv2BatchRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RestAPIv2BatchRequest](../../Models/Operations/RestAPIv2BatchRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RestAPIv2BatchResponse](../../Models/Operations/RestAPIv2BatchResponse.md)**

