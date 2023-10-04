# GrpCardDataEncryption

Encryption Data Group.<br>
These are present for P2PE enabled card readers



## Fields

| Field                                                                                                           | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     | Example                                                                                                         |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `EncrptBlock`                                                                                                   | *string*                                                                                                        | :heavy_minus_sign:                                                                                              | Contains the track data or card number provided in an encrypted block. Be Present when card data is encrypted.<br/> |                                                                                                                 |
| `EncrptTrgt`                                                                                                    | [GrpCardDataEncryptionEncrptTrgt](../../models/shared/GrpCardDataEncryptionEncrptTrgt.md)                       | :heavy_minus_sign:                                                                                              | Indicates the type of data that is being encrypted.<br/>                                                        | PAN                                                                                                             |
| `KeyID`                                                                                                         | *string*                                                                                                        | :heavy_minus_sign:                                                                                              | This is an identifier used to retrieve the private key, which is required for decryption.<br/>                  | 66257982464                                                                                                     |