
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
    /// Request Terminal Info. Group<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpTerminalInfoSchemas
    {

        /// <summary>
        /// Indicates whether partial authorization is allowed.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("AllowsPartialAuth")]
        public SchemasGrpTerminalInfoAllowsPartialAuth? AllowsPartialAuth { get; set; }

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
        public SchemasGrpTerminalInfoCheckDuplicate? CheckDuplicate { get; set; }

        /// <summary>
        /// Indicates whether do force void transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("CreditOnFailure")]
        public SchemasGrpTerminalInfoCreditOnFailure? CreditOnFailure { get; set; }

        /// <summary>
        /// The name of pinpad configuration file that upload to the pinpad.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("FileName")]
        public string? FileName { get; set; }

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
        public SchemasGrpTerminalInfoIgnoreAVSResult? IgnoreAVSResult { get; set; }

        /// <summary>
        /// Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn&apos;t Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn&apos;t ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.
        /// </summary>
        [JsonProperty("IgnoreCVVResult")]
        public SchemasGrpTerminalInfoIgnoreCVVResult? IgnoreCVVResult { get; set; }

        /// <summary>
        /// Ignore Void result from processor. if processor return fail, then we force it to success. Default value is Y,
        /// </summary>
        [JsonProperty("IgnoreVoidResult")]
        public SchemasGrpTerminalInfoIgnoreVoidResult? IgnoreVoidResult { get; set; }

        /// <summary>
        /// Base64 encode image.
        /// </summary>
        [JsonProperty("ImageData")]
        public string? ImageData { get; set; }

        /// <summary>
        /// The ID index of image.
        /// </summary>
        [JsonProperty("ImageID")]
        public SchemasImageID? ImageID { get; set; }

        /// <summary>
        /// The length of image data.
        /// </summary>
        [JsonProperty("ImageLength")]
        public string? ImageLength { get; set; }

        /// <summary>
        /// The ID list of image that needs to be displayed on the PinPad&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Valid values:&lt;br&gt;<br/>
        /// 001 002 003 004 005 006 007 008 009 010 012 013<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ImageList")]
        public string? ImageList { get; set; }

        /// <summary>
        /// Indicates whether is an offline transaction.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("IsOffline")]
        public SchemasGrpTerminalInfoIsOffline? IsOffline { get; set; }

        /// <summary>
        /// Index of question display on the pin pad.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Used in AskNumberQuestion&lt;br&gt;<br/>
        /// Valid values:&lt;br&gt;<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;001: Please enter your home phone number&lt;/li&gt;<br/>
        ///   &lt;li&gt;002: Please enter your 10-digit HOME phone number&lt;/li&gt;<br/>
        ///   &lt;li&gt;003: Please enter your date of birth&lt;/li&gt;<br/>
        ///   &lt;li&gt;004: Please Enter ZIP Code&lt;/li&gt;<br/>
        ///   &lt;li&gt;010: Enter Card Number&lt;/li&gt;<br/>
        ///   &lt;li&gt;011: Enter Expiration Date&lt;/li&gt;<br/>
        ///   &lt;li&gt;012: Enter CVV or CID from card&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Used in UploadMessage&lt;br&gt;<br/>
        /// Valid values&lt;br&gt;<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;1001: replace built-in message &quot;Lane Closed&quot;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("MessageIndex")]
        public string? MessageIndex { get; set; }

        /// <summary>
        /// Text to be displayed on pin pad. Used in AskSelectionQuestion, ShowMessage, UploadMessage, ESignature<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("MessageText")]
        public string? MessageText { get; set; }

        /// <summary>
        /// The pinpad model.
        /// </summary>
        [JsonProperty("Model")]
        public SchemasModel? Model { get; set; }

        /// <summary>
        /// Indicates whether to print receipt.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("NeedReceipt")]
        public SchemasNeedReceipt? NeedReceipt { get; set; }

        /// <summary>
        /// Only supported for swipe/manual key entry transactions in Local and Cloud PDC and for electronic signature capable terminals. Indicates whether PDC returns signature data in response message.
        /// </summary>
        [JsonProperty("NeedSignature")]
        public SchemasNeedSignature? NeedSignature { get; set; }

        /// <summary>
        /// This field is used when sending a request to a PDC. Indicates whether the card data should be retrieved using the pinpad(&quot;Y&quot;) or it is not needed(Void/Refund) or already provided in the request(&quot;N&quot;). This works for all entry modes Manual/Swipe/EMV/Contactless.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("NeedSwipeCard")]
        public SchemasGrpTerminalInfoNeedSwipeCard? NeedSwipeCard { get; set; }

        /// <summary>
        /// Pin pad’s serial number.&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Used in Register, Unregister request.&lt;br&gt;<br/>
        /// Valid values:&lt;br&gt;<br/>
        /// Full serial number: 14281PP81035776,&lt;br&gt;<br/>
        /// Last 8 digit of serial number: 81035776<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("SN")]
        public string? Sn { get; set; }

        /// <summary>
        /// Terms and Conditions to be displayed on the pinpad for the customer to accept and then capture an electronic signature. Used in ESignature.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TermsAndConditions")]
        public string? TermsAndConditions { get; set; }

        /// <summary>
        /// Transaction Type.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("TransType")]
        public SchemasGrpTerminalInfoTransType TransType { get; set; } = default!;

        /// <summary>
        /// Indicates whether verify card when doing CreateCardToken.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("VerifyCard")]
        public SchemasGrpTerminalInfoVerifyCard? VerifyCard { get; set; }
    }
}