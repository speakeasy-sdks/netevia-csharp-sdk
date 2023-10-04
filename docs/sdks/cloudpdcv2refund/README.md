# CloudPDCv2RefundSDK
(*CloudPDCv2Refund*)

### Available Operations

* [InitiateCloudPDCv2Refund](#initiatecloudpdcv2refund) - Initiate a Refund request.

## InitiateCloudPDCv2Refund

Initiate a Refund request to Netevia Payment Device Controller.   
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCv2Refund.InitiateCloudPDCv2RefundAsync(new InitiateCloudPDCv2RefundRequest() {
    Gmid = "ivory purple",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpCardInfo() {
        AccountNum = "5415244444444444",
        CVVNum = "123",
        CardPresent = Gateway.Models.Shared.GrpCardInfoCardPresent.Y,
        CardToken = "18c9c75f28a04538939112fb109702fb",
        CommercialCard = Gateway.Models.Shared.GrpCardInfoCommercialCard.Y,
        CustomerAddress = "Test Street 4",
        CustomerCity = "Miami",
        CustomerName = "John Doe",
        CustomerNum = "C91101",
        CustomerState = "Florida",
        CustomerZipCode = "12345",
        EntryMode = Gateway.Models.Shared.GrpCardInfoEntryMode.Proximity,
        ExpDate = "1225",
        Medium = Gateway.Models.Shared.GrpCardInfoMedium.Credit,
        PayAPI = Gateway.Models.Shared.GrpCardInfoPayAPI.GooglePay,
        Payload = "{\"signature\":\"MEMCIBD7zOfOintAG/gjg6XenH+x8uM//2b3L/i+GKlhOMtxAh89lRkECojoDHc/Ohis4hvivc2EtCNf/k69MWMCemBN\",\"intermediateSigningKey\":{\"signedKey\":\"{\\"keyValue\\":\\"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEq1r61W296dtgCNIJYS9KTl5bp8lMPjz7SDEjE5Zk27iiuane/oEZbOQYlF8YurHvitrLyFN9ROU8p+9Rts7feg\\u003d\\u003d\\",\\"keyExpiration\\":\\"1603261713365\\"}\",\"signatures\":[\"MEUCIQDnvLuziBPYWDmMuUR493lDMYoZYccEPi7sCYHC+EILkgIgacX5hiHoxxD7HRfm9xG9lYNHAoV5i2OaFpggArB0uwQ\u003d\"]},\"protocolVersion\":\"ECv2\",\"signedMessage\":\"{\\"encryptedMessage\\":\\"+Oc0tH5ZWHTyrUlxBOimgM1zyIeOEKJAf300KNBlTUUUU1RzswJMhXa6Ehc9haOTnfYdqcQRx+1f7ztnqbHujPfITzRCjTA8DPMHfYe/Z/MhPPZr9MIHubFjizenRU/tBjm6f/WuAjMj+CoDxDUwR7cD+ZMwAvYzyY5A3hBG/iJrJfqvYcF2g9GNZFwYI4MsgrYh8SM4tViEVr//B4AxSGNiCp8Utgyy7qilRWcViEzl/t2cqXxK9p4lG7xkN+nC4qOcNTwtQASmX3WqUA2nt3yb7J9t84iAKYIFvWxdiHLonxs89bfanpgLW9ZG4Dt2YycGZo3+wVbCFDzQ8MlzM+ibTXifaTYyWWIEEZFrm3nkVQxsu337VGUdtA60uM8GxawG7zARWeoE+6wC+E2G6kUyXYybm5IBDXQMYWprjhWLyAB1D+bjXzldcG8rUvbk2zHzzg4BEf36kzHwqmCWiuxKKtzGTZce5XQqF1Jd8p9c/Gc\\u003d\\",\\"ephemeralPublicKey\\":\\"BGJ+y+S+rQ+6IywwstXdh2nzHwP3LKcvI58XAN3LW3PoSNlWuNluRJ6cJ3dn7XP6dl+m2y8SuzXFxelPspg8moY\\u003d\\",\\"tag\\":\\"v8r09doA5qKuA8SeLuQVgKCsJxdorUgoj/Rmh0/5MLk\\u003d\\"}\"}",
        RequestCardToken = Gateway.Models.Shared.GrpCardInfoRequestCardToken.Y,
        Track1 = "B5413330089020029^MTIP02^2512629807900000000000000000",
        Track2 = "5413330000000000=2512101123456789",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.None,
    TransType = Gateway.Models.Shared.TransType.UpdateCardTokenInfo,
});

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [InitiateCloudPDCv2RefundRequest](../../models/operations/InitiateCloudPDCv2RefundRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[InitiateCloudPDCv2RefundResponse](../../models/operations/InitiateCloudPDCv2RefundResponse.md)**

