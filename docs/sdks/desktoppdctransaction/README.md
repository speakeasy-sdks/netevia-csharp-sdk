# DesktopPDCTransaction
(*.DesktopPDCTransaction*)

### Available Operations

* [Create](#create) - Control desktop PDC through Netevia Server to complete the transaction.

## Create

All transaction type are support. use this way you can control desktop PDC to read card data.
Desktop PDC version need above 2.2.7. and you need add the websocket clinet configuration.


### Example Usage

```csharp
using Netevia;

var sdk = new Gateway();

var res = await sdk.DesktopPDCTransaction.CreateAsync("string");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[ControlDesktopPDCResponse](../../models/operations/ControlDesktopPDCResponse.md)**

