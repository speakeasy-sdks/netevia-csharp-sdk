# APIv2TokenSDK
(*APIv2Token*)

### Available Operations

* [RestAPIv2Token](#restapiv2token) - How to initiate Token based transaction requests.

## RestAPIv2Token

Initiate <b>Token</b> based transaction requests to Netevia Gateway.<sup>1</sup><br>

*<span style="color:green">Valid actions:</span>*
---
___
- <span style="color:red">CreateCardToken</span>: is used to create card token.
- <span style="color:red">DeleteCardToken<sup>2</sup></span>: is used to delete exist card token.
- <span style="color:red">GetCardTokenInfo</span>: is used to retrieve card data(masked) linked to a token.
- <span style="color:red">UpdateCardTokenInfo</span>: is used to update card token information. It supports update ExpDate, CustomerAddress, CustomerZipCode.
<hr>
<sup>1</sup>Use the examples for different 'Token' flavours<br>
<sup>2</sup>Pay attention that calling this API will delete the provided 'CardToken'
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2Token.RestAPIv2TokenAsync(new RestAPIv2TokenRequest() {
    Gmid = "unhand Specialist Suriname",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpPIN() {
        Ksn = "FFFF6543210000A00029",
        PinBlock = "F652B46D04B5D191",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.M6Plus,
    TransType = Gateway.Models.Shared.TransType.GetSessionKey,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RestAPIv2TokenRequest](../../models/operations/RestAPIv2TokenRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RestAPIv2TokenResponse](../../models/operations/RestAPIv2TokenResponse.md)**

