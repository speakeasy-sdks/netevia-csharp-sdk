# CloudPDCRefundSDK
(*CloudPDCRefund*)

### Available Operations

* [Initiate](#initiate) - Initiate a Refund request.

## Initiate

Initiate a Refund request to Netevia Payment Device Controller.   
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCRefund.InitiateAsync("Touring");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[InitiateCloudPDCRefundResponse](../../models/operations/InitiateCloudPDCRefundResponse.md)**

