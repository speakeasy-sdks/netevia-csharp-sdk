
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
    /// Indicates the type of data that is being encrypted.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum SchemasEncrptTrgt
    {
        [JsonProperty("Track1")]
        Track1,
        [JsonProperty("Track2")]
        Track2,
        [JsonProperty("PAN")]
        Pan,
    }

    public static class SchemasEncrptTrgtExtension
    {
        public static string Value(this SchemasEncrptTrgt value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasEncrptTrgt ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasEncrptTrgt).GetFields())
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

                    if (enumVal is SchemasEncrptTrgt)
                    {
                        return (SchemasEncrptTrgt)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasEncrptTrgt");
        }
    }

}