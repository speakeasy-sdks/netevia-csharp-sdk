# APIAuthSDK
(*APIAuth*)

### Available Operations

* [RestAPIAuth](#restapiauth) - How to initiate different Auth/Finalize transaction requests.

## RestAPIAuth

Initiate an <b>Auth/Finalize</b> transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>Auth</b> transaction places a temporary hold on the customer’s account. Approvals on authorizations are used later to transfer funds by Finalize or AddTip.<br>
A <b>Finalize</b> transaction is used to change an <b>Auth</b> transaction to a <b>Sale</b> transaction.
<hr>
<sup>1</sup>Use the examples for different 'Auth/Finalize' flavours 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIAuth.RestAPIAuthAsync(new GrpCardDataEncryption() {
    EncrptBlock = "dimly whether",
    EncrptTrgt = Gateway.Models.Shared.GrpCardDataEncryptionEncrptTrgt.Pan,
    KeyID = "66257982464",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIAuthResponse](../../models/operations/RestAPIAuthResponse.md)**

