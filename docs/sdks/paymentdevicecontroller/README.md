# PaymentDeviceController
(*PaymentDeviceController*)

### Available Operations

* [Create](#create) - Payment Device Controller - card reader device management API.

## Create

Payment Device Controller API, dedicated
*<span style="color:green">Valid actions:</span>*
---
___
- <span style="color:red">Register</span>: is used to associate Pin pad’s serial number with GMID/GTID. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">Unregister</span>: is used to unlink Pin pad’s serial number from GMID/GTID and de-activate GMID/GTID. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">GetStatus</span>: is used to judge whether Pin pad is available. We can use the API to get the device bound info as well. This transaction only supported in the EMV, QuickChip endpoint
- <span style="color:red">AskNumberQuestion</span>: is used to get user input on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">AskSelectionQuestion</span>: is used to get user selection results on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">ShowMessage</span>: is used to display message on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">UploadImage</span>: is used to upload image to the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">SetImageList</span>: is used to set up the index of images that need to be displayed on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">UploadMessage</span>: is used to permanently replace built-in message in Pin pad. Even if restart the Pin pad. A reboot is required following UploadMessage. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">ResetMessage</span>: is used to restore built-in message in Pin pad. A reboot is required following ResetMessage. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">RebootDevice</span>: is used to restart Pin pad. This transaction only supported in the EMV, QuickChip endpoint.
- <span style="color:red">UploadFile</span>: is used to upload the configuration files to the pin pad, preparing for entering tip value by pinpad. After uploading successfully, you’d better restart the pinpad. The configuration file named “CUSTPROMPT.PGZ” exists on our server. You can send the request message with your GMID,GTID and upload it.
- <span style="color:red">PrintReceipt</span>: is used for re-printing receipts. The request must contain the GTRC of the original transaction.
- <span style="color:red">ESignature</span>: is used for capturing client's electronic signature on request without performing a transaction.
- <span style="color:red">CardRead</span>: is used for reading Gift cards details.
<hr>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGenericPDC req = RequestGenericPDC.CreateRequestGenericPDCGrpCardInfoSchemas1(
    new GrpCardInfoSchemas1() {
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
);

var res = await sdk.PaymentDeviceController.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [RequestGenericPDC](../../Models/Shared/RequestGenericPDC.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |


### Response

**[ControlCloudPDCResponse](../../Models/Operations/ControlCloudPDCResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
