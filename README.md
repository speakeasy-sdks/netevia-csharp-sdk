# Netevia Gateway API

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://github.com/speakeasy-sdks/netevia-csharp-sdk.git/actions"><img src="https://img.shields.io/github/actions/workflow/status/speakeasy-sdks/netevia-csharp-sdk/speakeasy_sdk_generation.yml?style=for-the-badge" /></a>
    
</div>

<!-- Start SDK Installation -->
# SDK Installation

## Nuget

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

var res = await sdk.Api.BatchAsync(new GrpPIN() {
    Ksn = "FFFF6543210000A00029",
    PinBlock = "F652B46D04B5D191",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
# Available Resources and Operations


## [Api](docs/sdks/api/README.md)

* [Batch](docs/sdks/api/README.md#batch) - Generic batch query API.
* [Rest](docs/sdks/api/README.md#rest) - Generic API.

## [APIACHCredit](docs/sdks/apiachcredit/README.md)

* [Rest](docs/sdks/apiachcredit/README.md#rest) - ACH Credit transactions.

## [APIACHDebit](docs/sdks/apiachdebit/README.md)

* [Rest](docs/sdks/apiachdebit/README.md#rest) - ACH Debit transactions.

## [APIAuth](docs/sdks/apiauth/README.md)

* [Rest](docs/sdks/apiauth/README.md#rest) - How to initiate different Auth/Finalize transaction requests.

## [APIBatch](docs/sdks/apibatch/README.md)

* [Rest](docs/sdks/apibatch/README.md#rest) - Request batch closing.

## [APIGetTransInfo](docs/sdks/apigettransinfo/README.md)

* [Rest](docs/sdks/apigettransinfo/README.md#rest) - How to initiate GetTransInfo transaction requests.

## [APIGift](docs/sdks/apigift/README.md)

* [Rest](docs/sdks/apigift/README.md#rest) - Gitf transactions.

## [APIModify](docs/sdks/apimodify/README.md)

* [Rest](docs/sdks/apimodify/README.md#rest) - How to initiate Modify/Adjust/AddTip transaction requests.

## [APIRefund](docs/sdks/apirefund/README.md)

* [Rest](docs/sdks/apirefund/README.md#rest) - How to initiate Refund transaction requests.

## [APISale](docs/sdks/apisale/README.md)

* [Rest](docs/sdks/apisale/README.md#rest) - How to initiate different Sale transaction requests.

## [APIToken](docs/sdks/apitoken/README.md)

* [Rest](docs/sdks/apitoken/README.md#rest) - How to initiate Token based transaction requests.

## [APIVerify](docs/sdks/apiverify/README.md)

* [Rest](docs/sdks/apiverify/README.md#rest) - How to initiate Verify/Inquiry transaction requests.

## [APIVoid](docs/sdks/apivoid/README.md)

* [Rest](docs/sdks/apivoid/README.md#rest) - How to initiate Void/Reverse/Cancel transaction requests.

## [APIv2](docs/sdks/apiv2/README.md)

* [Batch](docs/sdks/apiv2/README.md#batch) - Generic batch query API.
* [Rest](docs/sdks/apiv2/README.md#rest) - Generic API.

## [APIv2ACHCredit](docs/sdks/apiv2achcredit/README.md)

* [Rest](docs/sdks/apiv2achcredit/README.md#rest) - ACH Credit transactions.

## [APIv2ACHDebit](docs/sdks/apiv2achdebit/README.md)

* [Rest](docs/sdks/apiv2achdebit/README.md#rest) - ACH Debit transactions.

## [APIv2Auth](docs/sdks/apiv2auth/README.md)

* [Rest](docs/sdks/apiv2auth/README.md#rest) - How to initiate different Auth/Finalize transaction requests.

## [APIv2Batch](docs/sdks/apiv2batch/README.md)

* [Rest](docs/sdks/apiv2batch/README.md#rest) - Request batch closing.

## [APIv2GetTransInfo](docs/sdks/apiv2gettransinfo/README.md)

* [Rest](docs/sdks/apiv2gettransinfo/README.md#rest) - How to initiate GetTransInfo transaction requests.

## [APIv2Gift](docs/sdks/apiv2gift/README.md)

* [Rest](docs/sdks/apiv2gift/README.md#rest) - Gitf transactions.

## [APIv2Modify](docs/sdks/apiv2modify/README.md)

* [Rest](docs/sdks/apiv2modify/README.md#rest) - How to initiate Modify/Adjust/AddTip transaction requests.

## [APIv2Refund](docs/sdks/apiv2refund/README.md)

* [Rest](docs/sdks/apiv2refund/README.md#rest) - How to initiate Refund transaction requests.

## [APIv2Sale](docs/sdks/apiv2sale/README.md)

* [Rest](docs/sdks/apiv2sale/README.md#rest) - How to initiate different Sale transaction requests.

## [APIv2Token](docs/sdks/apiv2token/README.md)

* [Rest](docs/sdks/apiv2token/README.md#rest) - How to initiate Token based transaction requests.

## [APIv2Verify](docs/sdks/apiv2verify/README.md)

* [Rest](docs/sdks/apiv2verify/README.md#rest) - How to initiate Verify/Inquiry transaction requests.

## [APIv2Void](docs/sdks/apiv2void/README.md)

* [Rest](docs/sdks/apiv2void/README.md#rest) - How to initiate Void/Reverse/Cancel transaction requests.

## [CloudPDC](docs/sdks/cloudpdc/README.md)

* [Control](docs/sdks/cloudpdc/README.md#control) - Payment Device Controller - card reader device management API.

## [CloudPDCRefund](docs/sdks/cloudpdcrefund/README.md)

* [Initiate](docs/sdks/cloudpdcrefund/README.md#initiate) - Initiate a Refund request.

## [CloudPDCSale](docs/sdks/cloudpdcsale/README.md)

* [Initiate](docs/sdks/cloudpdcsale/README.md#initiate) - Initiate a transaction request.

## [CloudPDCv2Ingenico](docs/sdks/cloudpdcv2ingenico/README.md)

* [Control](docs/sdks/cloudpdcv2ingenico/README.md#control) - Cloud Payment Device Controller - card reader device management API.

## [CloudPDCv2Refund](docs/sdks/cloudpdcv2refund/README.md)

* [Initiate](docs/sdks/cloudpdcv2refund/README.md#initiate) - Initiate a Refund request.

## [CloudPDCv2Sale](docs/sdks/cloudpdcv2sale/README.md)

* [Initiate](docs/sdks/cloudpdcv2sale/README.md#initiate) - Initiate a transaction request.

## [DesktopPDC](docs/sdks/desktoppdc/README.md)

* [Control](docs/sdks/desktoppdc/README.md#control) - Control desktop PDC through Netevia Server to complete the transaction.

## [DesktopPDCv2](docs/sdks/desktoppdcv2/README.md)

* [Control](docs/sdks/desktoppdcv2/README.md#control) - Control desktop PDC through Netevia Server to complete the transaction.

## [GPay](docs/sdks/gpay/README.md)

* [Rest](docs/sdks/gpay/README.md#rest) - Google Pay ™.

## [QRPay](docs/sdks/qrpay/README.md)

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
