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
    RequestBody = new GrpEMV() {
        Emv42 = "Reggae Hybrid",
        Emv4F = "program",
        Emv50 = "South back Auto",
        Emv57 = "Carolina",
        Emv5A = "Protactinium",
        Emv5F20 = "Handcrafted",
        Emv5F24 = "North Rolls Michigan",
        Emv5F28 = "Car",
        Emv5F2A = "Principal sad",
        Emv5F2D = "scalable",
        Emv5F30 = "Officer digital",
        Emv5F34 = "Intersex methodologies hard",
        Emv5F54 = "Frozen Minivan",
        Emv5F55 = "mmm unlike white",
        Emv5F56 = "Rolls Customer Hatchback",
        Emv71 = "override",
        Emv72 = "architect gold",
        Emv82 = "mindshare Pants",
        Emv84 = "ubiquitous",
        Emv87 = "Home Jewelery empowering",
        Emv8A = "Health Central Intranet",
        Emv8E = "however bypassing",
        Emv91 = "Loan payment AGP",
        Emv95 = "override Response",
        Emv9A = "Potassium bluetooth",
        Emv9B = "organisation",
        Emv9C = "groupware",
        Emv9F02 = "efficiency",
        Emv9F03 = "National",
        Emv9F06 = "Chief",
        Emv9F07 = "West",
        Emv9F08 = "Engineer",
        Emv9F09 = "stable THX",
        Emv9F0B = "contingency East",
        Emv9F0D = "carotene",
        Emv9F0E = "meter HDD Creative",
        Emv9F0F = "Facilitator",
        Emv9F10 = "Germanium",
        Emv9F11 = "North Soul once",
        Emv9F12 = "male",
        Emv9F14 = "up",
        Emv9F17 = "Bicycle vice",
        Emv9F1A = "Minnesota pink",
        Emv9F1B = "Bedfordshire visualize invoice",
        Emv9F1E = "Aluminium Incredible",
        Emv9F1F = "below Sparks",
        Emv9F20 = "Pop",
        Emv9F21 = "Applications methodical",
        Emv9F26 = "North about",
        Emv9F27 = "Credit",
        Emv9F33 = "Web Xenon Assistant",
        Emv9F34 = "redundant auxiliary Developer",
        Emv9F35 = "Directives",
        Emv9F36 = "matrix",
        Emv9F37 = "Bronze",
        Emv9F39 = "West Hong Garden",
        Emv9F40 = "psst SMS",
        Emv9F41 = "Hybrid",
        Emv9F42 = "easily system",
        Emv9F51 = "orange Isle scarcely",
        Emv9F53 = "New Intuitive",
        Emv9F5B = "Soap ivory",
        Emv9F5D = "port",
        Emv9F66 = "regarding",
        Emv9F67 = "fuga red",
        Emv9F6C = "North",
        Emv9F6D = "Androgyne",
        Emv9F6E = "Passenger lest",
        Emv9F71 = "female",
        Emv9F7C = "monthly Jazz",
        Emvdf03 = "Northwest",
        Emvdf04 = "female",
        Emvdf05 = "Nuevo Country",
        Emvdf11 = "transmit Montenegro Gasoline",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Dejavoo,
    TransType = Gateway.Models.Shared.TransType.GetStatus,
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ControlCloudPDCv2IngenicoRequest](../../models/operations/ControlCloudPDCv2IngenicoRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ControlCloudPDCv2IngenicoResponse](../../models/operations/ControlCloudPDCv2IngenicoResponse.md)**

