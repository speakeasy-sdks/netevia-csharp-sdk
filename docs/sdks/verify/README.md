# Verify
(*Verify*)

### Available Operations

* [RestAPIVerifyInquiry](#restapiverifyinquiry) - How to initiate Verify/Inquiry transaction requests.

## RestAPIVerifyInquiry

Initiate a <b>Verify/Inquiry</b> transaction request to Netevia Gateway.<sup>1</sup><br>
A <b>Inquiry</b> transaction is used to query the balance amount of a card.<br>
A <b>Verify</b> transaction is used to check if the card is valid.
<hr>
<sup>1</sup>Use the examples for different request samples.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGeneric req = RequestGeneric.CreateRequestGenericGrpAmountSchemas(
    new GrpAmountSchemas() {
        AllowsPartialAuth = SchemasGrpAmountAllowsPartialAuth.N,
        CheckDuplicate = SchemasGrpAmountCheckDuplicate.N,
        CreditOnFailure = SchemasGrpAmountCreditOnFailure.N,
        Gmid = "1110222484",
        Gmpw = "GMPW3010300378",
        Gtid = "GT1120095178",
        IgnoreAVSResult = SchemasGrpAmountIgnoreAVSResult.Y,
        IgnoreCVVResult = SchemasGrpAmountIgnoreCVVResult.Y,
        IgnoreVoidResult = SchemasGrpAmountIgnoreVoidResult.Y,
        IncCashBackAmt = 10000,
        IncTaxAmt = 10000,
        IsOffline = SchemasGrpAmountIsOffline.N,
        MainAmt = 10000,
        TaxIndicator = SchemasTaxIndicator.Ntprvd,
        TipAmt = 10000,
        TransType = SchemasGrpAmountTransType.Sale,
        VerifyCard = SchemasGrpAmountVerifyCard.N,
    },
);

var res = await sdk.Verify.RestAPIVerifyInquiryAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [RequestGeneric](../../Models/Shared/RequestGeneric.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[RestAPIVerifyInquiryResponse](../../Models/Operations/RestAPIVerifyInquiryResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
