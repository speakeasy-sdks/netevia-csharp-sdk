# GiftTransactionV2
(*GiftTransactionV2*)

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
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2GiftRequest req = new RestAPIv2GiftRequest() {
    Gmid = "<value>",
    TransType = TransType.Register,
    RequestGeneric = Shared.CreateRequestGenericGrpCardInfoSchemas(
            new GrpCardInfoSchemas() {
                AccountNum = "5415244444444444",
                AllowsPartialAuth = SchemasGrpCardInfoAllowsPartialAuth.N,
                CVVNum = "123",
                CardToken = "18c9c75f28a04538939112fb109702fb",
                CheckDuplicate = SchemasGrpCardInfoCheckDuplicate.N,
                CreditOnFailure = SchemasGrpCardInfoCreditOnFailure.N,
                CustomerAddress = "Test Street 4",
                CustomerCity = "Miami",
                CustomerName = "John Doe",
                CustomerNum = "C91101",
                CustomerState = "Florida",
                CustomerZipCode = "12345",
                ExpDate = "1225",
                Gmid = "1110222484",
                Gmpw = "GMPW3010300378",
                Gtid = "GT1120095178",
                IgnoreAVSResult = SchemasGrpCardInfoIgnoreAVSResult.Y,
                IgnoreCVVResult = SchemasGrpCardInfoIgnoreCVVResult.Y,
                IgnoreVoidResult = SchemasGrpCardInfoIgnoreVoidResult.Y,
                IsOffline = SchemasGrpCardInfoIsOffline.N,
                Medium = SchemasMedium.Credit,
                PayAPI = SchemasPayAPI.GooglePay,
                Payload = "{\"signature\":\"MEMCIBD7zOfOintAG/gjg6XenH+x8uM//2b3L/i+GKlhOMtxAh89lRkECojoDHc/Ohis4hvivc2EtCNf/k69MWMCemBN\",\"intermediateSigningKey\":{\"signedKey\":\"{\\"keyValue\\":\\"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEq1r61W296dtgCNIJYS9KTl5bp8lMPjz7SDEjE5Zk27iiuane/oEZbOQYlF8YurHvitrLyFN9ROU8p+9Rts7feg\\u003d\\u003d\\",\\"keyExpiration\\":\\"1603261713365\\"}\",\"signatures\":[\"MEUCIQDnvLuziBPYWDmMuUR493lDMYoZYccEPi7sCYHC+EILkgIgacX5hiHoxxD7HRfm9xG9lYNHAoV5i2OaFpggArB0uwQ\u003d\"]},\"protocolVersion\":\"ECv2\",\"signedMessage\":\"{\\"encryptedMessage\\":\\"+Oc0tH5ZWHTyrUlxBOimgM1zyIeOEKJAf300KNBlTUUUU1RzswJMhXa6Ehc9haOTnfYdqcQRx+1f7ztnqbHujPfITzRCjTA8DPMHfYe/Z/MhPPZr9MIHubFjizenRU/tBjm6f/WuAjMj+CoDxDUwR7cD+ZMwAvYzyY5A3hBG/iJrJfqvYcF2g9GNZFwYI4MsgrYh8SM4tViEVr//B4AxSGNiCp8Utgyy7qilRWcViEzl/t2cqXxK9p4lG7xkN+nC4qOcNTwtQASmX3WqUA2nt3yb7J9t84iAKYIFvWxdiHLonxs89bfanpgLW9ZG4Dt2YycGZo3+wVbCFDzQ8MlzM+ibTXifaTYyWWIEEZFrm3nkVQxsu337VGUdtA60uM8GxawG7zARWeoE+6wC+E2G6kUyXYybm5IBDXQMYWprjhWLyAB1D+bjXzldcG8rUvbk2zHzzg4BEf36kzHwqmCWiuxKKtzGTZce5XQqF1Jd8p9c/Gc\\u003d\\",\\"ephemeralPublicKey\\":\\"BGJ+y+S+rQ+6IywwstXdh2nzHwP3LKcvI58XAN3LW3PoSNlWuNluRJ6cJ3dn7XP6dl+m2y8SuzXFxelPspg8moY\\u003d\\",\\"tag\\":\\"v8r09doA5qKuA8SeLuQVgKCsJxdorUgoj/Rmh0/5MLk\\u003d\\"}\"}",
                Track1 = "B5413330089020029^MTIP02^2512629807900000000000000000",
                Track2 = "5413330000000000=2512101123456789",
                TransType = SchemasGrpCardInfoTransType.Sale,
                VerifyCard = SchemasGrpCardInfoVerifyCard.N,
            },
    ),
};

var res = await sdk.GiftTransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [RestAPIv2GiftRequest](../../Models/Operations/RestAPIv2GiftRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[RestAPIv2GiftResponse](../../Models/Operations/RestAPIv2GiftResponse.md)**

