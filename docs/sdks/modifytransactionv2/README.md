# ModifyTransactionV2
(*ModifyTransactionV2*)

### Available Operations

* [Create](#create) - How to initiate Modify/Adjust/AddTip transaction requests.

## Create

Initiate a <b>Modify/Adjust/AddTip</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Modify</b> transaction is used to alter the transaction amount of an original transaction, Auth or Sale.<br>
<b>Adjust</b> transaction is used to alter the transaction amount of an original transaction whether or not it has been settled, Auth or Sale.
<b>AddTip</b> transaction is used to add an additional amount to an original transaction, Auth or Sale. If the original transaction is Auth, this operation transfers the Auth to Sale.<br>
<hr>
<sup>1</sup>Use the examples for different 'Modify' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.ModifyTransactionV2.CreateAsync(new RestAPIv2ModifyRequest() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [RestAPIv2ModifyRequest](../../Models/Operations/RestAPIv2ModifyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[RestAPIv2ModifyResponse](../../Models/Operations/RestAPIv2ModifyResponse.md)**

