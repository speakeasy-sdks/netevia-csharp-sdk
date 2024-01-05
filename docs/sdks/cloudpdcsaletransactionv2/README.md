# CloudPDCSaleTransactionV2
(*CloudPDCSaleTransactionV2*)

### Available Operations

* [Create](#create) - Initiate a transaction request.

## Create

Initiate a transaction request to Netevia Payment Device Controller. For more samples please review the /restApi endpoint as all transaction types can be used also on this endpoint(without card data). 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

InitiateCloudPDCv2SaleRequest req = new InitiateCloudPDCv2SaleRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.CloudPDCSaleTransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [InitiateCloudPDCv2SaleRequest](../../Models/Operations/InitiateCloudPDCv2SaleRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[InitiateCloudPDCv2SaleResponse](../../Models/Operations/InitiateCloudPDCv2SaleResponse.md)**

