# Auth
(*Auth*)

### Available Operations

* [Finalize](#finalize) - How to initiate different Auth/Finalize transaction requests.

## Finalize

Initiate an <b>Auth/Finalize</b> transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>Auth</b> transaction places a temporary hold on the customer’s account. Approvals on authorizations are used later to transfer funds by Finalize or AddTip.<br>
A <b>Finalize</b> transaction is used to change an <b>Auth</b> transaction to a <b>Sale</b> transaction.
<hr>
<sup>1</sup>Use the examples for different 'Auth/Finalize' flavours 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;

var sdk = new Gateway();

object req = "string";

var res = await sdk.Auth.FinalizeAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIAuthResponse](../../Models/Operations/RestAPIAuthResponse.md)**

