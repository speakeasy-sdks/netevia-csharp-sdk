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

var sdk = new Gateway();

var res = await sdk.QRPayTransaction.CreateAsync("string");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[IntegrateQRPayResponse](../../Models/Operations/IntegrateQRPayResponse.md)**

