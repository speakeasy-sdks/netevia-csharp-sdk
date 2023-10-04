# APIGetTransInfoSDK
(*APIGetTransInfo*)

### Available Operations

* [RestAPIGetTransInfo](#restapigettransinfo) - How to initiate GetTransInfo transaction requests.

## RestAPIGetTransInfo

Initiate a <b>GetTransInfo</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>GetTransInfo</b> transaction is used to query the transaction status by GTRC which was returned for the original transaction or by the Invoice Number used in the original request. 
<hr>
<sup>1</sup>Use the examples for different 'GetTransInfo' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIGetTransInfo.RestAPIGetTransInfoAsync(new GrpAmount() {
    IncCashBackAmt = 10000,
    IncTaxAmt = 10000,
    MainAmt = 10000,
    TaxIndicator = Gateway.Models.Shared.GrpAmountTaxIndicator.Ntprvd,
    TipAmt = 10000,
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIGetTransInfoResponse](../../models/operations/RestAPIGetTransInfoResponse.md)**

