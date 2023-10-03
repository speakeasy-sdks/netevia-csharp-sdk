
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
    /// Note: This subgroup contains fields specific to the PDC transactions.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpAmountExtraPDC
    {

        /// <summary>
        /// The feature to support cardholders choosing a predefined percentage/value or manual entering tip amount on the device. If the flag set to &apos;Y&apos; then this feature is enabled.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("RequestTipAmount")]
        public GrpAmountExtraPDCRequestTipAmount? RequestTipAmount { get; set; }

        /// <summary>
        /// Service charge amount will be used as the reference amount when calculating the percentage tip amount. In case it is missing, the MainAmt will be used as the ServiceAmt. This is usefull for use cases when the charged amount is less than the actual service amount(for cases when discounts are applied).&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Total digits = 12<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ServiceAmt")]
        public long? ServiceAmt { get; set; }

        /// <summary>
        /// This flag will specify the TipAmountRate format: a percentage, the calculated percentage amount or a fixed amount. &lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Valid values:&lt;br&gt;<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;&apos;A&apos;: TipAmountRate contains fixed tip amounts&lt;/li&gt;<br/>
        ///   &lt;li&gt;&apos;P&apos;: TipAmountRate contains percentages and the tip is the percentage of the service amount or the main amount. The pinpad will display the percentages to choose from.&lt;/li&gt;<br/>
        ///   &lt;li&gt;&apos;D&apos;: TipAmountRate contains percentages and the tip is the percentage of the service amount or the main amount. The pinpad will display the calculated amount percentages to choose from.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TipAmountPromptFormat")]
        public GrpAmountExtraPDCTipAmountPromptFormat? TipAmountPromptFormat { get; set; }

        /// <summary>
        /// The &quot;TipAmountRate&quot; is used to set 3 predefined tip values. The specific meaning of the data is determined by the field TipAmountPromptFormat.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// If TipAmountPromptFormat is &apos;A&apos; then the tip will be $0.10 $0.20 $0.30 on the device screen.&lt;br&gt;<br/>
        /// If TipAmountPromptFormat is &apos;P&apos; then the tip will be calculated based on the service amount(1000, $10.00), device will display options like 10% 20% 30% and the real tip amount is $1.00 $2.00 $3.00.&lt;br&gt;<br/>
        ///  If TipAmountPromptFormat is &apos;D&apos; then the calculated percentage tip amount will show on the device.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TipAmountRate")]
        public string? TipAmountRate { get; set; }
    }
}