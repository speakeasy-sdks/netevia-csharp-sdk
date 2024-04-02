# ACHCreditTransactionV2
(*ACHCreditTransactionV2*)

### Available Operations

* [Create](#create) - ACH Credit transactions.

## Create

Initiate an <b>ACH</b> credit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> credit transaction is used to allow merchants to pay using ACH and transfer money to other bank accounts.<br>
To be more generic and have a similar approach as for Debit ACH, we can also simulate the single PayOut call for a batch of payments with multiple individual credit transactions calls that will be approved offline by us and when batching happens we can generate the PayOut request to GMS as a single API call(batch file upload) as they require. Now GMS processor support.
<hr>
<sup>1</sup>Use the examples for different 'ACH Credit' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2ACHCreditRequest req = new RestAPIv2ACHCreditRequest() {
    Gmid = "<value>",
    TransType = TransType.Register,
    RequestGeneric = RequestGeneric.CreateRequestGenericGrpCardInfoSchemas(
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

var res = await sdk.ACHCreditTransactionV2.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RestAPIv2ACHCreditRequest](../../Models/Operations/RestAPIv2ACHCreditRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[RestAPIv2ACHCreditResponse](../../Models/Operations/RestAPIv2ACHCreditResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
