
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
    /// This flag will specify the TipAmountRate format: a percentage, the calculated percentage amount or a fixed amount. &lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// Valid values:&lt;br&gt;<br/>
    /// &lt;ul&gt;<br/>
    ///   &lt;li&gt;&apos;A&apos;: TipAmountRate contains fixed tip amounts&lt;/li&gt;<br/>
    ///   &lt;li&gt;&apos;P&apos;: TipAmountRate contains percentages and the tip is the percentage of the service amount or the main amount. The pinpad will display the percentages to choose from.&lt;/li&gt;<br/>
    ///   &lt;li&gt;&apos;D&apos;: TipAmountRate contains percentages and the tip is the percentage of the service amount or the main amount. The pinpad will display the calculated amount percentages to choose from.&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum TipAmountPromptFormat
    {
        [JsonProperty("P")]
        P,
        [JsonProperty("D")]
        D,
        [JsonProperty("A")]
        A,
    }

    public static class TipAmountPromptFormatExtension
    {
        public static string Value(this TipAmountPromptFormat value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TipAmountPromptFormat ToEnum(this string value)
        {
            foreach(var field in typeof(TipAmountPromptFormat).GetFields())
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

                    if (enumVal is TipAmountPromptFormat)
                    {
                        return (TipAmountPromptFormat)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TipAmountPromptFormat");
        }
    }

}