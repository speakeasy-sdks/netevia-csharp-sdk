<!-- Start SDK Example Usage -->


```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

var res = await sdk.TransactionV2.CreateAsync(new RestAPIv2Request() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
});

// handle response
```
<!-- End SDK Example Usage -->