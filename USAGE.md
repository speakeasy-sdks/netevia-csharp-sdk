<!-- Start SDK Example Usage -->


```csharp
using Gateway;
using Gateway.Models.Shared;

var sdk = new GatewaySDK();

var res = await sdk.Api.BatchAPIAsync(new GrpAmount() {
    IncCashBackAmt = 10000,
    IncTaxAmt = 10000,
    MainAmt = 10000,
    TaxIndicator = Gateway.Models.Shared.GrpAmountTaxIndicator.Ntprvd,
    TipAmt = 10000,
});

// handle response
```
<!-- End SDK Example Usage -->