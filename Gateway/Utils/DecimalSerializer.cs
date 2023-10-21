
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Gateway.Utils
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;

    internal class DecimalSerializer : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(Decimal);

        public override bool CanRead => true;

        public override object? ReadJson(
            JsonReader reader,
            Type objectType,
            object? existingValue,
            JsonSerializer serializer
        )
        {
            if (reader.Value == null)
            {
                return null;
            }

            return Decimal.Parse(reader.Value.ToString()!);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteValue("null");
                return;
            }

            writer.WriteValue(((Decimal)value).ToString(CultureInfo.InvariantCulture));
        }
    }
}
