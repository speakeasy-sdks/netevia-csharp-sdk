# SaleTransactionSDK
(*SaleTransaction*)

### Available Operations

* [Create](#create) - How to initiate different Sale transaction requests.

## Create

Initiate a <b>Sale</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Sale</b> transaction authorizes a sale purchased. This action decreases the cardholder's limit to buy. It authorizes a transfer of funds from the cardholder's account to merchant's account.
<hr>
<sup>1</sup>Use the examples for different 'Sale' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;

var sdk = new GatewaySDK();

var res = await sdk.SaleTransaction.CreateAsync("string");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPISaleResponse](../../models/operations/RestAPISaleResponse.md)**

