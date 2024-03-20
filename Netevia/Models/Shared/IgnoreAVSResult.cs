
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
    /// Ignore AVS result from processor, default value is Y, if need to check AVS result please send it in request with N. the feature only works in TSYS and Elavon. Elavon if host return the code (A,B,C,E,N,R,W,Z) and doesnt&apos; ignore avs result code then Netevia will reject the verify request. TSYS if host return N and doesn&apos;t ignore avs result then Netevia will reject the Verify, Auth, Sale request.
    /// </summary>
    public enum IgnoreAVSResult
    {
        [JsonProperty("Y")]
        Y,
        [JsonProperty("N")]
        N,
    }

    public static class IgnoreAVSResultExtension
    {
        public static string Value(this IgnoreAVSResult value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static IgnoreAVSResult ToEnum(this string value)
        {
            foreach(var field in typeof(IgnoreAVSResult).GetFields())
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

                    if (enumVal is IgnoreAVSResult)
                    {
                        return (IgnoreAVSResult)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum IgnoreAVSResult");
        }
    }

}