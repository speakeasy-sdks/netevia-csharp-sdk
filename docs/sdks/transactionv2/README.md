# TransactionV2
(*TransactionV2*)

### Available Operations

* [Create](#create) - Generic API.

## Create

Initiate a transaction request to Netevia Gateway.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
<hr>
<sup>1</sup>please refer to 'Examples' section for sample subsets  


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2Request req = new RestAPIv2Request() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.TransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [RestAPIv2Request](../../Models/Operations/RestAPIv2Request.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[RestAPIv2Response](../../Models/Operations/RestAPIv2Response.md)**

