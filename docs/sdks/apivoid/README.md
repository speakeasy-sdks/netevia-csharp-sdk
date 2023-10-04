# APIVoidSDK
(*APIVoid*)

### Available Operations

* [RestAPIVoid](#restapivoid) - How to initiate Void/Reverse/Cancel transaction requests.

## RestAPIVoid

Initiate a <b>Void/Reverse/Cancel</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Void</b> transaction is used to cancel an authorized transaction before it has been settled.<br>
<b>Reverse</b> transaction is used to cancel an authorized transaction whether or not it has been settled.<br>
<b>Cancel</b> transaction is used to cancel an authorized transaction before it has been settled.
<hr>
<sup>1</sup>Use the examples for different 'Void/Reverse/Cancel' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIVoid.RestAPIVoidAsync(new GrpExtendInfo() {
    AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
    AuthCode = "OK1234",
    InvoiceNum = "Inv123456",
    OrderNum = "Ord12345",
    VoucherNum = "Voucher12345",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIVoidResponse](../../models/operations/RestAPIVoidResponse.md)**

