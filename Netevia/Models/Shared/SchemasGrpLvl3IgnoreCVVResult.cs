
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
    public enum SchemasGrpLvl3IgnoreCVVResult
    {
        [JsonProperty("Y")]
        Y,
        [JsonProperty("N")]
        N,
    }

    public static class SchemasGrpLvl3IgnoreCVVResultExtension
    {
        public static string Value(this SchemasGrpLvl3IgnoreCVVResult value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasGrpLvl3IgnoreCVVResult ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasGrpLvl3IgnoreCVVResult).GetFields())
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

                    if (enumVal is SchemasGrpLvl3IgnoreCVVResult)
                    {
                        return (SchemasGrpLvl3IgnoreCVVResult)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasGrpLvl3IgnoreCVVResult");
        }
    }

}