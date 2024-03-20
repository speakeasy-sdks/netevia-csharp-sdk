
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
    /// Encryption Data Group.&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// These are present for P2PE enabled card readers<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpCardDataEncryptionSchemas
    {

        /// <summary>
        /// Indicates whether partial authorization is allowed.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("AllowsPartialAuth")]
        public SchemasGrpCardDataEncryptionAllowsPartialAuth? AllowsPartialAuth { get; set; }

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
        public SchemasGrpCardDataEncryptionCheckDuplicate? CheckDuplicate { get; set; }

        /// <summary>
        /// Indicates whether do force void transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CreditOnFailure")]
        public SchemasGrpCardDataEncryptionCreditOnFailure? CreditOnFailure { get; set; }

        /// <summary>
        /// Contains the track data or card number provided in an encrypted block. Be Present when card data is encrypted.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("EncrptBlock")]
        public string? EncrptBlock { get; set; }

        /// <summary>
        /// Indicates the type of data that is being encrypted.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("EncrptTrgt")]
        public SchemasEncrptTrgt? EncrptTrgt { get; set; }

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
        public SchemasGrpCardDataEncryptionIgnoreAVSResult? IgnoreAVSResult { get; set; }

        /// <summary>
        /// Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn&apos;t Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn&apos;t ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.
        /// </summary>
        [JsonProperty("IgnoreCVVResult")]
        public SchemasGrpCardDataEncryptionIgnoreCVVResult? IgnoreCVVResult { get; set; }

        /// <summary>
        /// Ignore Void result from processor. if processor return fail, then we force it to success. Default value is Y,
        /// </summary>
        [JsonProperty("IgnoreVoidResult")]
        public SchemasGrpCardDataEncryptionIgnoreVoidResult? IgnoreVoidResult { get; set; }

        /// <summary>
        /// Indicates whether is an offline transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("IsOffline")]
        public SchemasGrpCardDataEncryptionIsOffline? IsOffline { get; set; }

        /// <summary>
        /// This is an identifier used to retrieve the private key, which is required for decryption.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("KeyID")]
        public string? KeyID { get; set; }

        /// <summary>
        /// Transaction Type.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TransType")]
        public SchemasGrpCardDataEncryptionTransType TransType { get; set; } = default!;

        /// <summary>
        /// Indicates whether verify card when doing CreateCardToken.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("VerifyCard")]
        public SchemasGrpCardDataEncryptionVerifyCard? VerifyCard { get; set; }
    }
}