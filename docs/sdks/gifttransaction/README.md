# GiftTransaction
(*GiftTransaction*)

### Available Operations

* [Create](#create) - Gitf transactions.

## Create

Initiate a <b>Gift</b> credit transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Gift</b> transaction is used to allow Account to pay using Gift and transfer money or points to merchnat.<br>
Available processors: <b>Givex</b>.<br>
The supported transaction types.<br>
<ul>
<li>Activation: this service enables a merchant to activate a Givex certificate for a certain value once it has been sold. </li>
<li>Inquiry: perform a card balance lookup, BalanceAmt and PointsBalance will be returned in a successful response.</li>
<li>Auth: reserve some or all of a card's balance for settle at a later time. please use Finalize to settle. After 7 days will be auto closed. </li>
<li>Sale: decrement all or part of the value of an existing certificate.</li>
<li>AddValue: add value to an existing certificate.</li>
<li>AdjustUp: add value to an existing certificate, the action cannot be voided. </li>
<li>AdjustDown: decrement value to an existing certificate, the action cannot be voided.</li>
<li>Finalize: complete a pre-auth and redeem the reserved funds.</li>
<li>Void: to void the original action.</li>
<li>Refund:  add value in a consumer comp or merchandise credit scenario at the front line. </li>
<li>PointsIssue: use for issuing points as part of a loyalty program.</li>
<li>PointsRedemption: use for redeeming points as part of a loyalty program.</li>
<li>PointsReduction: use for reducing points as part of a loyalty program. the points transaciton reference pre-defined formulas setup on the processor host through the promo code specified. The formula will caculate the amount of points to reduce based on the amount and promo code provided.</li>
<li>PointsVoid: void point action.</li>
</ul>
<hr>
New fields
<ul>
<li>SecurityCode: The securityCode is to validate the PIN value for the existing card</li>
<li>PromoCode: used for points issuance service, it needs to be set in the Givex system before using it.</li>
<li>Units: used for points issuance service</li>
<li>SKUItems: used for SKU base Scenes, Netevia format is SKU#:Amount:QTY example:"SKUItems":"5:500:2,2:275:1"</li>
</ul>
<hr>
<sup>1</sup>Use the examples for different 'Gift' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;

var sdk = new Gateway();

object req = "string";

var res = await sdk.GiftTransaction.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPIGiftResponse](../../Models/Operations/RestAPIGiftResponse.md)**

