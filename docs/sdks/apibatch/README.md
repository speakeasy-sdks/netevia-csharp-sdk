# APIBatchSDK
(*APIBatch*)

### Available Operations

* [RestAPIBatch](#restapibatch) - Request batch closing.

## RestAPIBatch

Initiate a batch close request to Netevia Gateway

***<span style="color:green">Valid actions:</span>***
---
___
- <span style="color:red">Batch</span> : is used to close the current open batch and settle it. It is supported by terminal capture only .For host capture, merchant don’t need submit batch request. For GMS ACH Credit batch, please check the examples from ACHCredit section.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIBatch.RestAPIBatchAsync(new GrpTrace() {
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

**[RestAPIBatchResponse](../../models/operations/RestAPIBatchResponse.md)**

