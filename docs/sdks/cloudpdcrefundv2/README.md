# CloudPDCRefundv2
(*CloudPDCRefundv2*)

### Available Operations

* [Create](#create) - Initiate a Refund request.

## Create

Initiate a Refund request to Netevia Payment Device Controller.   
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

InitiateCloudPDCv2RefundRequest req = new InitiateCloudPDCv2RefundRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.CloudPDCRefundv2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [InitiateCloudPDCv2RefundRequest](../../Models/Operations/InitiateCloudPDCv2RefundRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[InitiateCloudPDCv2RefundResponse](../../Models/Operations/InitiateCloudPDCv2RefundResponse.md)**

