<!-- Start SDK Example Usage [usage] -->
```csharp
using Netevia;
using Netevia.Models.Operations;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIv2Request req = new RestAPIv2Request() {
    Gmid = "string",
    RequestBody = "string",
    TransType = TransType.Register,
};

var res = await sdk.TransactionV2.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->