# APIBatchSDK
(*APIBatch*)

### Available Operations

* [Rest](#rest) - Request batch closing.

## Rest

Initiate a batch close request to Netevia Gateway

***<span style="color:green">Valid actions:</span>***
---
___
- <span style="color:red">Batch</span> : is used to close the current open batch and settle it. It is supported by terminal capture only .For host capture, merchant don’t need submit batch request. For GMS ACH Credit batch, please check the examples from ACHCredit section.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIBatch.RestAsync(new GrpACH() {
    AccountType = Speakeasybar.Models.Shared.GrpACHAccountType.Savings,
    EleCheckAccountNumber = "125401754499",
    EleCheckRoutingNumber = "102000021",
    EleCheckServiceProvider = Speakeasybar.Models.Shared.GrpACHEleCheckServiceProvider.ElecCheckWEB,
    EleCheckTransactionType = Speakeasybar.Models.Shared.GrpACHEleCheckTransactionType.EleCheckConversion,
    TotalCreditAmt = "25000",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIBatchResponse](../../models/operations/RestAPIBatchResponse.md)**

