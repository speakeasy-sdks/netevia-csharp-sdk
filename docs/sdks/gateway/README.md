# GatewaySDK
(*Gateway*)

### Available Operations

* [Transaction](#transaction) - Generic API.

## Transaction

Initiate a transaction request to Netevia Gateway.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
<hr>
<sup>1</sup>please refer to 'Examples' section for sample subsets  


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.Gateway.TransactionAsync(new GrpAmount() {
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

**[RestAPIResponse](../../models/operations/RestAPIResponse.md)**

