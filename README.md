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

var sdk = new GatewaySDK();

var res = await sdk.ACHCreditTransaction.CreateAsync("string");

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [ACHCreditTransaction](docs/sdks/achcredittransaction/README.md)

* [Create](docs/sdks/achcredittransaction/README.md#create) - ACH Credit transactions.

### [ACHCreditTransactionV2](docs/sdks/achcredittransactionv2/README.md)

* [Create](docs/sdks/achcredittransactionv2/README.md#create) - ACH Credit transactions.

### [ACHDebitTransaction](docs/sdks/achdebittransaction/README.md)

* [Create](docs/sdks/achdebittransaction/README.md#create) - ACH Debit transactions.

### [ACHDebitTransactionV2](docs/sdks/achdebittransactionv2/README.md)

* [Create](docs/sdks/achdebittransactionv2/README.md#create) - ACH Debit transactions.

### [Auth](docs/sdks/auth/README.md)

* [Finalize](docs/sdks/auth/README.md#finalize) - How to initiate different Auth/Finalize transaction requests.

### [BatchQueryV2](docs/sdks/batchqueryv2/README.md)

* [Create](docs/sdks/batchqueryv2/README.md#create) - Generic batch query API.

### [BatchTransaction](docs/sdks/batchtransaction/README.md)

* [Create](docs/sdks/batchtransaction/README.md#create) - Request batch closing.

### [CloudPDCIngenicoTransactionV2](docs/sdks/cloudpdcingenicotransactionv2/README.md)

* [Create](docs/sdks/cloudpdcingenicotransactionv2/README.md#create) - Cloud Payment Device Controller - card reader device management API.

### [CloudPDCRefund](docs/sdks/cloudpdcrefund/README.md)

* [Create](docs/sdks/cloudpdcrefund/README.md#create) - Initiate a Refund request.

### [CloudPDCRefundv2](docs/sdks/cloudpdcrefundv2/README.md)

* [Create](docs/sdks/cloudpdcrefundv2/README.md#create) - Initiate a Refund request.

### [CloudPDCSaleTransaction](docs/sdks/cloudpdcsaletransaction/README.md)

* [Create](docs/sdks/cloudpdcsaletransaction/README.md#create) - Initiate a transaction request.

### [CloudPDCSaleTransactionV2](docs/sdks/cloudpdcsaletransactionv2/README.md)

* [Create](docs/sdks/cloudpdcsaletransactionv2/README.md#create) - Initiate a transaction request.

### [DesktopPDCTransaction](docs/sdks/desktoppdctransaction/README.md)

* [Create](docs/sdks/desktoppdctransaction/README.md#create) - Control desktop PDC through Netevia Server to complete the transaction.

### [DesktopPDCTransactionV2](docs/sdks/desktoppdctransactionv2/README.md)

* [Create](docs/sdks/desktoppdctransactionv2/README.md#create) - Control desktop PDC through Netevia Server to complete the transaction.

### [GPayTransaction](docs/sdks/gpaytransaction/README.md)

* [Create](docs/sdks/gpaytransaction/README.md#create) - Google Pay ™.

### [GiftTransaction](docs/sdks/gifttransaction/README.md)

* [Create](docs/sdks/gifttransaction/README.md#create) - Gitf transactions.

### [GiftTransactionV2](docs/sdks/gifttransactionv2/README.md)

* [Create](docs/sdks/gifttransactionv2/README.md#create) - Gitf transactions.

### [ModifyTransactionV2](docs/sdks/modifytransactionv2/README.md)

* [Create](docs/sdks/modifytransactionv2/README.md#create) - How to initiate Modify/Adjust/AddTip transaction requests.

### [PaymentDeviceController](docs/sdks/paymentdevicecontroller/README.md)

* [Create](docs/sdks/paymentdevicecontroller/README.md#create) - Payment Device Controller - card reader device management API.

### [QRPayTransaction](docs/sdks/qrpaytransaction/README.md)

* [Create](docs/sdks/qrpaytransaction/README.md#create) - Integrated QRPay API interface

### [Refund](docs/sdks/refund/README.md)

* [Create](docs/sdks/refund/README.md#create) - How to initiate Refund transaction requests.

### [RefundTransctionV2](docs/sdks/refundtransctionv2/README.md)

* [Create](docs/sdks/refundtransctionv2/README.md#create) - How to initiate Refund transaction requests.

### [SaleTransaction](docs/sdks/saletransaction/README.md)

* [Create](docs/sdks/saletransaction/README.md#create) - How to initiate different Sale transaction requests.

### [SaleTransactionV2](docs/sdks/saletransactionv2/README.md)

* [Create](docs/sdks/saletransactionv2/README.md#create) - How to initiate different Sale transaction requests.

### [TokenTransaction](docs/sdks/tokentransaction/README.md)

* [Create](docs/sdks/tokentransaction/README.md#create) - How to initiate Token based transaction requests.

### [TokenTransactionV2](docs/sdks/tokentransactionv2/README.md)

* [Create](docs/sdks/tokentransactionv2/README.md#create) - How to initiate Token based transaction requests.

### [TransInfo](docs/sdks/transinfo/README.md)

* [Create](docs/sdks/transinfo/README.md#create) - How to initiate GetTransInfo transaction requests.

### [Transaction](docs/sdks/transaction/README.md)

* [BatchClose](docs/sdks/transaction/README.md#batchclose) - Request batch closing.
* [BatchQuery](docs/sdks/transaction/README.md#batchquery) - Generic batch query API.
* [Create](docs/sdks/transaction/README.md#create) - Generic API.
* [Modify](docs/sdks/transaction/README.md#modify) - How to initiate Modify/Adjust/AddTip transaction requests.
* [Void](docs/sdks/transaction/README.md#void) - How to initiate Void/Reverse/Cancel transaction requests.

### [TransactionAuthV2](docs/sdks/transactionauthv2/README.md)

* [Create](docs/sdks/transactionauthv2/README.md#create) - How to initiate different Auth/Finalize transaction requests.

### [TransactionInfoV2](docs/sdks/transactioninfov2/README.md)

* [Create](docs/sdks/transactioninfov2/README.md#create) - How to initiate GetTransInfo transaction requests.

### [TransactionV2](docs/sdks/transactionv2/README.md)

* [Create](docs/sdks/transactionv2/README.md#create) - Generic API.

### [Verify](docs/sdks/verify/README.md)

* [RestAPIVerifyInquiry](docs/sdks/verify/README.md#restapiverifyinquiry) - How to initiate Verify/Inquiry transaction requests.

### [VerifyTransactionV2](docs/sdks/verifytransactionv2/README.md)

* [Create](docs/sdks/verifytransactionv2/README.md#create) - How to initiate Verify/Inquiry transaction requests.

### [VoidTransactionV2](docs/sdks/voidtransactionv2/README.md)

* [Create](docs/sdks/voidtransactionv2/README.md#create) - How to initiate Void/Reverse/Cancel transaction requests.
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
