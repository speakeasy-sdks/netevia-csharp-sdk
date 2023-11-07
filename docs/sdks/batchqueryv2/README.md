# BatchQueryV2
(*.BatchQueryV2*)

### Available Operations

* [Create](#create) - Generic batch query API.

## Create

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
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.BatchQueryV2.CreateAsync(new BatchAPIv2Request() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [BatchAPIv2Request](../../models/operations/BatchAPIv2Request.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[BatchAPIv2Response](../../models/operations/BatchAPIv2Response.md)**

