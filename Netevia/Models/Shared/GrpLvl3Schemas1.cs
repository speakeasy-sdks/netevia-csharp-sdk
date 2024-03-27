
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Netevia.Models.Shared
{
    using Netevia.Models.Shared;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Purchase Level 3 Data Group.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpLvl3Schemas1
    {

        /// <summary>
        /// Indicates whether partial authorization is allowed.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("AllowsPartialAuth")]
        public SchemasGrpLvl3AllowsPartialAuth? AllowsPartialAuth { get; set; }

        /// <summary>
        /// The government assigned tax identification number of the merchant from whom the goods or services were purchased from.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("BusinessRefNum")]
        public string? BusinessRefNum { get; set; }

        /// <summary>
        /// Indicates whether to check for duplicate transactions.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Duplicate check interval: 1 minute.&lt;br&gt;<br/>
        /// Note: you need to supply this field in all the request to enable this feature.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CheckDuplicate")]
        public SchemasGrpLvl3CheckDuplicate? CheckDuplicate { get; set; }

        /// <summary>
        /// Indicates that the transaction is Purchase Level III.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CommercialL3")]
        public SchemasCommercialL3? CommercialL3 { get; set; }

        /// <summary>
        /// Indicates whether do force void transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CreditOnFailure")]
        public SchemasGrpLvl3CreditOnFailure? CreditOnFailure { get; set; }

        /// <summary>
        /// Value Added Tax registration number supplied by the Commercial Card cardholder.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CustomerRefNum")]
        public string? CustomerRefNum { get; set; }

        /// <summary>
        /// The ISO numeric code of the country where the goods are being shipped.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("DestContryCode")]
        public string? DestContryCode { get; set; }

        /// <summary>
        /// The Postal/ZIP code of the address where purchased goods will be delivered.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("DestZIPCode")]
        public string? DestZIPCode { get; set; }

        /// <summary>
        /// Merchant identifier Assigned by&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Netevia Payment Systems Administrator during registration<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("GMID")]
        public string Gmid { get; set; } = default!;

        /// <summary>
        /// Merchant password&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Only verified for Refund transactions.&lt;br&gt;<br/>
        /// It can be any value for other transactions.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("GMPW")]
        public string Gmpw { get; set; } = default!;

        /// <summary>
        /// Merchant&apos;s terminal identifier&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Assigned by Netevia Payment Systems Administrator during registration.&lt;br&gt;<br/>
        /// This field is Optional when doing Register.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("GTID")]
        public string Gtid { get; set; } = default!;

        /// <summary>
        /// Ignore AVS result from processor, default value is Y, if need to check AVS result please send it in request with N. the feature only works in TSYS and Elavon. Elavon if host return the code (A,B,C,E,N,R,W,Z) and doesnt&apos; ignore avs result code then Netevia will reject the verify request. TSYS if host return N and doesn&apos;t ignore avs result then Netevia will reject the Verify, Auth, Sale request.
        /// </summary>
        [JsonProperty("IgnoreAVSResult")]
        public SchemasGrpLvl3IgnoreAVSResult? IgnoreAVSResult { get; set; }

        /// <summary>
        /// Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn&apos;t Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn&apos;t ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.
        /// </summary>
        [JsonProperty("IgnoreCVVResult")]
        public SchemasGrpLvl3IgnoreCVVResult? IgnoreCVVResult { get; set; }

        /// <summary>
        /// Ignore Void result from processor. if processor return fail, then we force it to success. Default value is Y,
        /// </summary>
        [JsonProperty("IgnoreVoidResult")]
        public SchemasGrpLvl3IgnoreVoidResult? IgnoreVoidResult { get; set; }

        /// <summary>
        /// The invoice number that is associated with the VAT invoice.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("InvoiceNum")]
        public string? InvoiceNum { get; set; }

        /// <summary>
        /// Indicates whether is an offline transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("IsOffline")]
        public SchemasGrpLvl3IsOffline? IsOffline { get; set; }

        /// <summary>
        /// Purchase Level 3 Item Data.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Item1, Item2,...ItemN where N is the items count.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("Item1")]
        public GrpLvl3Item? Item1 { get; set; }

        /// <summary>
        /// The total number of line item detail records associated with the transaction being settled.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemCount")]
        public long? ItemCount { get; set; }

        /// <summary>
        /// The sales tax associated with the purchase.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Total digits = 12<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("LocalTaxAmt")]
        public long? LocalTaxAmt { get; set; }

        /// <summary>
        /// Provides details about the tax amount.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Valid values:&lt;br&gt;<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;0: Sales Tax not Provided&lt;/li&gt;<br/>
        ///   &lt;li&gt;1: Local or Sales Tax Amount&lt;/li&gt;<br/>
        ///   &lt;li&gt;2: Tax Exempt&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("LocalTaxIncludedFlag")]
        public SchemasLocalTaxIncludedFlag? LocalTaxIncludedFlag { get; set; }

        /// <summary>
        /// The national tax included in the transaction amount.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Total digits = 12<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("NationalTaxAmt")]
        public long? NationalTaxAmt { get; set; }

        /// <summary>
        /// This field is used when sending a request to a PDC. Indicates whether the card data should be retrieved using the pinpad(&quot;Y&quot;) or it is not needed(Void/Refund) or already provided in the request(&quot;N&quot;). This works for all entry modes Manual/Swipe/EMV/Contactless.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("NeedSwipeCard")]
        public SchemasGrpLvl3NeedSwipeCard? NeedSwipeCard { get; set; }

        /// <summary>
        /// The purchase order date and must be supplied in YYMMDD format.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("OrderDate")]
        public string? OrderDate { get; set; }

        /// <summary>
        /// The postal/ZIP code of the address from where the purchased goods are being shipped.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ShipZIP")]
        public string? ShipZIP { get; set; }

        /// <summary>
        /// An international description code of the overall goods or services being supplied. The acquirer bank or processor should provide the merchant an updated listing of currently defined codes.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("SummaryCommodityCode")]
        public string? SummaryCommodityCode { get; set; }

        /// <summary>
        /// Transaction Type.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TransType")]
        public SchemasGrpLvl3TransType TransType { get; set; } = default!;

        /// <summary>
        /// Indicates whether verify card when doing CreateCardToken.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("VerifyCard")]
        public SchemasGrpLvl3VerifyCard? VerifyCard { get; set; }
    }
}