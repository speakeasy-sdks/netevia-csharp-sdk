
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
    /// Ignore Void result from processor. if processor return fail, then we force it to success. Default value is Y,
    /// </summary>
    public enum SchemasGrpPINIgnoreVoidResult
    {
        [JsonProperty("Y")]
        Y,
        [JsonProperty("N")]
        N,
    }

    public static class SchemasGrpPINIgnoreVoidResultExtension
    {
        public static string Value(this SchemasGrpPINIgnoreVoidResult value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasGrpPINIgnoreVoidResult ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasGrpPINIgnoreVoidResult).GetFields())
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

                    if (enumVal is SchemasGrpPINIgnoreVoidResult)
                    {
                        return (SchemasGrpPINIgnoreVoidResult)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasGrpPINIgnoreVoidResult");
        }
    }

}