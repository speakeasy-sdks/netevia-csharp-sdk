
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
    /// PIN Group.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpPINSchemas1
    {

        /// <summary>
        /// Indicates whether partial authorization is allowed.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("AllowsPartialAuth")]
        public SchemasGrpPINAllowsPartialAuth? AllowsPartialAuth { get; set; }

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
        public SchemasGrpPINCheckDuplicate? CheckDuplicate { get; set; }

        /// <summary>
        /// Indicates whether do force void transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CreditOnFailure")]
        public SchemasGrpPINCreditOnFailure? CreditOnFailure { get; set; }

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
        public SchemasGrpPINIgnoreAVSResult? IgnoreAVSResult { get; set; }

        /// <summary>
        /// Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn&apos;t Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn&apos;t ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.
        /// </summary>
        [JsonProperty("IgnoreCVVResult")]
        public SchemasGrpPINIgnoreCVVResult? IgnoreCVVResult { get; set; }

        /// <summary>
        /// Ignore Void result from processor. if processor return fail, then we force it to success. Default value is Y,
        /// </summary>
        [JsonProperty("IgnoreVoidResult")]
        public SchemasGrpPINIgnoreVoidResult? IgnoreVoidResult { get; set; }

        /// <summary>
        /// Indicates whether is an offline transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("IsOffline")]
        public SchemasGrpPINIsOffline? IsOffline { get; set; }

        /// <summary>
        /// Used to create the base PIN encryption key for DUKPT PIN Debit and EBT transactions. Mandatory for PIN Debit and EBT transactions.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("KSN")]
        public string? Ksn { get; set; }

        /// <summary>
        /// This field is used when sending a request to a PDC. Indicates whether the card data should be retrieved using the pinpad(&quot;Y&quot;) or it is not needed(Void/Refund) or already provided in the request(&quot;N&quot;). This works for all entry modes Manual/Swipe/EMV/Contactless.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("NeedSwipeCard")]
        public SchemasGrpPINNeedSwipeCard? NeedSwipeCard { get; set; }

        /// <summary>
        /// Contains the Encrypted PIN Block for the Debit or EBT or EMV with PIN transaction being submitted<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("PinBlock")]
        public string? PinBlock { get; set; }

        /// <summary>
        /// Transaction Type.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TransType")]
        public SchemasGrpPINTransType TransType { get; set; } = default!;

        /// <summary>
        /// Indicates whether verify card when doing CreateCardToken.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("VerifyCard")]
        public SchemasGrpPINVerifyCard? VerifyCard { get; set; }
    }
}