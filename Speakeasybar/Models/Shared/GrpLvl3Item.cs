
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
    /// Purchase Level 3 Item Data.&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// Item1, Item2,...ItemN where N is the items count.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpLvl3Item
    {

        /// <summary>
        /// An international description code of the individual good or service being supplied.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemCommodityCode")]
        public string? ItemCommodityCode { get; set; }

        /// <summary>
        /// An alphanumeric description of the item(s) being supplied.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemDescription")]
        public string? ItemDescription { get; set; }

        /// <summary>
        /// The total discount amount applied against the line item total. This field should be zeroes if the unit cost reflects a discount price or if no line item discount applies.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemDiscount")]
        public string? ItemDiscount { get; set; }

        /// <summary>
        /// A merchant defined description code of the item being purchased.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemProductionCode")]
        public string? ItemProductionCode { get; set; }

        /// <summary>
        /// The quantity of the item(s) being.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemQuantity")]
        public string? ItemQuantity { get; set; }

        /// <summary>
        /// The amount of any value added taxes which can be associated with the purchased item.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemTaxAmt")]
        public string? ItemTaxAmt { get; set; }

        /// <summary>
        /// The tax rate used to calculate the sales tax amount appearing in Payment transaction identifier - Mastercard only.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemTaxRate")]
        public string? ItemTaxRate { get; set; }

        /// <summary>
        /// The purchase amount associated with the specific line item detail record.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemTotalAmt")]
        public string? ItemTotalAmt { get; set; }

        /// <summary>
        /// The alphanumeric code for units of measurement as used in international trade.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemUnit")]
        public string? ItemUnit { get; set; }

        /// <summary>
        /// The unit cost of the item purchased. This field reflects an implied decimal point of a four character numeric.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ItemUnitCost")]
        public string? ItemUnitCost { get; set; }
    }
}