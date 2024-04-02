# Transaction
(*Transaction*)

### Available Operations

* [BatchClose](#batchclose) - Request batch closing.
* [BatchQuery](#batchquery) - Generic batch query API.
* [Create](#create) - Generic API.
* [Modify](#modify) - How to initiate Modify/Adjust/AddTip transaction requests.
* [Void](#void) - How to initiate Void/Reverse/Cancel transaction requests.

## BatchClose

Initiate a batch close request to Netevia Gateway

***<span style="color:green">Valid actions:</span>***
---
___
- <span style="color:red">Batch</span> : is used to close the current open batch and settle it. It is supported by terminal capture only .For host capture, merchant don’t need submit batch request. For GMS ACH Credit batch, please check the examples from ACHCredit section.
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGeneric req = RequestGeneric.CreateRequestGenericGrpTraceSchemas1(
    new GrpTraceSchemas1() {
        AllowsPartialAuth = SchemasGrpTraceAllowsPartialAuth.N,
        CheckDuplicate = SchemasGrpTraceCheckDuplicate.N,
        CreditOnFailure = SchemasGrpTraceCreditOnFailure.N,
        Gmid = "1110222484",
        Gmpw = "GMPW3010300378",
        Gtid = "GT1120095178",
        Gtrc = "e134bff9203f44e8974a11b2aef7665d",
        IgnoreAVSResult = SchemasGrpTraceIgnoreAVSResult.Y,
        IgnoreCVVResult = SchemasGrpTraceIgnoreCVVResult.Y,
        IgnoreVoidResult = SchemasGrpTraceIgnoreVoidResult.Y,
        IsOffline = SchemasGrpTraceIsOffline.N,
        NewGTRC = "fe31047eca6b47f2a07ead29be5a7672",
        SourceTraceNum = "123456",
        TransType = SchemasGrpTraceTransType.Sale,
        VerifyCard = SchemasGrpTraceVerifyCard.N,
    },
);

var res = await sdk.Transaction.BatchCloseAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [RequestGeneric](../../Models/Shared/RequestGeneric.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[RestAPIBatchResponse](../../Models/Operations/RestAPIBatchResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

## BatchQuery

Initiate a batch query request to Netevia Gateway.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
***<span style="color:green">Valid actions:</span>***  
---  
___
- <span style="color:red">BatchLookup</span> : is used to get the batch ID by batch date.  If the BatchDate is omitted, the open/current batch is returned. Then the batch ID can be used in BatchQuery API to get more info for that batch.  
- <span style="color:red">BatchQuery</span> : is used to query transaction list by batch ID.  
<hr>
<sup>1</sup>please refer to 'samples' section for sample subsets 


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGeneric req = RequestGeneric.CreateRequestGenericGrpPINSchemas(
    new GrpPINSchemas() {
        AllowsPartialAuth = SchemasGrpPINAllowsPartialAuth.N,
        CheckDuplicate = SchemasGrpPINCheckDuplicate.N,
        CreditOnFailure = SchemasGrpPINCreditOnFailure.N,
        Gmid = "1110222484",
        Gmpw = "GMPW3010300378",
        Gtid = "GT1120095178",
        IgnoreAVSResult = SchemasGrpPINIgnoreAVSResult.Y,
        IgnoreCVVResult = SchemasGrpPINIgnoreCVVResult.Y,
        IgnoreVoidResult = SchemasGrpPINIgnoreVoidResult.Y,
        IsOffline = SchemasGrpPINIsOffline.N,
        Ksn = "FFFF6543210000A00029",
        PinBlock = "F652B46D04B5D191",
        TransType = SchemasGrpPINTransType.Sale,
        VerifyCard = SchemasGrpPINVerifyCard.N,
    },
);

var res = await sdk.Transaction.BatchQueryAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [RequestGeneric](../../Models/Shared/RequestGeneric.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[BatchAPIResponse](../../Models/Operations/BatchAPIResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

## Create

Initiate a transaction request to Netevia Gateway.<br>
This is the full set of parameters that can be used. All the data is sent in the body of the request.<br>
Depending on the transaction type only a subset of these fields are mandatory!<sup>1</sup><br>
<hr>
<sup>1</sup>please refer to 'Examples' section for sample subsets  


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RestAPIRequestBody req = RestAPIRequestBody.CreateRestAPIRequestBodyGrpCardInfo(
    new GrpCardInfo() {
        AccountNum = "5415244444444444",
        CVVNum = "123",
        CardToken = "18c9c75f28a04538939112fb109702fb",
        CustomerAddress = "Test Street 4",
        CustomerCity = "Miami",
        CustomerName = "John Doe",
        CustomerNum = "C91101",
        CustomerState = "Florida",
        CustomerZipCode = "12345",
        ExpDate = "1225",
        Medium = Medium.Credit,
        PayAPI = PayAPI.GooglePay,
        Payload = "{\"signature\":\"MEMCIBD7zOfOintAG/gjg6XenH+x8uM//2b3L/i+GKlhOMtxAh89lRkECojoDHc/Ohis4hvivc2EtCNf/k69MWMCemBN\",\"intermediateSigningKey\":{\"signedKey\":\"{\\"keyValue\\":\\"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEq1r61W296dtgCNIJYS9KTl5bp8lMPjz7SDEjE5Zk27iiuane/oEZbOQYlF8YurHvitrLyFN9ROU8p+9Rts7feg\\u003d\\u003d\\",\\"keyExpiration\\":\\"1603261713365\\"}\",\"signatures\":[\"MEUCIQDnvLuziBPYWDmMuUR493lDMYoZYccEPi7sCYHC+EILkgIgacX5hiHoxxD7HRfm9xG9lYNHAoV5i2OaFpggArB0uwQ\u003d\"]},\"protocolVersion\":\"ECv2\",\"signedMessage\":\"{\\"encryptedMessage\\":\\"+Oc0tH5ZWHTyrUlxBOimgM1zyIeOEKJAf300KNBlTUUUU1RzswJMhXa6Ehc9haOTnfYdqcQRx+1f7ztnqbHujPfITzRCjTA8DPMHfYe/Z/MhPPZr9MIHubFjizenRU/tBjm6f/WuAjMj+CoDxDUwR7cD+ZMwAvYzyY5A3hBG/iJrJfqvYcF2g9GNZFwYI4MsgrYh8SM4tViEVr//B4AxSGNiCp8Utgyy7qilRWcViEzl/t2cqXxK9p4lG7xkN+nC4qOcNTwtQASmX3WqUA2nt3yb7J9t84iAKYIFvWxdiHLonxs89bfanpgLW9ZG4Dt2YycGZo3+wVbCFDzQ8MlzM+ibTXifaTYyWWIEEZFrm3nkVQxsu337VGUdtA60uM8GxawG7zARWeoE+6wC+E2G6kUyXYybm5IBDXQMYWprjhWLyAB1D+bjXzldcG8rUvbk2zHzzg4BEf36kzHwqmCWiuxKKtzGTZce5XQqF1Jd8p9c/Gc\\u003d\\",\\"ephemeralPublicKey\\":\\"BGJ+y+S+rQ+6IywwstXdh2nzHwP3LKcvI58XAN3LW3PoSNlWuNluRJ6cJ3dn7XP6dl+m2y8SuzXFxelPspg8moY\\u003d\\",\\"tag\\":\\"v8r09doA5qKuA8SeLuQVgKCsJxdorUgoj/Rmh0/5MLk\\u003d\\"}\"}",
        Track1 = "B5413330089020029^MTIP02^2512629807900000000000000000",
        Track2 = "5413330000000000=2512101123456789",
    },
);

var res = await sdk.Transaction.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [RestAPIRequestBody](../../Models/Operations/RestAPIRequestBody.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[RestAPIResponse](../../Models/Operations/RestAPIResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

## Modify

Initiate a <b>Modify/Adjust/AddTip</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Modify</b> transaction is used to alter the transaction amount of an original transaction, Auth or Sale.<br>
<b>Adjust</b> transaction is used to alter the transaction amount of an original transaction whether or not it has been settled, Auth or Sale.
<b>AddTip</b> transaction is used to add an additional amount to an original transaction, Auth or Sale. If the original transaction is Auth, this operation transfers the Auth to Sale.<br>
<hr>
<sup>1</sup>Use the examples for different 'Modify' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGeneric req = RequestGeneric.CreateRequestGenericGrpTraceSchemas1(
    new GrpTraceSchemas1() {
        AllowsPartialAuth = SchemasGrpTraceAllowsPartialAuth.N,
        CheckDuplicate = SchemasGrpTraceCheckDuplicate.N,
        CreditOnFailure = SchemasGrpTraceCreditOnFailure.N,
        Gmid = "1110222484",
        Gmpw = "GMPW3010300378",
        Gtid = "GT1120095178",
        Gtrc = "e134bff9203f44e8974a11b2aef7665d",
        IgnoreAVSResult = SchemasGrpTraceIgnoreAVSResult.Y,
        IgnoreCVVResult = SchemasGrpTraceIgnoreCVVResult.Y,
        IgnoreVoidResult = SchemasGrpTraceIgnoreVoidResult.Y,
        IsOffline = SchemasGrpTraceIsOffline.N,
        NewGTRC = "fe31047eca6b47f2a07ead29be5a7672",
        SourceTraceNum = "123456",
        TransType = SchemasGrpTraceTransType.Sale,
        VerifyCard = SchemasGrpTraceVerifyCard.N,
    },
);

var res = await sdk.Transaction.ModifyAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [RequestGeneric](../../Models/Shared/RequestGeneric.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[RestAPIModifyResponse](../../Models/Operations/RestAPIModifyResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

## Void

Initiate a <b>Void/Reverse/Cancel</b> transaction request to Netevia Gateway.<sup>1</sup><br>
<b>Void</b> transaction is used to cancel an authorized transaction before it has been settled.<br>
<b>Reverse</b> transaction is used to cancel an authorized transaction whether or not it has been settled.<br>
<b>Cancel</b> transaction is used to cancel an authorized transaction before it has been settled.
<hr>
<sup>1</sup>Use the examples for different 'Void/Reverse/Cancel' flavours
<br><br><span style="color:red">*NOTE: If you don't see Request Schema, you are in "Try it out" mode and you need to press "Cancel"!</span>


### Example Usage

```csharp
using Netevia;
using Netevia.Models.Shared;

var sdk = new Gateway();

RequestGeneric req = RequestGeneric.CreateRequestGenericGrpExtendInfoSchemas(
    new GrpExtendInfoSchemas() {
        AdditionalInfo = "Key1=Val10x1CKey2=Val2...",
        AllowsPartialAuth = SchemasGrpExtendInfoAllowsPartialAuth.N,
        AuthCode = "OK1234",
        CheckDuplicate = SchemasGrpExtendInfoCheckDuplicate.N,
        CreditOnFailure = SchemasGrpExtendInfoCreditOnFailure.N,
        Gmid = "1110222484",
        Gmpw = "GMPW3010300378",
        Gtid = "GT1120095178",
        IgnoreAVSResult = SchemasGrpExtendInfoIgnoreAVSResult.Y,
        IgnoreCVVResult = SchemasGrpExtendInfoIgnoreCVVResult.Y,
        IgnoreVoidResult = SchemasGrpExtendInfoIgnoreVoidResult.Y,
        InvoiceNum = "Inv123456",
        IsOffline = SchemasGrpExtendInfoIsOffline.N,
        OrderNum = "Ord12345",
        TransType = SchemasGrpExtendInfoTransType.Sale,
        VerifyCard = SchemasGrpExtendInfoVerifyCard.N,
        VoucherNum = "Voucher12345",
    },
);

var res = await sdk.Transaction.VoidAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [RequestGeneric](../../Models/Shared/RequestGeneric.md) | :heavy_check_mark:                                      | The request object to use for the request.              |


### Response

**[RestAPIVoidResponse](../../Models/Operations/RestAPIVoidResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Netevia.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
