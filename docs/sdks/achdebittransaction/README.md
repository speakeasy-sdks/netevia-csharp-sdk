# ACHDebitTransactionSDK
(*ACHDebitTransaction*)

### Available Operations

* [Create](#create) - ACH Debit transactions.

## Create

Initiate an <b>ACH</b> debit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> debit transaction is used to allow customers to pay using checks. The data from the check is digitaly converted and the transaction is posted to the customer bank account.
<hr>
<sup>1</sup>Use the examples for different 'ACH Debit' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;

var sdk = new GatewaySDK();

var res = await sdk.ACHDebitTransaction.CreateAsync("string");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIACHDebitResponse](../../models/operations/RestAPIACHDebitResponse.md)**

