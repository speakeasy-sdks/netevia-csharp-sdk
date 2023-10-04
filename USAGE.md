<!-- Start SDK Example Usage -->


```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.Api.BatchAsync(new GrpPIN() {
    Ksn = "FFFF6543210000A00029",
    PinBlock = "F652B46D04B5D191",
});

// handle response
```
<!-- End SDK Example Usage -->