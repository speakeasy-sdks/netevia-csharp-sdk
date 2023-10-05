# DesktopPDCv2SDK
(*DesktopPDCv2*)

### Available Operations

* [Control](#control) - Control desktop PDC through Netevia Server to complete the transaction.

## Control

All transaction type are support. use this way you can control desktop PDC to read card data.
Desktop PDC version need above 2.2.7. and you need add the websocket clinet configuration.


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.DesktopPDCv2.ControlAsync(new ControlDesktopPDCv2Request() {
    Gmid = "North Southwest Cotton",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = "Administrator",
    TerminalType = Gateway.Models.Shared.TerminalType.Pax,
    TransType = Gateway.Models.Shared.TransType.GetCardToken,
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ControlDesktopPDCv2Request](../../models/operations/ControlDesktopPDCv2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ControlDesktopPDCv2Response](../../models/operations/ControlDesktopPDCv2Response.md)**

