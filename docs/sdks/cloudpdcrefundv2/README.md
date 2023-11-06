# CloudPDCRefundv2SDK
(*CloudPDCRefundv2*)

### Available Operations

* [Create](#create) - Initiate a Refund request.

## Create

Initiate a Refund request to Netevia Payment Device Controller.   
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCRefundv2.CreateAsync(new InitiateCloudPDCv2RefundRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = Gateway.Models.Shared.TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [InitiateCloudPDCv2RefundRequest](../../models/operations/InitiateCloudPDCv2RefundRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[InitiateCloudPDCv2RefundResponse](../../models/operations/InitiateCloudPDCv2RefundResponse.md)**

