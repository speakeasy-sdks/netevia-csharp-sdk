# APIv2SDK
(*APIv2*)

### Available Operations

* [Batch](#batch) - Generic batch query API.
* [Rest](#rest) - Generic API.

## Batch

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
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2.BatchAsync(new BatchAPIv2Request() {
    Gmid = "Customer lumen liquor",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpExtendInfo() {
        AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
        AuthCode = "OK1234",
        InvoiceNum = "Inv123456",
        OrderNum = "Ord12345",
        VoucherNum = "Voucher12345",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Dejavoo,
    TransType = Gateway.Models.Shared.TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [BatchAPIv2Request](../../models/operations/BatchAPIv2Request.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[BatchAPIv2Response](../../models/operations/BatchAPIv2Response.md)**


## Rest

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

var res = await sdk.APIv2.RestAsync(new RestAPIv2Request() {
    Gmid = "so Fantastic online",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpEMV() {
        Emv42 = "Coupe mobile Chrysler",
        Emv4F = "Steel Hybrid lavender",
        Emv50 = "candid",
        Emv57 = "neural responsive Awesome",
        Emv5A = "Northwest",
        Emv5F20 = "bypassing",
        Emv5F24 = "Account close",
        Emv5F28 = "Hyundai olive",
        Emv5F2A = "empower before EXE",
        Emv5F2D = "purple solid array",
        Emv5F30 = "SSD",
        Emv5F34 = "optimize",
        Emv5F54 = "Audi",
        Emv5F55 = "programming ugh",
        Emv5F56 = "Rancho",
        Emv71 = "grow withdrawal",
        Emv72 = "Configurable Jaguar Dynamic",
        Emv82 = "1080p Account",
        Emv84 = "Ergonomic",
        Emv87 = "loyalty Architect",
        Emv8A = "gee Industrial",
        Emv8E = "Bromine",
        Emv91 = "iusto analog Identity",
        Emv95 = "Tuna",
        Emv9A = "ah",
        Emv9B = "Celsius Recycled Royce",
        Emv9C = "orchid Communications",
        Emv9F02 = "Volvo South circuit",
        Emv9F03 = "Van",
        Emv9F06 = "Account industrialise",
        Emv9F07 = "Diesel enable Diesel",
        Emv9F08 = "Polarised Delaware",
        Emv9F09 = "South Soap cultivate",
        Emv9F0B = "Audi Intelligent tolerance",
        Emv9F0D = "West Adventure",
        Emv9F0E = "female",
        Emv9F0F = "transmitter",
        Emv9F10 = "Pizza",
        Emv9F11 = "Unbranded Northwest Implementation",
        Emv9F12 = "States Flerovium payment",
        Emv9F14 = "Executive",
        Emv9F17 = "even valley",
        Emv9F1A = "sievert",
        Emv9F1B = "applications",
        Emv9F1E = "paradigms outlying",
        Emv9F1F = "Designer Victor ferociously",
        Emv9F20 = "violet",
        Emv9F21 = "unrealistic API kiddingly",
        Emv9F26 = "West Kia",
        Emv9F27 = "cow Carolina yellow",
        Emv9F33 = "Northwest",
        Emv9F34 = "magenta",
        Emv9F35 = "Reactive Accounts",
        Emv9F36 = "Road Expanded unrealistic",
        Emv9F37 = "er newton Minivan",
        Emv9F39 = "Money",
        Emv9F40 = "out Cotton Tricycle",
        Emv9F41 = "male asymmetric consectetur",
        Emv9F42 = "Berkshire beneath Handmade",
        Emv9F51 = "compress",
        Emv9F53 = "transform revolutionize female",
        Emv9F5B = "mobile deposit",
        Emv9F5D = "Tasty Wooden archive",
        Emv9F66 = "Reactive",
        Emv9F67 = "South",
        Emv9F6C = "flat Southeast",
        Emv9F6D = "RSS Androgyne",
        Emv9F6E = "by connect apropos",
        Emv9F71 = "Forward",
        Emv9F7C = "Berkshire narrow",
        Emvdf03 = "overriding",
        Emvdf04 = "fully CLI",
        Emvdf05 = "PNG",
        Emvdf11 = "um North vertical",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.None,
    TransType = Gateway.Models.Shared.TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [RestAPIv2Request](../../models/operations/RestAPIv2Request.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[RestAPIv2Response](../../models/operations/RestAPIv2Response.md)**

