
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
    
    public enum TerminalType
    {
        [JsonProperty("None")]
        None,
        [JsonProperty("Ingenico")]
        Ingenico,
        [JsonProperty("WinPDC")]
        WinPDC,
        [JsonProperty("Pax")]
        Pax,
        [JsonProperty("Dejavoo")]
        Dejavoo,
        [JsonProperty("M6Plus")]
        M6Plus,
    }

    public static class TerminalTypeExtension
    {
        public static string Value(this TerminalType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TerminalType ToEnum(this string value)
        {
            foreach(var field in typeof(TerminalType).GetFields())
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

                    if (enumVal is TerminalType)
                    {
                        return (TerminalType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TerminalType");
        }
    }

}