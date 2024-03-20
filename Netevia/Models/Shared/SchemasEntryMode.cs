
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
    /// Must be present when card data is provided by the POS.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasEntryMode
    {
        [JsonProperty("Swipe")]
        Swipe,
        [JsonProperty("Manual")]
        Manual,
        [JsonProperty("Proximity")]
        Proximity,
        [JsonProperty("ChipContact")]
        ChipContact,
        [JsonProperty("ChipContactless")]
        ChipContactless,
        [JsonProperty("EMVFallback2Swip")]
        EMVFallback2Swip,
    }

    public static class SchemasEntryModeExtension
    {
        public static string Value(this SchemasEntryMode value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasEntryMode ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasEntryMode).GetFields())
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

                    if (enumVal is SchemasEntryMode)
                    {
                        return (SchemasEntryMode)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasEntryMode");
        }
    }

}