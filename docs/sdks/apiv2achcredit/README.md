# APIv2ACHCreditSDK
(*APIv2ACHCredit*)

### Available Operations

* [RestAPIv2ACHCredit](#restapiv2achcredit) - ACH Credit transactions.

## RestAPIv2ACHCredit

Initiate an <b>ACH</b> credit transaction request to Netevia Gateway.<sup>1</sup><br>
An <b>ACH</b> credit transaction is used to allow merchants to pay using ACH and transfer money to other bank accounts.<br>
To be more generic and have a similar approach as for Debit ACH, we can also simulate the single PayOut call for a batch of payments with multiple individual credit transactions calls that will be approved offline by us and when batching happens we can generate the PayOut request to GMS as a single API call(batch file upload) as they require. Now GMS processor support.
<hr>
<sup>1</sup>Use the examples for different 'ACH Credit' request flavours.
<div>
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Operations;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIv2ACHCredit.RestAPIv2ACHCreditAsync(new RestAPIv2ACHCreditRequest() {
    Gmid = "except Salad Guernsey",
    NeedSwipeCard = Gateway.Models.Shared.NeedSwipeCard.N,
    RequestBody = new GrpEMV() {
        Emv42 = "Grand orchid",
        Emv4F = "synergies Diesel",
        Emv50 = "TCP",
        Emv57 = "granular Ponce during",
        Emv5A = "Louisiana",
        Emv5F20 = "BMW",
        Emv5F24 = "deleniti Metal",
        Emv5F28 = "bandwidth",
        Emv5F2A = "online",
        Emv5F2D = "furrow edge",
        Emv5F30 = "Bicycle static",
        Emv5F34 = "steak",
        Emv5F54 = "Gasoline",
        Emv5F55 = "Optimization",
        Emv5F56 = "Iowa",
        Emv71 = "Volvo Unbranded",
        Emv72 = "flamboyant B2B",
        Emv82 = "hardware",
        Emv84 = "Cambridgeshire salmon San",
        Emv87 = "to fuchsia Internal",
        Emv8A = "national",
        Emv8E = "zero Southwest withdrawal",
        Emv91 = "transmitting",
        Emv95 = "round Leonie",
        Emv9A = "Total",
        Emv9B = "Forward XSS Avon",
        Emv9C = "wooden",
        Emv9F02 = "barring Enhanced",
        Emv9F03 = "Beauty Transexual Belize",
        Emv9F06 = "lime",
        Emv9F07 = "Home",
        Emv9F08 = "quantify",
        Emv9F09 = "Parkway GB firewall",
        Emv9F0B = "Wagon Money",
        Emv9F0D = "Frozen Mateo",
        Emv9F0E = "online Saudi Extended",
        Emv9F0F = "after International",
        Emv9F10 = "success application Rustic",
        Emv9F11 = "er molestiae",
        Emv9F12 = "Pickup nulla",
        Emv9F14 = "Investor",
        Emv9F17 = "ROI",
        Emv9F1A = "watt Unbranded Nitrogen",
        Emv9F1B = "strength",
        Emv9F1E = "enable",
        Emv9F1F = "henry SCSI architectures",
        Emv9F20 = "boo",
        Emv9F21 = "content invoice West",
        Emv9F26 = "GB male Hip",
        Emv9F27 = "Ball Promethium",
        Emv9F33 = "Movies",
        Emv9F34 = "Extended arthur deliverables",
        Emv9F35 = "Coordinator",
        Emv9F36 = "invoice quantify Steel",
        Emv9F37 = "Reggae amongst gold",
        Emv9F39 = "hence eggplant optical",
        Emv9F40 = "SSD",
        Emv9F41 = "gelding petty optimise",
        Emv9F42 = "Argon",
        Emv9F51 = "Checking onto",
        Emv9F53 = "Chrysler skivvy",
        Emv9F5B = "Northeast",
        Emv9F5D = "quidem Bedfordshire Quality",
        Emv9F66 = "Unbranded teeming",
        Emv9F67 = "strictly Florida Porsche",
        Emv9F6C = "West male Australia",
        Emv9F6D = "surge",
        Emv9F6E = "prosecute Investor schemas",
        Emv9F71 = "invoice Developer Androgynous",
        Emv9F7C = "bypassing",
        Emvdf03 = "hybrid",
        Emvdf04 = "Implementation local",
        Emvdf05 = "tesla contingency",
        Emvdf11 = "Rubber Volvo",
    },
    TerminalType = Gateway.Models.Shared.TerminalType.Dejavoo,
    TransType = Gateway.Models.Shared.TransType.GetStatus,
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RestAPIv2ACHCreditRequest](../../models/operations/RestAPIv2ACHCreditRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[RestAPIv2ACHCreditResponse](../../models/operations/RestAPIv2ACHCreditResponse.md)**

