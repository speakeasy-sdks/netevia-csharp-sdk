
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Netevia.Models.Operations
{
    using Netevia.Models.Shared;
    using Netevia.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Numerics;
    using System;
    

    public class ControlDesktopPDCv2RequestBodyType
    {
        private ControlDesktopPDCv2RequestBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ControlDesktopPDCv2RequestBodyType GrpAmount { get { return new ControlDesktopPDCv2RequestBodyType("grp_amount"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpExtendInfo { get { return new ControlDesktopPDCv2RequestBodyType("grp_extendInfo"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpLvl3 { get { return new ControlDesktopPDCv2RequestBodyType("grp_Lvl3"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpTrace { get { return new ControlDesktopPDCv2RequestBodyType("grp_trace"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpCardInfo { get { return new ControlDesktopPDCv2RequestBodyType("grp_cardInfo"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpTerminalInfo { get { return new ControlDesktopPDCv2RequestBodyType("grp_terminalInfo"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpEMV { get { return new ControlDesktopPDCv2RequestBodyType("grp_EMV"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpCardDataEncryption { get { return new ControlDesktopPDCv2RequestBodyType("grp_cardDataEncryption"); } }
        
        public static ControlDesktopPDCv2RequestBodyType GrpPIN { get { return new ControlDesktopPDCv2RequestBodyType("grp_PIN"); } }
        
        public static ControlDesktopPDCv2RequestBodyType Null { get { return new ControlDesktopPDCv2RequestBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ControlDesktopPDCv2RequestBodyType v) { return v.Value; }
        public static ControlDesktopPDCv2RequestBodyType FromString(string v) {
            switch(v) {
                case "grp_amount": return GrpAmount;
                case "grp_extendInfo": return GrpExtendInfo;
                case "grp_Lvl3": return GrpLvl3;
                case "grp_trace": return GrpTrace;
                case "grp_cardInfo": return GrpCardInfo;
                case "grp_terminalInfo": return GrpTerminalInfo;
                case "grp_EMV": return GrpEMV;
                case "grp_cardDataEncryption": return GrpCardDataEncryption;
                case "grp_PIN": return GrpPIN;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ControlDesktopPDCv2RequestBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ControlDesktopPDCv2RequestBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// Generic Request body
/// </summary>
    [JsonConverter(typeof(ControlDesktopPDCv2RequestBody.ControlDesktopPDCv2RequestBodyConverter))]
    public class ControlDesktopPDCv2RequestBody {
        public ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType type) {
            Type = type;
        }
        public GrpAmount? GrpAmount { get; set; } 
        public GrpExtendInfo? GrpExtendInfo { get; set; } 
        public GrpLvl3? GrpLvl3 { get; set; } 
        public GrpTrace? GrpTrace { get; set; } 
        public GrpCardInfo? GrpCardInfo { get; set; } 
        public GrpTerminalInfo? GrpTerminalInfo { get; set; } 
        public GrpEMV? GrpEMV { get; set; } 
        public GrpCardDataEncryption? GrpCardDataEncryption { get; set; } 
        public GrpPIN? GrpPIN { get; set; } 

        public ControlDesktopPDCv2RequestBodyType Type { get; set; }


        public static ControlDesktopPDCv2RequestBody CreateGrpAmount(GrpAmount grpAmount) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpAmount;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpAmount = grpAmount;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpExtendInfo(GrpExtendInfo grpExtendInfo) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpExtendInfo;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpExtendInfo = grpExtendInfo;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpLvl3(GrpLvl3 grpLvl3) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpLvl3;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpLvl3 = grpLvl3;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpTrace(GrpTrace grpTrace) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpTrace;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpTrace = grpTrace;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpCardInfo(GrpCardInfo grpCardInfo) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpCardInfo;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpCardInfo = grpCardInfo;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpTerminalInfo(GrpTerminalInfo grpTerminalInfo) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpTerminalInfo;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpTerminalInfo = grpTerminalInfo;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpEMV(GrpEMV grpEMV) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpEMV;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpEMV = grpEMV;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpCardDataEncryption(GrpCardDataEncryption grpCardDataEncryption) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpCardDataEncryption;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpCardDataEncryption = grpCardDataEncryption;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateGrpPIN(GrpPIN grpPIN) {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.GrpPIN;

            ControlDesktopPDCv2RequestBody res = new ControlDesktopPDCv2RequestBody(typ);
            res.GrpPIN = grpPIN;
            return res;
        }

        public static ControlDesktopPDCv2RequestBody CreateNull() {
            ControlDesktopPDCv2RequestBodyType typ = ControlDesktopPDCv2RequestBodyType.Null;
            return new ControlDesktopPDCv2RequestBody(typ);
        }

        public class ControlDesktopPDCv2RequestBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ControlDesktopPDCv2RequestBody);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    GrpPIN? grpPIN = JsonConvert.DeserializeObject<GrpPIN>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpPIN))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpPIN) {
                        GrpPIN = grpPIN
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
                    GrpTrace? grpTrace = JsonConvert.DeserializeObject<GrpTrace>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpTrace))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpTrace) {
                        GrpTrace = grpTrace
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
                    GrpCardDataEncryption? grpCardDataEncryption = JsonConvert.DeserializeObject<GrpCardDataEncryption>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpCardDataEncryption))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpCardDataEncryption) {
                        GrpCardDataEncryption = grpCardDataEncryption
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
                    GrpAmount? grpAmount = JsonConvert.DeserializeObject<GrpAmount>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpAmount))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpAmount) {
                        GrpAmount = grpAmount
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
                    GrpExtendInfo? grpExtendInfo = JsonConvert.DeserializeObject<GrpExtendInfo>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpExtendInfo))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpExtendInfo) {
                        GrpExtendInfo = grpExtendInfo
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
                    GrpTerminalInfo? grpTerminalInfo = JsonConvert.DeserializeObject<GrpTerminalInfo>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpTerminalInfo))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpTerminalInfo) {
                        GrpTerminalInfo = grpTerminalInfo
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
                    GrpLvl3? grpLvl3 = JsonConvert.DeserializeObject<GrpLvl3>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpLvl3))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpLvl3) {
                        GrpLvl3 = grpLvl3
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
                    GrpCardInfo? grpCardInfo = JsonConvert.DeserializeObject<GrpCardInfo>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpCardInfo))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpCardInfo) {
                        GrpCardInfo = grpCardInfo
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
                    GrpEMV? grpEMV = JsonConvert.DeserializeObject<GrpEMV>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(GrpEMV))});
                    return new ControlDesktopPDCv2RequestBody(ControlDesktopPDCv2RequestBodyType.GrpEMV) {
                        GrpEMV = grpEMV
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
                ControlDesktopPDCv2RequestBody res = (ControlDesktopPDCv2RequestBody)value;
                if (ControlDesktopPDCv2RequestBodyType.FromString(res.Type).Equals(ControlDesktopPDCv2RequestBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.GrpAmount != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpAmount));
                    return;
                }
                if (res.GrpExtendInfo != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpExtendInfo));
                    return;
                }
                if (res.GrpLvl3 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpLvl3));
                    return;
                }
                if (res.GrpTrace != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpTrace));
                    return;
                }
                if (res.GrpCardInfo != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpCardInfo));
                    return;
                }
                if (res.GrpTerminalInfo != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpTerminalInfo));
                    return;
                }
                if (res.GrpEMV != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpEMV));
                    return;
                }
                if (res.GrpCardDataEncryption != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpCardDataEncryption));
                    return;
                }
                if (res.GrpPIN != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GrpPIN));
                    return;
                }

            }
        }

    }

}