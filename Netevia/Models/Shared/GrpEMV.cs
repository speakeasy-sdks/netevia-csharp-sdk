
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
    using Newtonsoft.Json;
    
    /// <summary>
    /// EMV Custom Control Pin pad.&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// All fields are Hex-ASCII encoded<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class GrpEMV
    {

        /// <summary>
        /// Issuer Identification Number.
        /// </summary>
        [JsonProperty("EMV42")]
        public string? Emv42 { get; set; }

        /// <summary>
        /// Application Identifier (AID).
        /// </summary>
        [JsonProperty("EMV4F")]
        public string? Emv4F { get; set; }

        /// <summary>
        /// Application Label.
        /// </summary>
        [JsonProperty("EMV50")]
        public string? Emv50 { get; set; }

        /// <summary>
        /// Track 2 Equivalent Data.
        /// </summary>
        [JsonProperty("EMV57")]
        public string? Emv57 { get; set; }

        /// <summary>
        /// Primary Account Number.
        /// </summary>
        [JsonProperty("EMV5A")]
        public string? Emv5A { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("EMV5F20")]
        public string? Emv5F20 { get; set; }

        /// <summary>
        /// Expiry Date.
        /// </summary>
        [JsonProperty("EMV5F24")]
        public string? Emv5F24 { get; set; }

        /// <summary>
        /// Issuer Country Code, 3 digit numeric.
        /// </summary>
        [JsonProperty("EMV5F28")]
        public string? Emv5F28 { get; set; }

        /// <summary>
        /// Transaction Currency Code.
        /// </summary>
        [JsonProperty("EMV5F2A")]
        public string? Emv5F2A { get; set; }

        /// <summary>
        /// Preferred languages.
        /// </summary>
        [JsonProperty("EMV5F2D")]
        public string? Emv5F2D { get; set; }

        /// <summary>
        /// Service Code.
        /// </summary>
        [JsonProperty("EMV5F30")]
        public string? Emv5F30 { get; set; }

        /// <summary>
        /// Application PAN Sequence Number.
        /// </summary>
        [JsonProperty("EMV5F34")]
        public string? Emv5F34 { get; set; }

        /// <summary>
        /// Bank Identifier Code (BIC).
        /// </summary>
        [JsonProperty("EMV5F54")]
        public string? Emv5F54 { get; set; }

        /// <summary>
        /// Issuer Country Code, 2 digit alpha.
        /// </summary>
        [JsonProperty("EMV5F55")]
        public string? Emv5F55 { get; set; }

        /// <summary>
        /// Issuer Country Code, 3 digit alpha.
        /// </summary>
        [JsonProperty("EMV5F56")]
        public string? Emv5F56 { get; set; }

        /// <summary>
        /// Issuer script template 1.
        /// </summary>
        [JsonProperty("EMV71")]
        public string? Emv71 { get; set; }

        /// <summary>
        /// Issuer script template 2.
        /// </summary>
        [JsonProperty("EMV72")]
        public string? Emv72 { get; set; }

        /// <summary>
        /// Application Interchange Profile.
        /// </summary>
        [JsonProperty("EMV82")]
        public string? Emv82 { get; set; }

        /// <summary>
        /// Dedicated File (DF) Name.
        /// </summary>
        [JsonProperty("EMV84")]
        public string? Emv84 { get; set; }

        /// <summary>
        /// Application Priority Indicator.
        /// </summary>
        [JsonProperty("EMV87")]
        public string? Emv87 { get; set; }

        /// <summary>
        /// Authorization Response Code.
        /// </summary>
        [JsonProperty("EMV8A")]
        public string? Emv8A { get; set; }

        /// <summary>
        /// Card Holder Verification Method (CVM) List.
        /// </summary>
        [JsonProperty("EMV8E")]
        public string? Emv8E { get; set; }

        /// <summary>
        /// Issuer Authentication Data.
        /// </summary>
        [JsonProperty("EMV91")]
        public string? Emv91 { get; set; }

        /// <summary>
        /// Terminal Verification Results.
        /// </summary>
        [JsonProperty("EMV95")]
        public string? Emv95 { get; set; }

        /// <summary>
        /// Transaction Date.
        /// </summary>
        [JsonProperty("EMV9A")]
        public string? Emv9A { get; set; }

        /// <summary>
        /// Transaction Status Information.
        /// </summary>
        [JsonProperty("EMV9B")]
        public string? Emv9B { get; set; }

        /// <summary>
        /// Transaction Type.
        /// </summary>
        [JsonProperty("EMV9C")]
        public string? Emv9C { get; set; }

        /// <summary>
        /// Amount, Authorized (Numeric).
        /// </summary>
        [JsonProperty("EMV9F02")]
        public string? Emv9F02 { get; set; }

        /// <summary>
        /// Amount, Other (Numeric).
        /// </summary>
        [JsonProperty("EMV9F03")]
        public string? Emv9F03 { get; set; }

        /// <summary>
        /// Application ID Terminal.
        /// </summary>
        [JsonProperty("EMV9F06")]
        public string? Emv9F06 { get; set; }

        /// <summary>
        /// Application Usage Control.
        /// </summary>
        [JsonProperty("EMV9F07")]
        public string? Emv9F07 { get; set; }

        /// <summary>
        /// Application Version Number (ICC).
        /// </summary>
        [JsonProperty("EMV9F08")]
        public string? Emv9F08 { get; set; }

        /// <summary>
        /// Application Version Number (Terminal).
        /// </summary>
        [JsonProperty("EMV9F09")]
        public string? Emv9F09 { get; set; }

        /// <summary>
        /// Cardholder Name Extended.
        /// </summary>
        [JsonProperty("EMV9F0B")]
        public string? Emv9F0B { get; set; }

        /// <summary>
        /// Issuer Action Code Default.
        /// </summary>
        [JsonProperty("EMV9F0D")]
        public string? Emv9F0D { get; set; }

        /// <summary>
        /// Issuer Action Code Denial.
        /// </summary>
        [JsonProperty("EMV9F0E")]
        public string? Emv9F0E { get; set; }

        /// <summary>
        /// Issuer Action Code Online.
        /// </summary>
        [JsonProperty("EMV9F0F")]
        public string? Emv9F0F { get; set; }

        /// <summary>
        /// Issuer Application Data.
        /// </summary>
        [JsonProperty("EMV9F10")]
        public string? Emv9F10 { get; set; }

        /// <summary>
        /// Issuer Code Table Index.
        /// </summary>
        [JsonProperty("EMV9F11")]
        public string? Emv9F11 { get; set; }

        /// <summary>
        /// Application Preferred Name.
        /// </summary>
        [JsonProperty("EMV9F12")]
        public string? Emv9F12 { get; set; }

        /// <summary>
        /// Lower Consecutive Offline Limit
        /// </summary>
        [JsonProperty("EMV9F14")]
        public string? Emv9F14 { get; set; }

        /// <summary>
        /// PIN Try Count.
        /// </summary>
        [JsonProperty("EMV9F17")]
        public string? Emv9F17 { get; set; }

        /// <summary>
        /// Terminal Country Code.
        /// </summary>
        [JsonProperty("EMV9F1A")]
        public string? Emv9F1A { get; set; }

        /// <summary>
        /// Terminal Floor Limit.
        /// </summary>
        [JsonProperty("EMV9F1B")]
        public string? Emv9F1B { get; set; }

        /// <summary>
        /// Interface Device (IFD) Serial Number.
        /// </summary>
        [JsonProperty("EMV9F1E")]
        public string? Emv9F1E { get; set; }

        /// <summary>
        /// Track 1 Discretionary Data
        /// </summary>
        [JsonProperty("EMV9F1F")]
        public string? Emv9F1F { get; set; }

        /// <summary>
        /// Track 2 Discretionary Data
        /// </summary>
        [JsonProperty("EMV9F20")]
        public string? Emv9F20 { get; set; }

        /// <summary>
        /// Transaction Time.
        /// </summary>
        [JsonProperty("EMV9F21")]
        public string? Emv9F21 { get; set; }

        /// <summary>
        /// Application Cryptogram (AC).
        /// </summary>
        [JsonProperty("EMV9F26")]
        public string? Emv9F26 { get; set; }

        /// <summary>
        /// Cryptogram Information Data (CID).
        /// </summary>
        [JsonProperty("EMV9F27")]
        public string? Emv9F27 { get; set; }

        /// <summary>
        /// Terminal Capabilities.
        /// </summary>
        [JsonProperty("EMV9F33")]
        public string? Emv9F33 { get; set; }

        /// <summary>
        /// Cardholder Verification method (CVM) Results.
        /// </summary>
        [JsonProperty("EMV9F34")]
        public string? Emv9F34 { get; set; }

        /// <summary>
        /// Terminal Type.
        /// </summary>
        [JsonProperty("EMV9F35")]
        public string? Emv9F35 { get; set; }

        /// <summary>
        /// Application Transaction Counter (ATC).
        /// </summary>
        [JsonProperty("EMV9F36")]
        public string? Emv9F36 { get; set; }

        /// <summary>
        /// Unpredictable Number.
        /// </summary>
        [JsonProperty("EMV9F37")]
        public string? Emv9F37 { get; set; }

        /// <summary>
        /// POS Entry Mode.
        /// </summary>
        [JsonProperty("EMV9F39")]
        public string? Emv9F39 { get; set; }

        /// <summary>
        /// Additional Terminal Capabilities.
        /// </summary>
        [JsonProperty("EMV9F40")]
        public string? Emv9F40 { get; set; }

        /// <summary>
        /// Transaction Sequence Counter.
        /// </summary>
        [JsonProperty("EMV9F41")]
        public string? Emv9F41 { get; set; }

        /// <summary>
        /// Application Currency Code.
        /// </summary>
        [JsonProperty("EMV9F42")]
        public string? Emv9F42 { get; set; }

        /// <summary>
        /// Application Currency Code/DRDOL.
        /// </summary>
        [JsonProperty("EMV9F51")]
        public string? Emv9F51 { get; set; }

        /// <summary>
        /// Transaction Category Code (VISA only).
        /// </summary>
        [JsonProperty("EMV9F53")]
        public string? Emv9F53 { get; set; }

        /// <summary>
        /// Transaction Category Code (VISA only).
        /// </summary>
        [JsonProperty("EMV9F5B")]
        public string? Emv9F5B { get; set; }

        /// <summary>
        /// Available Offline Spending Amount (AOSA).
        /// </summary>
        [JsonProperty("EMV9F5D")]
        public string? Emv9F5D { get; set; }

        /// <summary>
        /// Terminal Transaction Qualifiers (TTQ)
        /// </summary>
        [JsonProperty("EMV9F66")]
        public string? Emv9F66 { get; set; }

        /// <summary>
        /// (Amex spec) - NATC (Track2) / MSD Offset.
        /// </summary>
        [JsonProperty("EMV9F67")]
        public string? Emv9F67 { get; set; }

        /// <summary>
        /// Card Transaction Qualifiers (CTQ).
        /// </summary>
        [JsonProperty("EMV9F6C")]
        public string? Emv9F6C { get; set; }

        /// <summary>
        /// EMV Proprietary tag. See brand specifications for details per brand.
        /// </summary>
        [JsonProperty("EMV9F6D")]
        public string? Emv9F6D { get; set; }

        /// <summary>
        /// Third Party Data.
        /// </summary>
        [JsonProperty("EMV9F6E")]
        public string? Emv9F6E { get; set; }

        /// <summary>
        /// Protected Data Envelope 2 &amp; Mobile CVM Results
        /// </summary>
        [JsonProperty("EMV9F71")]
        public string? Emv9F71 { get; set; }

        /// <summary>
        /// Customer Exclusive Data (CED) &amp; Merchant Custom Data.
        /// </summary>
        [JsonProperty("EMV9F7C")]
        public string? Emv9F7C { get; set; }

        /// <summary>
        /// Terminal Action Code Default.
        /// </summary>
        [JsonProperty("EMVDF03")]
        public string? Emvdf03 { get; set; }

        /// <summary>
        /// Terminal Action Code Denial.
        /// </summary>
        [JsonProperty("EMVDF04")]
        public string? Emvdf04 { get; set; }

        /// <summary>
        /// Terminal Action Code Online.
        /// </summary>
        [JsonProperty("EMVDF05")]
        public string? Emvdf05 { get; set; }

        /// <summary>
        /// Issuer Script Results.
        /// </summary>
        [JsonProperty("EMVDF11")]
        public string? Emvdf11 { get; set; }
    }
}