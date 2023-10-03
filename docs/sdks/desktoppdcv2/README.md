# DesktopPDCv2SDK
(*DesktopPDCv2*)

### Available Operations

* [Control](#control) - Control desktop PDC through Netevia Server to complete the transaction.

## Control

All transaction type are support. use this way you can control desktop PDC to read card data.
Desktop PDC version need above 2.2.7. and you need add the websocket clinet configuration.


### Example Usage

```csharp
using Speakeasybar;
using Speakeasybar.Models.Operations;
using Speakeasybar.Models.Shared;

var sdk = new SpeakeasybarSDK();

var res = await sdk.DesktopPDCv2.ControlAsync(new ControlDesktopPDCv2Request() {
    Gmid = "North Southwest Cotton",
    NeedSwipeCard = Speakeasybar.Models.Shared.NeedSwipeCard.N,
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
    TerminalType = Speakeasybar.Models.Shared.TerminalType.Dejavoo,
    TransType = Speakeasybar.Models.Shared.TransType.GetStatus,
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ControlDesktopPDCv2Request](../../models/operations/ControlDesktopPDCv2Request.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[ControlDesktopPDCv2Response](../../models/operations/ControlDesktopPDCv2Response.md)**

