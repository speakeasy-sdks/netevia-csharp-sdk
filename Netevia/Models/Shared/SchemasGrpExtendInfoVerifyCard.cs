
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
    /// Indicates whether verify card when doing CreateCardToken.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasGrpExtendInfoVerifyCard
    {
        [JsonProperty("Y")]
        Y,
        [JsonProperty("N")]
        N,
    }

    public static class SchemasGrpExtendInfoVerifyCardExtension
    {
        public static string Value(this SchemasGrpExtendInfoVerifyCard value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasGrpExtendInfoVerifyCard ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasGrpExtendInfoVerifyCard).GetFields())
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

                    if (enumVal is SchemasGrpExtendInfoVerifyCard)
                    {
                        return (SchemasGrpExtendInfoVerifyCard)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasGrpExtendInfoVerifyCard");
        }
    }

}