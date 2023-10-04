# CloudPDCv2IngenicoSDK
(*CloudPDCv2Ingenico*)

### Available Operations

* [ControlCloudPDCv2Ingenico](#controlcloudpdcv2ingenico) - Cloud Payment Device Controller - card reader device management API.

## ControlCloudPDCv2Ingenico

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

var res = await sdk.CloudPDCv2Ingenico.ControlCloudPDCv2IngenicoAsync(new ControlCloudPDCv2IngenicoRequest() {
    Gmid = "payment pascal City",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.Y,
    RequestBody = new GrpEMV() {
        Emv42 = "gripper",
        Emv4F = "tan commonly Cambridgeshire",
        Emv50 = "Frozen",
        Emv57 = "Bedfordshire copy DRAM",
        Emv5A = "generating grey",
        Emv5F20 = "tan brick digital",
        Emv5F24 = "unfortunately Licensed",
        Emv5F28 = "Northwest",
        Emv5F2A = "pascal calculating",
        Emv5F2D = "calculate Executive BMW",
        Emv5F30 = "Smart",
        Emv5F34 = "lumen Bespoke immaculate",
        Emv5F54 = "bus bandwidth",
        Emv5F55 = "Sedan male Advanced",
        Emv5F56 = "Program Account siemens",
        Emv71 = "turquoise North",
        Emv72 = "Northwest users",
        Emv82 = "Oklahoma sprint female",
        Emv84 = "Oregon and Infrastructure",
        Emv87 = "Ferrari cyan",
        Emv8A = "ivory UTF8",
        Emv8E = "Tools female Californium",
        Emv91 = "auxiliary",
        Emv95 = "on optical Chair",
        Emv9A = "Dynamic Jeep Visionary",
        Emv9B = "West Gadolinium Lane",
        Emv9C = "grow Touring South",
        Emv9F02 = "Practical Northeast Account",
        Emv9F03 = "And Gender",
        Emv9F06 = "inside quas",
        Emv9F07 = "Porsche oh",
        Emv9F08 = "purple Oklahoma Hat",
        Emv9F09 = "haptic envisioneer Car",
        Emv9F0B = "Grocery North Bacon",
        Emv9F0D = "Peso Manager Nissan",
        Emv9F0E = "parsing",
        Emv9F0F = "generate awareness",
        Emv9F10 = "redefine Response Xenogender",
        Emv9F11 = "meaningfully Wooden Concrete",
        Emv9F12 = "Southeast",
        Emv9F14 = "input pomelo",
        Emv9F17 = "male",
        Emv9F1A = "Zimbabwe yahoo",
        Emv9F1B = "Bronze veniam",
        Emv9F1E = "Officer Meitnerium",
        Emv9F1F = "North Soul intend",
        Emv9F20 = "Unbranded programming",
        Emv9F21 = "Customer East intranet",
        Emv9F26 = "Tennessee",
        Emv9F27 = "Oak unto Ford",
        Emv9F33 = "XML Botswana sticky",
        Emv9F34 = "Ohio Web wherever",
        Emv9F35 = "opposite perferendis Rhodium",
        Emv9F36 = "Polynesia Soft male",
        Emv9F37 = "Southeast Market JBOD",
        Emv9F39 = "azure interface virtual",
        Emv9F40 = "enim",
        Emv9F41 = "Future Tricycle South",
        Emv9F42 = "blue Xenon",
        Emv9F51 = "Handmade",
        Emv9F53 = "hack Southeast firewall",
        Emv9F5B = "furthermore Berkshire indeed",
        Emv9F5D = "Wyoming than",
        Emv9F66 = "Borders Industrial",
        Emv9F67 = "violet female whoa",
        Emv9F6C = "optimizing",
        Emv9F6D = "Buckinghamshire Games output",
        Emv9F6E = "hacking Southwest Principal",
        Emv9F71 = "female Honda",
        Emv9F7C = "generating",
        Emvdf03 = "mean Tools Soft",
        Emvdf04 = "gold",
        Emvdf05 = "blah",
        Emvdf11 = "runny Northwest",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.None,
    TransType = Gateway.Models.Shared.TransType.Auth,
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ControlCloudPDCv2IngenicoRequest](../../models/operations/ControlCloudPDCv2IngenicoRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ControlCloudPDCv2IngenicoResponse](../../models/operations/ControlCloudPDCv2IngenicoResponse.md)**

