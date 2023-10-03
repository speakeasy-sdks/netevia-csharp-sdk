
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasybar.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Purchase Level 3 Data Group.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpLvl3
    {

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
        /// Indicates that the transaction is Purchase Level III.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CommercialL3")]
        public GrpLvl3CommercialL3? CommercialL3 { get; set; }

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
        /// The invoice number that is associated with the VAT invoice.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("InvoiceNum")]
        public string? InvoiceNum { get; set; }

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
        public GrpLvl3LocalTaxIncludedFlag? LocalTaxIncludedFlag { get; set; }

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
    }
}