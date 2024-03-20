# SchemasGrpAmountIgnoreAVSResult

Ignore AVS result from processor, default value is Y, if need to check AVS result please send it in request with N. the feature only works in TSYS and Elavon. Elavon if host return the code (A,B,C,E,N,R,W,Z) and doesnt' ignore avs result code then Netevia will reject the verify request. TSYS if host return N and doesn't ignore avs result then Netevia will reject the Verify, Auth, Sale request.


## Values

| Name  | Value |
| ----- | ----- |
| `Y`   | Y     |
| `N`   | N     |