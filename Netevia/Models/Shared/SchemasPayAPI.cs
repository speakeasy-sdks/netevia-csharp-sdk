
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
    /// indicate the pay protocol.
    /// </summary>
    public enum SchemasPayAPI
    {
        [JsonProperty("GooglePay")]
        GooglePay,
        [JsonProperty("ApplePay")]
        ApplePay,
    }

    public static class SchemasPayAPIExtension
    {
        public static string Value(this SchemasPayAPI value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasPayAPI ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasPayAPI).GetFields())
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

                    if (enumVal is SchemasPayAPI)
                    {
                        return (SchemasPayAPI)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasPayAPI");
        }
    }

}