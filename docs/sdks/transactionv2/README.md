# TransactionV2SDK
(*TransactionV2*)

### Available Operations

* [Create](#create) - Generic API.

## Create

Initiate a transaction request to Netevia Gateway.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
<hr>
<sup>1</sup>please refer to 'Examples' section for sample subsets  


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.TransactionV2.CreateAsync(new RestAPIv2Request() {
    Gmid = "bluetooth Extended",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpCardDataEncryption() {
        EncrptBlock = "shred",
        EncrptTrgt = Gateway.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
        KeyID = "66257982464",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.WinPDC,
    TransType = Gateway.Models.Shared.TransType.GetSessionKey,
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [RestAPIv2Request](../../models/operations/RestAPIv2Request.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[RestAPIv2Response](../../models/operations/RestAPIv2Response.md)**

