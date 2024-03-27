
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
    /// Indicates whether is an offline transaction.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasGrpExtendInfoIsOffline
    {
        [JsonProperty("Y")]
        Y,
        [JsonProperty("N")]
        N,
    }

    public static class SchemasGrpExtendInfoIsOfflineExtension
    {
        public static string Value(this SchemasGrpExtendInfoIsOffline value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasGrpExtendInfoIsOffline ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasGrpExtendInfoIsOffline).GetFields())
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

                    if (enumVal is SchemasGrpExtendInfoIsOffline)
                    {
                        return (SchemasGrpExtendInfoIsOffline)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasGrpExtendInfoIsOffline");
        }
    }

}