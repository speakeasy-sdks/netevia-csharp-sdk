# APIv2SDK
(*APIv2*)

### Available Operations

* [BatchAPIv2](#batchapiv2) - Generic batch query API.
* [RestAPIv2](#restapiv2) - Generic API.

## BatchAPIv2

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

var res = await sdk.APIv2.BatchAPIv2Async(new BatchAPIv2Request() {
    Gmid = "concerning Buckinghamshire",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpACH() {
        AccountType = Gateway.Models.Shared.GrpACHAccountType.Savings,
        EleCheckAccountNumber = "125401754499",
        EleCheckRoutingNumber = "102000021",
        EleCheckServiceProvider = Gateway.Models.Shared.GrpACHEleCheckServiceProvider.ElecCheckWEB,
        EleCheckTransactionType = Gateway.Models.Shared.GrpACHEleCheckTransactionType.EleCheckConversion,
        TotalCreditAmt = "25000",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.M6Plus,
    TransType = Gateway.Models.Shared.TransType.Sale,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [BatchAPIv2Request](../../models/operations/BatchAPIv2Request.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[BatchAPIv2Response](../../models/operations/BatchAPIv2Response.md)**


## RestAPIv2

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

var res = await sdk.APIv2.RestAPIv2Async(new RestAPIv2Request() {
    Gmid = "numquam Southeast",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpCardDataEncryption() {
        EncrptBlock = "male",
        EncrptTrgt = Gateway.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
        KeyID = "66257982464",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.M6Plus,
    TransType = Gateway.Models.Shared.TransType.Refund,
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [RestAPIv2Request](../../models/operations/RestAPIv2Request.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[RestAPIv2Response](../../models/operations/RestAPIv2Response.md)**

