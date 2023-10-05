# APIv2GetTransInfoSDK
(*APIv2GetTransInfo*)

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
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2GetTransInfo.RestAsync(new RestAPIv2GetTransInfoRequest() {
    Gmid = "so Fantastic online",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = "Assistant",
    TerminalType = Gateway.Models.Shared.TerminalType.M6Plus,
    TransType = Gateway.Models.Shared.TransType.Refund,
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [RestAPIv2GetTransInfoRequest](../../models/operations/RestAPIv2GetTransInfoRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[RestAPIv2GetTransInfoResponse](../../models/operations/RestAPIv2GetTransInfoResponse.md)**

