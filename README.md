# Netevia Gateway API

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://github.com/speakeasy-sdks/netevia-csharp-sdk.git/actions"><img src="https://img.shields.io/github/actions/workflow/status/speakeasy-sdks/netevia-csharp-sdk/speakeasy_sdk_generation.yml?style=for-the-badge" /></a>
    
</div>

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package netevia
```
<!-- End SDK Installation -->

## SDK Example Usage
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

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [Api](docs/sdks/api/README.md)

* [BatchAPI](docs/sdks/api/README.md#batchapi) - Generic batch query API.
* [RestAPI](docs/sdks/api/README.md#restapi) - Generic API.

### [APIACHCredit](docs/sdks/apiachcredit/README.md)

* [RestAPIACHCredit](docs/sdks/apiachcredit/README.md#restapiachcredit) - ACH Credit transactions.

### [APIACHDebit](docs/sdks/apiachdebit/README.md)

* [RestAPIACHDebit](docs/sdks/apiachdebit/README.md#restapiachdebit) - ACH Debit transactions.

### [APIAuth](docs/sdks/apiauth/README.md)

* [RestAPIAuth](docs/sdks/apiauth/README.md#restapiauth) - How to initiate different Auth/Finalize transaction requests.

### [APIBatch](docs/sdks/apibatch/README.md)

* [RestAPIBatch](docs/sdks/apibatch/README.md#restapibatch) - Request batch closing.

### [APIGetTransInfo](docs/sdks/apigettransinfo/README.md)

* [RestAPIGetTransInfo](docs/sdks/apigettransinfo/README.md#restapigettransinfo) - How to initiate GetTransInfo transaction requests.

### [APIGift](docs/sdks/apigift/README.md)

* [RestAPIGift](docs/sdks/apigift/README.md#restapigift) - Gitf transactions.

### [APIModify](docs/sdks/apimodify/README.md)

* [RestAPIModify](docs/sdks/apimodify/README.md#restapimodify) - How to initiate Modify/Adjust/AddTip transaction requests.

### [APIRefund](docs/sdks/apirefund/README.md)

* [RestAPIRefund](docs/sdks/apirefund/README.md#restapirefund) - How to initiate Refund transaction requests.

### [APISale](docs/sdks/apisale/README.md)

* [RestAPISale](docs/sdks/apisale/README.md#restapisale) - How to initiate different Sale transaction requests.

### [APIToken](docs/sdks/apitoken/README.md)

* [RestAPIToken](docs/sdks/apitoken/README.md#restapitoken) - How to initiate Token based transaction requests.

### [APIVerify](docs/sdks/apiverify/README.md)

* [RestAPIVerifyInquiry](docs/sdks/apiverify/README.md#restapiverifyinquiry) - How to initiate Verify/Inquiry transaction requests.

### [APIVoid](docs/sdks/apivoid/README.md)

* [RestAPIVoid](docs/sdks/apivoid/README.md#restapivoid) - How to initiate Void/Reverse/Cancel transaction requests.

### [APIv2](docs/sdks/apiv2/README.md)

* [BatchAPIv2](docs/sdks/apiv2/README.md#batchapiv2) - Generic batch query API.
* [RestAPIv2](docs/sdks/apiv2/README.md#restapiv2) - Generic API.

### [APIv2ACHCredit](docs/sdks/apiv2achcredit/README.md)

* [RestAPIv2ACHCredit](docs/sdks/apiv2achcredit/README.md#restapiv2achcredit) - ACH Credit transactions.

### [APIv2ACHDebit](docs/sdks/apiv2achdebit/README.md)

* [RestAPIv2ACHDebit](docs/sdks/apiv2achdebit/README.md#restapiv2achdebit) - ACH Debit transactions.

### [APIv2Auth](docs/sdks/apiv2auth/README.md)

* [RestAPIv2Auth](docs/sdks/apiv2auth/README.md#restapiv2auth) - How to initiate different Auth/Finalize transaction requests.

### [APIv2Batch](docs/sdks/apiv2batch/README.md)

* [RestAPIv2Batch](docs/sdks/apiv2batch/README.md#restapiv2batch) - Request batch closing.

### [APIv2GetTransInfo](docs/sdks/apiv2gettransinfo/README.md)

* [RestAPIv2GetTransInfo](docs/sdks/apiv2gettransinfo/README.md#restapiv2gettransinfo) - How to initiate GetTransInfo transaction requests.

### [APIv2Gift](docs/sdks/apiv2gift/README.md)

* [RestAPIv2Gift](docs/sdks/apiv2gift/README.md#restapiv2gift) - Gitf transactions.

### [APIv2Modify](docs/sdks/apiv2modify/README.md)

* [RestAPIv2Modify](docs/sdks/apiv2modify/README.md#restapiv2modify) - How to initiate Modify/Adjust/AddTip transaction requests.

### [APIv2Refund](docs/sdks/apiv2refund/README.md)

* [RestAPIv2Refund](docs/sdks/apiv2refund/README.md#restapiv2refund) - How to initiate Refund transaction requests.

### [APIv2Sale](docs/sdks/apiv2sale/README.md)

* [RestAPIv2Sale](docs/sdks/apiv2sale/README.md#restapiv2sale) - How to initiate different Sale transaction requests.

### [APIv2Token](docs/sdks/apiv2token/README.md)

* [RestAPIv2Token](docs/sdks/apiv2token/README.md#restapiv2token) - How to initiate Token based transaction requests.

### [APIv2Verify](docs/sdks/apiv2verify/README.md)

* [RestAPIv2VerifyInquiry](docs/sdks/apiv2verify/README.md#restapiv2verifyinquiry) - How to initiate Verify/Inquiry transaction requests.

### [APIv2Void](docs/sdks/apiv2void/README.md)

* [RestAPIv2Void](docs/sdks/apiv2void/README.md#restapiv2void) - How to initiate Void/Reverse/Cancel transaction requests.

### [CloudPDC](docs/sdks/cloudpdc/README.md)

* [ControlCloudPDC](docs/sdks/cloudpdc/README.md#controlcloudpdc) - Payment Device Controller - card reader device management API.

### [CloudPDCRefund](docs/sdks/cloudpdcrefund/README.md)

* [InitiateCloudPDCRefund](docs/sdks/cloudpdcrefund/README.md#initiatecloudpdcrefund) - Initiate a Refund request.

### [CloudPDCSale](docs/sdks/cloudpdcsale/README.md)

* [InitiateCloudPDCSale](docs/sdks/cloudpdcsale/README.md#initiatecloudpdcsale) - Initiate a transaction request.

### [CloudPDCv2Ingenico](docs/sdks/cloudpdcv2ingenico/README.md)

* [ControlCloudPDCv2Ingenico](docs/sdks/cloudpdcv2ingenico/README.md#controlcloudpdcv2ingenico) - Cloud Payment Device Controller - card reader device management API.

### [CloudPDCv2Refund](docs/sdks/cloudpdcv2refund/README.md)

* [InitiateCloudPDCv2Refund](docs/sdks/cloudpdcv2refund/README.md#initiatecloudpdcv2refund) - Initiate a Refund request.

### [CloudPDCv2Sale](docs/sdks/cloudpdcv2sale/README.md)

* [InitiateCloudPDCv2Sale](docs/sdks/cloudpdcv2sale/README.md#initiatecloudpdcv2sale) - Initiate a transaction request.

### [DesktopPDC](docs/sdks/desktoppdc/README.md)

* [ControlDesktopPDC](docs/sdks/desktoppdc/README.md#controldesktoppdc) - Control desktop PDC through Netevia Server to complete the transaction.

### [DesktopPDCv2](docs/sdks/desktoppdcv2/README.md)

* [ControlDesktopPDCv2](docs/sdks/desktoppdcv2/README.md#controldesktoppdcv2) - Control desktop PDC through Netevia Server to complete the transaction.

### [GPay](docs/sdks/gpay/README.md)

* [RestGPay](docs/sdks/gpay/README.md#restgpay) - Google Pay ™.

### [QRPay](docs/sdks/qrpay/README.md)

* [IntegrateQRPay](docs/sdks/qrpay/README.md#integrateqrpay) - Integrated QRPay API interface
<!-- End SDK Available Operations -->

<!-- Start Dev Containers -->

<!-- End Dev Containers -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
