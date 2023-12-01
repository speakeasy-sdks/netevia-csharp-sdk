# GPayTransaction
(*GPayTransaction*)

### Available Operations

* [Create](#create) - Google Pay ™.

## Create

It support GPay, the transasction type same with restApi, but the request must container Payload and PayAPI item.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
***<span style="color:green">Valid actions:</span>***  
<hr>
<sup>1</sup>please refer to 'samples' section for sample subsets 
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;

var sdk = new Gateway();

object req = "string";

var res = await sdk.GPayTransaction.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestGPayResponse](../../Models/Operations/RestGPayResponse.md)**

