# APITokenSDK
(*APIToken*)

### Available Operations

* [RestAPIToken](#restapitoken) - How to initiate Token based transaction requests.

## RestAPIToken

Initiate <b>Token</b> based transaction requests to Netevia Gateway.<sup>1</sup><br>

*<span style="color:green">Valid actions:</span>*
---
___
- <span style="color:red">CreateCardToken</span>: is used to create card token.
- <span style="color:red">DeleteCardToken<sup>2</sup></span>: is used to delete exist card token.
- <span style="color:red">GetCardTokenInfo</span>: is used to retrieve card data(masked) linked to a token.
- <span style="color:red">UpdateCardTokenInfo</span>: is used to update card token information. It supports update ExpDate, CustomerAddress, CustomerZipCode.
<hr>
<sup>1</sup>Use the examples for different 'Token' flavours<br>
<sup>2</sup>Pay attention that calling this API will delete the provided 'CardToken'
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.APIToken.RestAPITokenAsync(new GrpEMV() {
    Emv42 = "Ford Auto",
    Emv4F = "models Gasoline",
    Emv50 = "West Bicycle",
    Emv57 = "structure",
    Emv5A = "indigo after",
    Emv5F20 = "West Crossroad purple",
    Emv5F24 = "Decentralized Jaguar",
    Emv5F28 = "Supervisor intranet",
    Emv5F2A = "background female Pizza",
    Emv5F2D = "hacking Territory Bedfordshire",
    Emv5F30 = "Wyoming Island Utah",
    Emv5F34 = "regional Mouse",
    Emv5F54 = "male",
    Emv5F55 = "than",
    Emv5F56 = "Sausages and",
    Emv71 = "gadzooks male Towels",
    Emv72 = "Chair",
    Emv82 = "Wooden Electric embody",
    Emv84 = "primary",
    Emv87 = "Fiat",
    Emv8A = "copy",
    Emv8E = "Oriental Wagon",
    Emv91 = "unless dolore pixel",
    Emv95 = "BMW craft",
    Emv9A = "Sleek Principal though",
    Emv9B = "Soul twin green",
    Emv9C = "quantifying DRAM",
    Emv9F02 = "Southwest turquoise Fresh",
    Emv9F03 = "Bentley parsing Automotive",
    Emv9F06 = "amidst",
    Emv9F07 = "Clothing wrong Southeast",
    Emv9F08 = "meter bypassing",
    Emv9F09 = "concrete Schoen GB",
    Emv9F0B = "World",
    Emv9F0D = "Samarium Infrastructure Massachusetts",
    Emv9F0E = "East",
    Emv9F0F = "Tandem Chile HEX",
    Emv9F10 = "Gasoline bypass",
    Emv9F11 = "Fantastic unless",
    Emv9F12 = "Wooden",
    Emv9F14 = "behind Bicycle",
    Emv9F17 = "Antonina West GB",
    Emv9F1A = "application",
    Emv9F1B = "Sausages International Coordinator",
    Emv9F1E = "Collierville Advanced",
    Emv9F1F = "Somoni Generic clash",
    Emv9F20 = "Quetzal",
    Emv9F21 = "killing Metal",
    Emv9F26 = "dolorem",
    Emv9F27 = "Fiat barring",
    Emv9F33 = "debitis tan",
    Emv9F34 = "at Van",
    Emv9F35 = "Rhode Creative intangible",
    Emv9F36 = "farad",
    Emv9F37 = "Interactions toolset magnetic",
    Emv9F39 = "card",
    Emv9F40 = "Lamborghini North",
    Emv9F41 = "impartial",
    Emv9F42 = "kilogram API recusandae",
    Emv9F51 = "male visualize Directives",
    Emv9F53 = "standardization Chief silver",
    Emv9F5B = "Intelligent",
    Emv9F5D = "yawningly East",
    Emv9F66 = "Cargo Lithium",
    Emv9F67 = "Investor primary South",
    Emv9F6C = "online",
    Emv9F6D = "Movies lumen Peso",
    Emv9F6E = "synthesizing",
    Emv9F71 = "API mole",
    Emv9F7C = "Tuna oof",
    Emvdf03 = "Industrial",
    Emvdf04 = "Gabon Avon",
    Emvdf05 = "program Analyst",
    Emvdf11 = "Berkelium officially",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *object*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[RestAPITokenResponse](../../models/operations/RestAPITokenResponse.md)**

