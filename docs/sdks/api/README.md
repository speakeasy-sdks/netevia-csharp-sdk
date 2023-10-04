# ApiSDK
(*Api*)

### Available Operations

* [BatchAPI](#batchapi) - Generic batch query API.
* [RestAPI](#restapi) - Generic API.

## BatchAPI

Initiate a batch query request to Netevia Gateway.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
***<span style="color:green">Valid actions:</span>***  
---  
___
- <span style="color:red">BatchLookup</span> : is used to get the batch ID by batch date.  If the BatchDate is omitted, the open/current batch is returned. Then the batch ID can be used in BatchQuery API to get more info for that batch.  
- <span style="color:red">BatchQuery</span> : is used to query transaction list by batch ID.  
<hr>
<sup>1</sup>please refer to 'samples' section for sample subsets 


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.Api.BatchAPIAsync(new GrpAmount() {
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

**[BatchAPIResponse](../../models/operations/BatchAPIResponse.md)**


## RestAPI

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

var res = await sdk.Api.RestAPIAsync(new GrpExtendInfo() {
    AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
    AuthCode = "OK1234",
    InvoiceNum = "Inv123456",
    OrderNum = "Ord12345",
    VoucherNum = "Voucher12345",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIResponse](../../models/operations/RestAPIResponse.md)**

