# TokenTransaction
(*TokenTransaction*)

### Available Operations

* [Create](#create) - How to initiate Token based transaction requests.

## Create

Initiate <b>Token</b> based transaction requests to Netevia Gateway.<sup>1</sup><br>

*<span style="color:green">Valid actions:</span>*
---
___
- <span style="color:red">CreateCardToken</span>: is used to create card token.
- <span style="color:red">DeleteCardToken<sup>2</sup></span>: is used to delete exist card token.
- <span style="color:red">GetCardTokenInfo</span>: is used to retrieve card data(masked) linked to a token.
- <span style="color:red">UpdateCardTokenInfo</span>: is used to update card token information. It supports update ExpDate, CustomerAddress, CustomerZipCode.
<hr>
<sup>1</sup>Use the examples for different 'Token' flavours<br>
<sup>2</sup>Pay attention that calling this API will delete the provided 'CardToken'
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;

var sdk = new Gateway();

object req = "<value>";

var res = await sdk.TokenTransaction.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[CardTokenResponse](../../Models/Operations/CardTokenResponse.md)**

