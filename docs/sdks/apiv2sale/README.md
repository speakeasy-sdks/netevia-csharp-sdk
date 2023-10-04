# APIv2SaleSDK
(*APIv2Sale*)

### Available Operations

* [RestAPIv2Sale](#restapiv2sale) - How to initiate different Sale transaction requests.

## RestAPIv2Sale

Initiate a <b>Sale</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Sale</b> transaction authorizes a sale purchased. This action decreases the cardholder's limit to buy. It authorizes a transfer of funds from the cardholder's account to merchant's account.
<hr>
<sup>1</sup>Use the examples for different 'Sale' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2Sale.RestAPIv2SaleAsync(new RestAPIv2SaleRequest() {
    Gmid = "Neck Industrial bunker",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpLvl3() {
        BusinessRefNum = "M12345678",
        CommercialL3 = Gateway.Models.Shared.GrpLvl3CommercialL3.N,
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
    },
    TerminalType = Gateway.Models.Shared.TerminalType.M6Plus,
    TransType = Gateway.Models.Shared.TransType.BatchQuery,
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2SaleRequest](../../models/operations/RestAPIv2SaleRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2SaleResponse](../../models/operations/RestAPIv2SaleResponse.md)**

