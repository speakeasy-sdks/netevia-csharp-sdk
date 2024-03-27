
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
    using Netevia.Models.Shared;
    using Netevia.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Numerics;
    using System;
    

    public class RequestGenericPDCType
    {
        private RequestGenericPDCType(string value) { Value = value; }

        public string Value { get; private set; }
        public static RequestGenericPDCType GrpAmountSchemas1 { get { return new RequestGenericPDCType("grp_amount_Schemas1"); } }
        
        public static RequestGenericPDCType GrpAmountExtraPDCSchemas { get { return new RequestGenericPDCType("grp_amount_extra_PDC_Schemas"); } }
        
        public static RequestGenericPDCType GrpExtendInfoSchemas1 { get { return new RequestGenericPDCType("grp_extendInfo_Schemas1"); } }
        
        public static RequestGenericPDCType GrpLvl3Schemas1 { get { return new RequestGenericPDCType("grp_Lvl3_Schemas1"); } }
        
        public static RequestGenericPDCType GrpTraceSchemas2 { get { return new RequestGenericPDCType("grp_trace_Schemas2"); } }
        
        public static RequestGenericPDCType GrpCardInfoSchemas1 { get { return new RequestGenericPDCType("grp_cardInfo_Schemas1"); } }
        
        public static RequestGenericPDCType GrpTerminalInfoSchemas { get { return new RequestGenericPDCType("grp_terminalInfo_Schemas"); } }
        
        public static RequestGenericPDCType GrpEMVSchemas1 { get { return new RequestGenericPDCType("grp_EMV_Schemas1"); } }
        
        public static RequestGenericPDCType GrpCardDataEncryptionSchemas1 { get { return new RequestGenericPDCType("grp_cardDataEncryption_Schemas1"); } }
        
        public static RequestGenericPDCType GrpPINSchemas1 { get { return new RequestGenericPDCType("grp_PIN_Schemas1"); } }
        
        public static RequestGenericPDCType GrpACHSchemas { get { return new RequestGenericPDCType("grp_ACH_Schemas"); } }
        
        public static RequestGenericPDCType Null { get { return new RequestGenericPDCType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(RequestGenericPDCType v) { return v.Value; }
        public static RequestGenericPDCType FromString(string v) {
            switch(v) {
                case "grp_amount_Schemas1": return GrpAmountSchemas1;
                case "grp_amount_extra_PDC_Schemas": return GrpAmountExtraPDCSchemas;
                case "grp_extendInfo_Schemas1": return GrpExtendInfoSchemas1;
                case "grp_Lvl3_Schemas1": return GrpLvl3Schemas1;
                case "grp_trace_Schemas2": return GrpTraceSchemas2;
                case "grp_cardInfo_Schemas1": return GrpCardInfoSchemas1;
                case "grp_terminalInfo_Schemas": return GrpTerminalInfoSchemas;
                case "grp_EMV_Schemas1": return GrpEMVSchemas1;
                case "grp_cardDataEncryption_Schemas1": return GrpCardDataEncryptionSchemas1;
                case "grp_PIN_Schemas1": return GrpPINSchemas1;
                case "grp_ACH_Schemas": return GrpACHSchemas;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for RequestGenericPDCType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((RequestGenericPDCType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// PDC specific fields.<br/>
/// 
/// <remarks>
/// 
/// </remarks>
/// </summary>
    [JsonConverter(typeof(RequestGenericPDC.RequestGenericPDCConverter))]
    public class RequestGenericPDC {
        public RequestGenericPDC(RequestGenericPDCType type) {
            Type = type;
        }
        public GrpAmountSchemas1? GrpAmountSchemas1 { get; set; } 
        public GrpAmountExtraPDCSchemas? GrpAmountExtraPDCSchemas { get; set; } 
        public GrpExtendInfoSchemas1? GrpExtendInfoSchemas1 { get; set; } 
        public GrpLvl3Schemas1? GrpLvl3Schemas1 { get; set; } 
        public GrpTraceSchemas2? GrpTraceSchemas2 { get; set; } 
        public GrpCardInfoSchemas1? GrpCardInfoSchemas1 { get; set; } 
        public GrpTerminalInfoSchemas? GrpTerminalInfoSchemas { get; set; } 
        public GrpEMVSchemas1? GrpEMVSchemas1 { get; set; } 
        public GrpCardDataEncryptionSchemas1? GrpCardDataEncryptionSchemas1 { get; set; } 
        public GrpPINSchemas1? GrpPINSchemas1 { get; set; } 
        public GrpACHSchemas? GrpACHSchemas { get; set; } 

        public RequestGenericPDCType Type { get; set; }


        public static RequestGenericPDC CreateGrpAmountSchemas1(GrpAmountSchemas1 grpAmountSchemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpAmountSchemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpAmountSchemas1 = grpAmountSchemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpAmountExtraPDCSchemas(GrpAmountExtraPDCSchemas grpAmountExtraPDCSchemas) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpAmountExtraPDCSchemas;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpAmountExtraPDCSchemas = grpAmountExtraPDCSchemas;
            return res;
        }

        public static RequestGenericPDC CreateGrpExtendInfoSchemas1(GrpExtendInfoSchemas1 grpExtendInfoSchemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpExtendInfoSchemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpExtendInfoSchemas1 = grpExtendInfoSchemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpLvl3Schemas1(GrpLvl3Schemas1 grpLvl3Schemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpLvl3Schemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpLvl3Schemas1 = grpLvl3Schemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpTraceSchemas2(GrpTraceSchemas2 grpTraceSchemas2) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpTraceSchemas2;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpTraceSchemas2 = grpTraceSchemas2;
            return res;
        }

        public static RequestGenericPDC CreateGrpCardInfoSchemas1(GrpCardInfoSchemas1 grpCardInfoSchemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpCardInfoSchemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpCardInfoSchemas1 = grpCardInfoSchemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpTerminalInfoSchemas(GrpTerminalInfoSchemas grpTerminalInfoSchemas) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpTerminalInfoSchemas;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpTerminalInfoSchemas = grpTerminalInfoSchemas;
            return res;
        }

        public static RequestGenericPDC CreateGrpEMVSchemas1(GrpEMVSchemas1 grpEMVSchemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpEMVSchemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpEMVSchemas1 = grpEMVSchemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpCardDataEncryptionSchemas1(GrpCardDataEncryptionSchemas1 grpCardDataEncryptionSchemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpCardDataEncryptionSchemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpCardDataEncryptionSchemas1 = grpCardDataEncryptionSchemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpPINSchemas1(GrpPINSchemas1 grpPINSchemas1) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpPINSchemas1;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpPINSchemas1 = grpPINSchemas1;
            return res;
        }

        public static RequestGenericPDC CreateGrpACHSchemas(GrpACHSchemas grpACHSchemas) {
            RequestGenericPDCType typ = RequestGenericPDCType.GrpACHSchemas;

            RequestGenericPDC res = new RequestGenericPDC(typ);
            res.GrpACHSchemas = grpACHSchemas;
            return res;
        }

        public static RequestGenericPDC CreateNull() {
            RequestGenericPDCType typ = RequestGenericPDCType.Null;
            return new RequestGenericPDC(typ);
        }

        public class RequestGenericPDCConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(RequestGenericPDC);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    GrpPINSchemas1? grpPINSchemas1 = JsonConvert.DeserializeObject<GrpPINSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpPINSchemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpPINSchemas1) {
                        GrpPINSchemas1 = grpPINSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpTraceSchemas2? grpTraceSchemas2 = JsonConvert.DeserializeObject<GrpTraceSchemas2>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpTraceSchemas2))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpTraceSchemas2) {
                        GrpTraceSchemas2 = grpTraceSchemas2
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpCardDataEncryptionSchemas1? grpCardDataEncryptionSchemas1 = JsonConvert.DeserializeObject<GrpCardDataEncryptionSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpCardDataEncryptionSchemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpCardDataEncryptionSchemas1) {
                        GrpCardDataEncryptionSchemas1 = grpCardDataEncryptionSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpAmountExtraPDCSchemas? grpAmountExtraPDCSchemas = JsonConvert.DeserializeObject<GrpAmountExtraPDCSchemas>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpAmountExtraPDCSchemas))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpAmountExtraPDCSchemas) {
                        GrpAmountExtraPDCSchemas = grpAmountExtraPDCSchemas
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpAmountSchemas1? grpAmountSchemas1 = JsonConvert.DeserializeObject<GrpAmountSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpAmountSchemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpAmountSchemas1) {
                        GrpAmountSchemas1 = grpAmountSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpExtendInfoSchemas1? grpExtendInfoSchemas1 = JsonConvert.DeserializeObject<GrpExtendInfoSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpExtendInfoSchemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpExtendInfoSchemas1) {
                        GrpExtendInfoSchemas1 = grpExtendInfoSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpACHSchemas? grpACHSchemas = JsonConvert.DeserializeObject<GrpACHSchemas>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpACHSchemas))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpACHSchemas) {
                        GrpACHSchemas = grpACHSchemas
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpTerminalInfoSchemas? grpTerminalInfoSchemas = JsonConvert.DeserializeObject<GrpTerminalInfoSchemas>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpTerminalInfoSchemas))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpTerminalInfoSchemas) {
                        GrpTerminalInfoSchemas = grpTerminalInfoSchemas
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpLvl3Schemas1? grpLvl3Schemas1 = JsonConvert.DeserializeObject<GrpLvl3Schemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpLvl3Schemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpLvl3Schemas1) {
                        GrpLvl3Schemas1 = grpLvl3Schemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpCardInfoSchemas1? grpCardInfoSchemas1 = JsonConvert.DeserializeObject<GrpCardInfoSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpCardInfoSchemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpCardInfoSchemas1) {
                        GrpCardInfoSchemas1 = grpCardInfoSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    GrpEMVSchemas1? grpEMVSchemas1 = JsonConvert.DeserializeObject<GrpEMVSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpEMVSchemas1))});
                    return new RequestGenericPDC(RequestGenericPDCType.GrpEMVSchemas1) {
                        GrpEMVSchemas1 = grpEMVSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                RequestGenericPDC res = (RequestGenericPDC)value;
                if (RequestGenericPDCType.FromString(res.Type).Equals(RequestGenericPDCType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.GrpAmountSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpAmountSchemas1));
                    return;
                }
                if (res.GrpAmountExtraPDCSchemas != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpAmountExtraPDCSchemas));
                    return;
                }
                if (res.GrpExtendInfoSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpExtendInfoSchemas1));
                    return;
                }
                if (res.GrpLvl3Schemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpLvl3Schemas1));
                    return;
                }
                if (res.GrpTraceSchemas2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpTraceSchemas2));
                    return;
                }
                if (res.GrpCardInfoSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpCardInfoSchemas1));
                    return;
                }
                if (res.GrpTerminalInfoSchemas != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpTerminalInfoSchemas));
                    return;
                }
                if (res.GrpEMVSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpEMVSchemas1));
                    return;
                }
                if (res.GrpCardDataEncryptionSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpCardDataEncryptionSchemas1));
                    return;
                }
                if (res.GrpPINSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpPINSchemas1));
                    return;
                }
                if (res.GrpACHSchemas != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpACHSchemas));
                    return;
                }

            }
        }

    }

}