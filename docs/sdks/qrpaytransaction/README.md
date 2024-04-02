# QRPayTransaction
(*QRPayTransaction*)

### Available Operations

* [Create](#create) - Integrated QRPay API interface

## Create

QRPay flow char <br>
<img src="https://testlink.c9pg.com/images/QRPayImages/Image_QRPay.png"> 
Notes: FrontEndSystem is a system for initiating transaction orders, because there is no card number, need to scan the QR code to complete the entire transaction.
<br/>
<br/>
The supported transaction types.<br>
<ul>
<li>CreateQRCode: Frontend system ask QRPay server create pre-order with transaction info. For this api have the option fields(QRCodeFormat,QRCodeType,NotificationCallback, ExpirtionTime). if the default is not good for you then you need set the value in the request.

</li>
<li>GetQRPayInfo: Inquriy order info from QRPay server.</li>
<li>QRPaySale: WalletApp got user card number then do payments. </li>
<li>GetQRPayResult : The Api is use to inquiry the pay results, it have a option field NotificationCallback, if frontend system using async call then please set the value, default is empty.</li>
<li>NotifyQRPayResult: QRPay server ntofiy pay results to the connect terminal. import, please set the NotificationCallback field in the CreateQRCode request </li>
</ul>
<hr>
New fields
<ul>
<li>QRCodeFormat: Specify the QR code format text and image(svg), text is the default, if you request image, please set the value to svg now, future will support more image type.</li>
<li>QRCodeType: Specify the QR code type static and dynamic, dynamic QR code will only used one time, static QR code can used multiple times, dynamic is the default. In order to avoid repetitive creation of static QR codes, we will check the repetition according to the fields of GMID, GTID, MainAmt, TipAmt, InvoiceNumber. If there are duplicate creations, we will return the last valid static QR code.</li>
</li>
<li>QRCodeContext: the QR Code context will returned by QRServer. it is a url, the url like this pattern(https://gatewayapidocs.netevia.com/qrpay?GTRC=UUID). if the QRCodeFormat is text then the context is the true url, if the QRCodeFormat is image then the context is the URL of QRCode image with the format that you specified.
</li>
<li>
ExpirtionTime: This field specifies the validity period of the QRCode in minutes. If there is no expiration time, please set it to N, The default is 15 minutes.
</li>
<li>
NotificationCallback: Optional field. If you need to obtain the payment result asynchronously, please set this parameter.
</li>
</ul>
<hr>
<sup>1</sup>Use the examples for different 'TransType' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGeneric req = RequestGeneric.CreateRequestGenericGrpCardInfoSchemas(
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
);

var res = await sdk.QRPayTransaction.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [RequestGeneric](../../Models/Shared/RequestGeneric.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[IntegrateQRPayResponse](../../Models/Operations/IntegrateQRPayResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
