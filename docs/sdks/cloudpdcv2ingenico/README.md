# CloudPDCv2IngenicoSDK
(*CloudPDCv2Ingenico*)

### Available Operations

* [Control](#control) - Cloud Payment Device Controller - card reader device management API.

## Control

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
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.CloudPDCv2Ingenico.ControlAsync(new ControlCloudPDCv2IngenicoRequest() {
    Gmid = "North Southwest Cotton",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = "Administrator",
    TerminalType = Gateway.Models.Shared.TerminalType.Pax,
    TransType = Gateway.Models.Shared.TransType.GetCardToken,
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ControlCloudPDCv2IngenicoRequest](../../models/operations/ControlCloudPDCv2IngenicoRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ControlCloudPDCv2IngenicoResponse](../../models/operations/ControlCloudPDCv2IngenicoResponse.md)**

