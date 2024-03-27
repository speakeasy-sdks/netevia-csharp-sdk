
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
    /// Additional Information about TaxAmt.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasTaxIndicator
    {
        [JsonProperty("Ntprvd")]
        Ntprvd,
        [JsonProperty("NonTax")]
        NonTax,
        [JsonProperty("Prvded")]
        Prvded,
    }

    public static class SchemasTaxIndicatorExtension
    {
        public static string Value(this SchemasTaxIndicator value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasTaxIndicator ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasTaxIndicator).GetFields())
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

                    if (enumVal is SchemasTaxIndicator)
                    {
                        return (SchemasTaxIndicator)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasTaxIndicator");
        }
    }

}