
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
    using System;
    
    public enum TransType
    {
        [JsonProperty("Auth")]
        Auth,
        [JsonProperty("Sale")]
        Sale,
        [JsonProperty("AddTip")]
        AddTip,
        [JsonProperty("Finalize")]
        Finalize,
        [JsonProperty("Modify")]
        Modify,
        [JsonProperty("Refund")]
        Refund,
        [JsonProperty("Batch")]
        Batch,
        [JsonProperty("BatchQuery")]
        BatchQuery,
        [JsonProperty("SelBatch")]
        SelBatch,
        [JsonProperty("BatchLookUp")]
        BatchLookUp,
        [JsonProperty("Register")]
        Register,
        [JsonProperty("Unregister")]
        Unregister,
        [JsonProperty("GetStatus")]
        GetStatus,
        [JsonProperty("Ping")]
        Ping,
        [JsonProperty("GetTransInfo")]
        GetTransInfo,
        [JsonProperty("DeleteCardToken")]
        DeleteCardToken,
        [JsonProperty("GetCardToken")]
        GetCardToken,
        [JsonProperty("UpdateCardTokenInfo")]
        UpdateCardTokenInfo,
        [JsonProperty("CreateCardToken")]
        CreateCardToken,
        [JsonProperty("GetSessionKey")]
        GetSessionKey,
        [JsonProperty("ReAuth")]
        ReAuth,
    }

    public static class TransTypeExtension
    {
        public static string Value(this TransType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TransType ToEnum(this string value)
        {
            foreach(var field in typeof(TransType).GetFields())
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

                    if (enumVal is TransType)
                    {
                        return (TransType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TransType");
        }
    }
}