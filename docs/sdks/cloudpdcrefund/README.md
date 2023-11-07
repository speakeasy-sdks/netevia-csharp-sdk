# CloudPDCRefund
(*.CloudPDCRefund*)

### Available Operations

* [Create](#create) - Initiate a Refund request.

## Create

Initiate a Refund request to Netevia Payment Device Controller.   
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;

var sdk = new Gateway();

var res = await sdk.CloudPDCRefund.CreateAsync("string");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[InitiateCloudPDCRefundResponse](../../models/operations/InitiateCloudPDCRefundResponse.md)**

