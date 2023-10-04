
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Gateway.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The ID index of image.
    /// </summary>
    public enum GrpTerminalInfoImageID
    {
        [JsonProperty("001")]
        One,
        [JsonProperty("002")]
        Two,
        [JsonProperty("003")]
        Three,
        [JsonProperty("004")]
        Four,
        [JsonProperty("005")]
        Five,
        [JsonProperty("006")]
        Six,
        [JsonProperty("007")]
        Seven,
        [JsonProperty("008")]
        Eight,
        [JsonProperty("009")]
        Nine,
        [JsonProperty("010")]
        Ten,
        [JsonProperty("012")]
        Twelve,
        [JsonProperty("013")]
        Thirteen,
    }

    public static class GrpTerminalInfoImageIDExtension
    {
        public static string Value(this GrpTerminalInfoImageID value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GrpTerminalInfoImageID ToEnum(this string value)
        {
            foreach(var field in typeof(GrpTerminalInfoImageID).GetFields())
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

                    if (enumVal is GrpTerminalInfoImageID)
                    {
                        return (GrpTerminalInfoImageID)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GrpTerminalInfoImageID");
        }
    }
}