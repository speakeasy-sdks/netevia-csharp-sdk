
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
    /// ACH Debit transaction type.
    /// </summary>
    public enum EleCheckServiceProvider
    {
        [JsonProperty("ElecCheckWEB")]
        ElecCheckWEB,
        [JsonProperty("ElecCheckTEL")]
        ElecCheckTEL,
        [JsonProperty("ElecCheckPPD")]
        ElecCheckPPD,
        [JsonProperty("ElecCheckCCD")]
        ElecCheckCCD,
        [JsonProperty("ElecCheckPOP")]
        ElecCheckPOP,
        [JsonProperty("ElecCheckARC")]
        ElecCheckARC,
        [JsonProperty("ElecCheckBOC")]
        ElecCheckBOC,
        [JsonProperty("ElecCheckECA")]
        ElecCheckECA,
        [JsonProperty("ElecCheckICA")]
        ElecCheckICA,
        [JsonProperty("ElecCheckCBP")]
        ElecCheckCBP,
        [JsonProperty("ElecCheckCertegy")]
        ElecCheckCertegy,
    }

    public static class EleCheckServiceProviderExtension
    {
        public static string Value(this EleCheckServiceProvider value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static EleCheckServiceProvider ToEnum(this string value)
        {
            foreach(var field in typeof(EleCheckServiceProvider).GetFields())
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

                    if (enumVal is EleCheckServiceProvider)
                    {
                        return (EleCheckServiceProvider)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum EleCheckServiceProvider");
        }
    }

}