# DesktopPDCTransactionV2
(*DesktopPDCTransactionV2*)

### Available Operations

* [Create](#create) - Control desktop PDC through Netevia Server to complete the transaction.

## Create

All transaction type are support. use this way you can control desktop PDC to read card data.
Desktop PDC version need above 2.2.7. and you need add the websocket clinet configuration.


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

ControlDesktopPDCv2Request req = new ControlDesktopPDCv2Request() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.DesktopPDCTransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ControlDesktopPDCv2Request](../../Models/Operations/ControlDesktopPDCv2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ControlDesktopPDCv2Response](../../Models/Operations/ControlDesktopPDCv2Response.md)**

