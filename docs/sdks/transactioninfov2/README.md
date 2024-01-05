# TransactionInfoV2
(*TransactionInfoV2*)

### Available Operations

* [Create](#create) - How to initiate GetTransInfo transaction requests.

## Create

Initiate a <b>GetTransInfo</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>GetTransInfo</b> transaction is used to query the transaction status by GTRC which was returned for the original transaction or by the Invoice Number used in the original request. 
<hr>
<sup>1</sup>Use the examples for different 'GetTransInfo' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2GetTransInfoRequest req = new RestAPIv2GetTransInfoRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.TransactionInfoV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [RestAPIv2GetTransInfoRequest](../../Models/Operations/RestAPIv2GetTransInfoRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[RestAPIv2GetTransInfoResponse](../../Models/Operations/RestAPIv2GetTransInfoResponse.md)**

