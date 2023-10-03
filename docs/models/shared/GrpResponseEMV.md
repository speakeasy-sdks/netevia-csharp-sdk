# GrpResponseEMV

Response EMV Info.<br>
Please Note that not all cards return these information, depending on the card, we may only return some of them.



## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `Aid`                            | *string*                         | :heavy_minus_sign:               | Application Identifier           |
| `Arqc`                           | *string*                         | :heavy_minus_sign:               | Authorization Request Cryptogram |
| `Atc`                            | *string*                         | :heavy_minus_sign:               | Application Transaction Counter  |
| `ApplicationLabel`               | *string*                         | :heavy_minus_sign:               | Application Label                |
| `Emv72`                          | *string*                         | :heavy_minus_sign:               | Issuer Script Template 2         |
| `Emv8A`                          | *string*                         | :heavy_minus_sign:               | Authorisation Response Code      |
| `Emv91`                          | *string*                         | :heavy_minus_sign:               | Issuer Authentication Data       |
| `Tsi`                            | *string*                         | :heavy_minus_sign:               | Transaction Status Information   |