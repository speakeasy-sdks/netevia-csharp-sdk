# DesktopPDCTransactionV2SDK
(*DesktopPDCTransactionV2*)

### Available Operations

* [Create](#create) - Control desktop PDC through Netevia Server to complete the transaction.

## Create

All transaction type are support. use this way you can control desktop PDC to read card data.
Desktop PDC version need above 2.2.7. and you need add the websocket clinet configuration.


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.DesktopPDCTransactionV2.CreateAsync(new ControlDesktopPDCv2Request() {
    Gmid = "string",
    RequestBody = "string",
    TransType = Gateway.Models.Shared.TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ControlDesktopPDCv2Request](../../models/operations/ControlDesktopPDCv2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ControlDesktopPDCv2Response](../../models/operations/ControlDesktopPDCv2Response.md)**

