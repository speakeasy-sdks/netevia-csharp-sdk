# APIGetTransInfoSDK
(*APIGetTransInfo*)

### Available Operations

* [Rest](#rest) - How to initiate GetTransInfo transaction requests.

## Rest

Initiate a <b>GetTransInfo</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>GetTransInfo</b> transaction is used to query the transaction status by GTRC which was returned for the original transaction or by the Invoice Number used in the original request. 
<hr>
<sup>1</sup>Use the examples for different 'GetTransInfo' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.APIGetTransInfo.RestAsync(new GrpACH() {
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

**[RestAPIGetTransInfoResponse](../../models/operations/RestAPIGetTransInfoResponse.md)**

