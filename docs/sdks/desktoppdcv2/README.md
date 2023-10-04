# DesktopPDCv2SDK
(*DesktopPDCv2*)

### Available Operations

* [ControlDesktopPDCv2](#controldesktoppdcv2) - Control desktop PDC through Netevia Server to complete the transaction.

## ControlDesktopPDCv2

All transaction type are support. use this way you can control desktop PDC to read card data.
Desktop PDC version need above 2.2.7. and you need add the websocket clinet configuration.


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.DesktopPDCv2.ControlDesktopPDCv2Async(new ControlDesktopPDCv2Request() {
    Gmid = "invoice Road Glen",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpTrace() {
        Gtrc = "e134bff9203f44e8974a11b2aef7665d",
        NewGTRC = "fe31047eca6b47f2a07ead29be5a7672",
        SourceTraceNum = "123456",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Pax,
    TransType = Gateway.Models.Shared.TransType.SelBatch,
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ControlDesktopPDCv2Request](../../models/operations/ControlDesktopPDCv2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ControlDesktopPDCv2Response](../../models/operations/ControlDesktopPDCv2Response.md)**

