
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
    /// Ignore CVV result from processor, default value is Y, if need to check CVV result please send it in request with N. the feature only works in TSYS and Elavon. Elavon, if doesn&apos;t Ignore CVV and host return N then Netevia will reject the Verify request. TSYS, if doesn&apos;t ignore cvv and host return N then Netevia will reject the Verify/Auth/Sale request.
    /// </summary>
    public enum SchemasGrpTraceIgnoreCVVResult
    {
        [JsonProperty("Y")]
        Y,
        [JsonProperty("N")]
        N,
    }

    public static class SchemasGrpTraceIgnoreCVVResultExtension
    {
        public static string Value(this SchemasGrpTraceIgnoreCVVResult value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasGrpTraceIgnoreCVVResult ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasGrpTraceIgnoreCVVResult).GetFields())
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

                    if (enumVal is SchemasGrpTraceIgnoreCVVResult)
                    {
                        return (SchemasGrpTraceIgnoreCVVResult)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasGrpTraceIgnoreCVVResult");
        }
    }

}