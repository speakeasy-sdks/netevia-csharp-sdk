# CloudPDCSaleSDK
(*CloudPDCSale*)

### Available Operations

* [InitiateCloudPDCSale](#initiatecloudpdcsale) - Initiate a transaction request.

## InitiateCloudPDCSale

Initiate a transaction request to Netevia Payment Device Controller. For more samples please review the /restApi endpoint as all transaction types can be used also on this endpoint(without card data). 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCSale.InitiateCloudPDCSaleAsync(new GrpLvl3() {
    BusinessRefNum = "M12345678",
    CommercialL3 = Gateway.Models.Shared.GrpLvl3CommercialL3.Y,
    CustomerRefNum = "C1234",
    DestContryCode = "840",
    DestZIPCode = "85284",
    InvoiceNum = "3434343434343",
    Item1 = new GrpLvl3Item() {
        ItemCommodityCode = "UPC 1",
        ItemDescription = "VI ITEM 1",
        ItemDiscount = "0",
        ItemProductionCode = "MATERIAL 1",
        ItemQuantity = "10000",
        ItemTaxAmt = "0",
        ItemTaxRate = "0",
        ItemTotalAmt = "0",
        ItemUnit = "EAC",
        ItemUnitCost = "21",
    },
    ItemCount = 2,
    LocalTaxAmt = 10000,
    LocalTaxIncludedFlag = Gateway.Models.Shared.GrpLvl3LocalTaxIncludedFlag.Zero,
    NationalTaxAmt = 10000,
    OrderDate = "190303",
    ShipZIP = "85284",
    SummaryCommodityCode = "COMC",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[InitiateCloudPDCSaleResponse](../../models/operations/InitiateCloudPDCSaleResponse.md)**

