# GrpCardDataEncryptionSchemas1

Encryption Data Group.<br>
These are present for P2PE enabled card readers



## Fields

| Field                                                                                                                                                                                                                                                                                                                                                                                                        | Type                                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                  | Example                                                                                                                                                                                                                                                                                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AllowsPartialAuth`                                                                                                                                                                                                                                                                                                                                                                                          | [SchemasGrpCardDataEncryptionAllowsPartialAuth](../../Models/Shared/SchemasGrpCardDataEncryptionAllowsPartialAuth.md)                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Indicates whether partial authorization is allowed.<br/>                                                                                                                                                                                                                                                                                                                                                     | N                                                                                                                                                                                                                                                                                                                                                                                                            |
| `CheckDuplicate`                                                                                                                                                                                                                                                                                                                                                                                             | [SchemasGrpCardDataEncryptionCheckDuplicate](../../Models/Shared/SchemasGrpCardDataEncryptionCheckDuplicate.md)                                                                                                                                                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Indicates whether to check for duplicate transactions.<br><br/>Duplicate check interval: 1 minute.<br><br/>Note: you need to supply this field in all the request to enable this feature.<br/>                                                                                                                                                                                                               | N                                                                                                                                                                                                                                                                                                                                                                                                            |
| `CreditOnFailure`                                                                                                                                                                                                                                                                                                                                                                                            | [SchemasGrpCardDataEncryptionCreditOnFailure](../../Models/Shared/SchemasGrpCardDataEncryptionCreditOnFailure.md)                                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Indicates whether do force void transaction.<br/>                                                                                                                                                                                                                                                                                                                                                            | N                                                                                                                                                                                                                                                                                                                                                                                                            |
| `EncrptBlock`                                                                                                                                                                                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Contains the track data or card number provided in an encrypted block. Be Present when card data is encrypted.<br/>                                                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                                                                                                                              |
| `EncrptTrgt`                                                                                                                                                                                                                                                                                                                                                                                                 | [SchemasEncrptTrgt](../../Models/Shared/SchemasEncrptTrgt.md)                                                                                                                                                                                                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Indicates the type of data that is being encrypted.<br/>                                                                                                                                                                                                                                                                                                                                                     | PAN                                                                                                                                                                                                                                                                                                                                                                                                          |
| `Gmid`                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                           | Merchant identifier Assigned by<br><br/>Netevia Payment Systems Administrator during registration<br/>                                                                                                                                                                                                                                                                                                       | 1110222484                                                                                                                                                                                                                                                                                                                                                                                                   |
| `Gmpw`                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                           | Merchant password<br><br/>Only verified for Refund transactions.<br><br/>It can be any value for other transactions.<br/>                                                                                                                                                                                                                                                                                    | GMPW3010300378                                                                                                                                                                                                                                                                                                                                                                                               |
| `Gtid`                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                           | Merchant's terminal identifier<br><br/>Assigned by Netevia Payment Systems Administrator during registration.<br><br/>This field is Optional when doing Register.<br/>                                                                                                                                                                                                                                       | GT1120095178                                                                                                                                                                                                                                                                                                                                                                                                 |
| `IgnoreAVSResult`                                                                                                                                                                                                                                                                                                                                                                                            | [SchemasGrpCardDataEncryptionIgnoreAVSResult](../../Models/Shared/SchemasGrpCardDataEncryptionIgnoreAVSResult.md)                                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Ignore AVS result from processor, default value is Y, if need to check AVS result please send it in request with N. the feature only works in TSYS and Elavon. Elavon if host return the code (A,B,C,E,N,R,W,Z) and doesnt' ignore avs result code then Netevia will reject the verify request. TSYS if host return N and doesn't ignore avs result then Netevia will reject the Verify, Auth, Sale request. | Y                                                                                                                                                                                                                                                                                                                                                                                                            |
| `IgnoreCVVResult`                                                                                                                                                                                                                                                                                                                                                                                            | [SchemasGrpCardDataEncryptionIgnoreCVVResult](../../Models/Shared/SchemasGrpCardDataEncryptionIgnoreCVVResult.md)                                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn't Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn't ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.                                             | Y                                                                                                                                                                                                                                                                                                                                                                                                            |
| `IgnoreVoidResult`                                                                                                                                                                                                                                                                                                                                                                                           | [SchemasGrpCardDataEncryptionIgnoreVoidResult](../../Models/Shared/SchemasGrpCardDataEncryptionIgnoreVoidResult.md)                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Ignore Void result from processor. if processor return fail, then we force it to success. Default value is Y,                                                                                                                                                                                                                                                                                                | Y                                                                                                                                                                                                                                                                                                                                                                                                            |
| `IsOffline`                                                                                                                                                                                                                                                                                                                                                                                                  | [SchemasGrpCardDataEncryptionIsOffline](../../Models/Shared/SchemasGrpCardDataEncryptionIsOffline.md)                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Indicates whether is an offline transaction.<br/>                                                                                                                                                                                                                                                                                                                                                            | N                                                                                                                                                                                                                                                                                                                                                                                                            |
| `KeyID`                                                                                                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | This is an identifier used to retrieve the private key, which is required for decryption.<br/>                                                                                                                                                                                                                                                                                                               | 66257982464                                                                                                                                                                                                                                                                                                                                                                                                  |
| `NeedSwipeCard`                                                                                                                                                                                                                                                                                                                                                                                              | [SchemasGrpCardDataEncryptionNeedSwipeCard](../../Models/Shared/SchemasGrpCardDataEncryptionNeedSwipeCard.md)                                                                                                                                                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | This field is used when sending a request to a PDC. Indicates whether the card data should be retrieved using the pinpad("Y") or it is not needed(Void/Refund) or already provided in the request("N"). This works for all entry modes Manual/Swipe/EMV/Contactless.<br/>                                                                                                                                    |                                                                                                                                                                                                                                                                                                                                                                                                              |
| `TransType`                                                                                                                                                                                                                                                                                                                                                                                                  | [SchemasGrpCardDataEncryptionTransType](../../Models/Shared/SchemasGrpCardDataEncryptionTransType.md)                                                                                                                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                           | Transaction Type.<br/>                                                                                                                                                                                                                                                                                                                                                                                       | Sale                                                                                                                                                                                                                                                                                                                                                                                                         |
| `VerifyCard`                                                                                                                                                                                                                                                                                                                                                                                                 | [SchemasGrpCardDataEncryptionVerifyCard](../../Models/Shared/SchemasGrpCardDataEncryptionVerifyCard.md)                                                                                                                                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                           | Indicates whether verify card when doing CreateCardToken.<br/>                                                                                                                                                                                                                                                                                                                                               | N                                                                                                                                                                                                                                                                                                                                                                                                            |