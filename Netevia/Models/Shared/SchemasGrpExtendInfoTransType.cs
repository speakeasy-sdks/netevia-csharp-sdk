
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
    using System;
    
    /// <summary>
    /// Transaction Type.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasGrpExtendInfoTransType
    {
        [JsonProperty("Auth")]
        Auth,
        [JsonProperty("Sale")]
        Sale,
        [JsonProperty("Credit")]
        Credit,
        [JsonProperty("Finalize")]
        Finalize,
        [JsonProperty("Addtip")]
        Addtip,
        [JsonProperty("Void")]
        Void,
        [JsonProperty("Reverse")]
        Reverse,
        [JsonProperty("Refund")]
        Refund,
        [JsonProperty("Inquiry")]
        Inquiry,
        [JsonProperty("Modify")]
        Modify,
        [JsonProperty("Batch")]
        Batch,
        [JsonProperty("BatchLookup")]
        BatchLookup,
        [JsonProperty("BatchQuery")]
        BatchQuery,
        [JsonProperty("UpdateCardTokenInfo")]
        UpdateCardTokenInfo,
        [JsonProperty("DeleteCardToken")]
        DeleteCardToken,
        [JsonProperty("CreateCardToken")]
        CreateCardToken,
        [JsonProperty("GetTransInfo")]
        GetTransInfo,
        [JsonProperty("Verify")]
        Verify,
        [JsonProperty("Register")]
        Register,
        [JsonProperty("Unregister")]
        Unregister,
        [JsonProperty("GetStatus")]
        GetStatus,
        [JsonProperty("AskNumberQuestion")]
        AskNumberQuestion,
        [JsonProperty("AskSelectionQuestion")]
        AskSelectionQuestion,
        [JsonProperty("ShowMessage")]
        ShowMessage,
        [JsonProperty("UploadImage")]
        UploadImage,
        [JsonProperty("SetImageList")]
        SetImageList,
        [JsonProperty("UploadMessage")]
        UploadMessage,
        [JsonProperty("ResetMessage")]
        ResetMessage,
        [JsonProperty("RebootDevice")]
        RebootDevice,
        [JsonProperty("UploadFile")]
        UploadFile,
        [JsonProperty("PrintReceipt")]
        PrintReceipt,
        [JsonProperty("ESignature")]
        ESignature,
        [JsonProperty("CardRead")]
        CardRead,
    }

    public static class SchemasGrpExtendInfoTransTypeExtension
    {
        public static string Value(this SchemasGrpExtendInfoTransType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasGrpExtendInfoTransType ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasGrpExtendInfoTransType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is SchemasGrpExtendInfoTransType)
                    {
                        return (SchemasGrpExtendInfoTransType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasGrpExtendInfoTransType");
        }
    }

}