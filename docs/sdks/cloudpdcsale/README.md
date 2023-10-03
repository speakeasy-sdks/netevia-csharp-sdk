# CloudPDCSaleSDK
(*CloudPDCSale*)

### Available Operations

* [Initiate](#initiate) - Initiate a transaction request.

## Initiate

Initiate a transaction request to Netevia Payment Device Controller. For more samples please review the /restApi endpoint as all transaction types can be used also on this endpoint(without card data). 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.CloudPDCSale.InitiateAsync(new GrpCardDataEncryption() {
    EncrptBlock = "Towels Bacon stealthily",
    EncrptTrgt = Speakeasybar.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
    KeyID = "66257982464",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[InitiateCloudPDCSaleResponse](../../models/operations/InitiateCloudPDCSaleResponse.md)**

