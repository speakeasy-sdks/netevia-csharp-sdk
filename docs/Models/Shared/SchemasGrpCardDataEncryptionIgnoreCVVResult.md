# SchemasGrpCardDataEncryptionIgnoreCVVResult

Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn't Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn't ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.


## Values

| Name  | Value |
| ----- | ----- |
| `Y`   | Y     |
| `N`   | N     |