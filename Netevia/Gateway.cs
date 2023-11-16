
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Netevia
{
    using Netevia.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// Environment<br/>
    /// 
    /// <remarks>
    ///   * gatewayapidocs <br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServerEnvironment
    {
        [JsonProperty("gatewayapidocs")]
        Gatewayapidocs,
    }

    public static class ServerEnvironmentExtension
    {
        public static string Value(this ServerEnvironment value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServerEnvironment ToEnum(this string value)
        {
            foreach(var field in typeof(ServerEnvironment).GetFields())
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

                    if (enumVal is ServerEnvironment)
                    {
                        return (ServerEnvironment)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServerEnvironment");
        }
    }
    /// <summary>
    /// Engine Port<br/>
    /// 
    /// <remarks>
    ///   * 11911<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServerPort
    {
        [JsonProperty("11911")]
        ElevenThousandNineHundredAndEleven,
    }

    public static class ServerPortExtension
    {
        public static string Value(this ServerPort value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServerPort ToEnum(this string value)
        {
            foreach(var field in typeof(ServerPort).GetFields())
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

                    if (enumVal is ServerPort)
                    {
                        return (ServerPort)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServerPort");
        }
    }
    /// <summary>
    /// Netevia API: # Netevia Gateway API for Transaction Processing&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// Netevia Payment Gateway provides a simple method of processing payment transactions for merchants who want to integrate payment processing with their existing applications. The Netevia Payment Gateway processes credit card, debit card and Electronic Benefits Transfer (EBT) transactions. Transactions are accepted from various industries including: retail, restaurant, mail order/telephone order, lodging, and E-comm.&lt;br&gt;<br/>
    /// This document describes how to write your own application for processing payment transactions or integrate payment processing capabilities into an existing application.&lt;br&gt;&lt;br&gt;<br/>
    ///   Copyright 2023 by Netevia, INC DBA Netevia Payment Services. Licensed under the Apache License, Version 2.0 (the License). You may not use this file except in compliance with the License. You may obtain a copy of the License at <a href="http://www.apache.org/licenses/LICENSE-2.0.html">http://www.apache.org/licenses/LICENSE-2.0.html</a>. Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an AS IS BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.&lt;br&gt;&lt;br&gt;<br/>
    /// <a href="https://netevia.com/">Netevia Payment Gateway Web Site</a>.&lt;br&gt;<br/>
    /// 
    /// </remarks>
    /// </summary>
    public interface IGateway
    {
        public ITransactionV2 TransactionV2 { get; }
        public IACHCreditTransactionV2 ACHCreditTransactionV2 { get; }
        public IACHDebitTransactionV2 ACHDebitTransactionV2 { get; }
        public ITransactionAuthV2 TransactionAuthV2 { get; }
        public IBatchTransaction BatchTransaction { get; }
        public IBatchQueryV2 BatchQueryV2 { get; }
        public ITransactionInfoV2 TransactionInfoV2 { get; }
        public IGiftTransactionV2 GiftTransactionV2 { get; }
        public ICloudPDCIngenicoTransactionV2 CloudPDCIngenicoTransactionV2 { get; }
        public ICloudPDCRefundv2 CloudPDCRefundv2 { get; }
        public ICloudPDCSaleTransactionV2 CloudPDCSaleTransactionV2 { get; }
        public IModifyTransactionV2 ModifyTransactionV2 { get; }
        public IRefundTransctionV2 RefundTransctionV2 { get; }
        public ISaleTransactionV2 SaleTransactionV2 { get; }
        public ITokenTransactionV2 TokenTransactionV2 { get; }
        public IVerifyTransactionV2 VerifyTransactionV2 { get; }
        public IVoidTransactionV2 VoidTransactionV2 { get; }
        public IDesktopPDCTransactionV2 DesktopPDCTransactionV2 { get; }
        public IPaymentDeviceController PaymentDeviceController { get; }
        public ICloudPDCRefund CloudPDCRefund { get; }
        public ICloudPDCSaleTransaction CloudPDCSaleTransaction { get; }
        public ITransaction Transaction { get; }
        public IQRPayTransaction QRPayTransaction { get; }
        public IACHCreditTransaction ACHCreditTransaction { get; }
        public IACHDebitTransaction ACHDebitTransaction { get; }
        public IAuth Auth { get; }
        public ITransInfo TransInfo { get; }
        public IGiftTransaction GiftTransaction { get; }
        public IRefund Refund { get; }
        public ISaleTransaction SaleTransaction { get; }
        public ITokenTransaction TokenTransaction { get; }
        public IVerify Verify { get; }
        public IGPayTransaction GPayTransaction { get; }
        public IDesktopPDCTransaction DesktopPDCTransaction { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "https://{environment}.netevia.com:{port}",
            "https://{environment}.netevia.com:{port}",
            "https://virtserver.swaggerhub.com/Netevia_INC/Netevia/0.1.0",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;
        public List<Dictionary<string, string>> ServerDefaults = new List<Dictionary<string, string>>();

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], this.ServerDefaults[this.serverIndex]);
        }
    }

    /// <summary>
    /// Netevia API: # Netevia Gateway API for Transaction Processing&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// Netevia Payment Gateway provides a simple method of processing payment transactions for merchants who want to integrate payment processing with their existing applications. The Netevia Payment Gateway processes credit card, debit card and Electronic Benefits Transfer (EBT) transactions. Transactions are accepted from various industries including: retail, restaurant, mail order/telephone order, lodging, and E-comm.&lt;br&gt;<br/>
    /// This document describes how to write your own application for processing payment transactions or integrate payment processing capabilities into an existing application.&lt;br&gt;&lt;br&gt;<br/>
    ///   Copyright 2023 by Netevia, INC DBA Netevia Payment Services. Licensed under the Apache License, Version 2.0 (the License). You may not use this file except in compliance with the License. You may obtain a copy of the License at <a href="http://www.apache.org/licenses/LICENSE-2.0.html">http://www.apache.org/licenses/LICENSE-2.0.html</a>. Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an AS IS BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.&lt;br&gt;&lt;br&gt;<br/>
    /// <a href="https://netevia.com/">Netevia Payment Gateway Web Site</a>.&lt;br&gt;<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class Gateway: IGateway
    {
        public SDKConfig Config { get; private set; }


        private const string _language = "csharp";
        private const string _sdkVersion = "0.7.2";
        private const string _sdkGenVersion = "2.192.1";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.7.2 2.192.1 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public ITransactionV2 TransactionV2 { get; private set; }
        public IACHCreditTransactionV2 ACHCreditTransactionV2 { get; private set; }
        public IACHDebitTransactionV2 ACHDebitTransactionV2 { get; private set; }
        public ITransactionAuthV2 TransactionAuthV2 { get; private set; }
        public IBatchTransaction BatchTransaction { get; private set; }
        public IBatchQueryV2 BatchQueryV2 { get; private set; }
        public ITransactionInfoV2 TransactionInfoV2 { get; private set; }
        public IGiftTransactionV2 GiftTransactionV2 { get; private set; }
        public ICloudPDCIngenicoTransactionV2 CloudPDCIngenicoTransactionV2 { get; private set; }
        public ICloudPDCRefundv2 CloudPDCRefundv2 { get; private set; }
        public ICloudPDCSaleTransactionV2 CloudPDCSaleTransactionV2 { get; private set; }
        public IModifyTransactionV2 ModifyTransactionV2 { get; private set; }
        public IRefundTransctionV2 RefundTransctionV2 { get; private set; }
        public ISaleTransactionV2 SaleTransactionV2 { get; private set; }
        public ITokenTransactionV2 TokenTransactionV2 { get; private set; }
        public IVerifyTransactionV2 VerifyTransactionV2 { get; private set; }
        public IVoidTransactionV2 VoidTransactionV2 { get; private set; }
        public IDesktopPDCTransactionV2 DesktopPDCTransactionV2 { get; private set; }
        public IPaymentDeviceController PaymentDeviceController { get; private set; }
        public ICloudPDCRefund CloudPDCRefund { get; private set; }
        public ICloudPDCSaleTransaction CloudPDCSaleTransaction { get; private set; }
        public ITransaction Transaction { get; private set; }
        public IQRPayTransaction QRPayTransaction { get; private set; }
        public IACHCreditTransaction ACHCreditTransaction { get; private set; }
        public IACHDebitTransaction ACHDebitTransaction { get; private set; }
        public IAuth Auth { get; private set; }
        public ITransInfo TransInfo { get; private set; }
        public IGiftTransaction GiftTransaction { get; private set; }
        public IRefund Refund { get; private set; }
        public ISaleTransaction SaleTransaction { get; private set; }
        public ITokenTransaction TokenTransaction { get; private set; }
        public IVerify Verify { get; private set; }
        public IGPayTransaction GPayTransaction { get; private set; }
        public IDesktopPDCTransaction DesktopPDCTransaction { get; private set; }

        public Gateway(int? serverIndex = null, ServerEnvironment? environment = null, ServerPort? port = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }
            List<Dictionary<string, string>> serverDefaults = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"environment", environment == null ? "gatewayapidocs" : ServerEnvironmentExtension.Value(environment.Value)},
                    {"port", port == null ? "11911" : ServerPortExtension.Value(port.Value)},
                },
                new Dictionary<string, string>()
                {
                    {"environment", environment == null ? "gatewayapidocs" : ServerEnvironmentExtension.Value(environment.Value)},
                    {"port", port == null ? "11911" : ServerPortExtension.Value(port.Value)},
                },
                new Dictionary<string, string>()
                {
                },
            };

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            Config = new SDKConfig()
            {
                ServerDefaults = serverDefaults,
                serverUrl = _serverUrl
            };

            TransactionV2 = new TransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            ACHCreditTransactionV2 = new ACHCreditTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            ACHDebitTransactionV2 = new ACHDebitTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            TransactionAuthV2 = new TransactionAuthV2(_defaultClient, _securityClient, _serverUrl, Config);
            BatchTransaction = new BatchTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            BatchQueryV2 = new BatchQueryV2(_defaultClient, _securityClient, _serverUrl, Config);
            TransactionInfoV2 = new TransactionInfoV2(_defaultClient, _securityClient, _serverUrl, Config);
            GiftTransactionV2 = new GiftTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCIngenicoTransactionV2 = new CloudPDCIngenicoTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCRefundv2 = new CloudPDCRefundv2(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCSaleTransactionV2 = new CloudPDCSaleTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            ModifyTransactionV2 = new ModifyTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            RefundTransctionV2 = new RefundTransctionV2(_defaultClient, _securityClient, _serverUrl, Config);
            SaleTransactionV2 = new SaleTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            TokenTransactionV2 = new TokenTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            VerifyTransactionV2 = new VerifyTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            VoidTransactionV2 = new VoidTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            DesktopPDCTransactionV2 = new DesktopPDCTransactionV2(_defaultClient, _securityClient, _serverUrl, Config);
            PaymentDeviceController = new PaymentDeviceController(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCRefund = new CloudPDCRefund(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCSaleTransaction = new CloudPDCSaleTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            Transaction = new Transaction(_defaultClient, _securityClient, _serverUrl, Config);
            QRPayTransaction = new QRPayTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            ACHCreditTransaction = new ACHCreditTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            ACHDebitTransaction = new ACHDebitTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            Auth = new Auth(_defaultClient, _securityClient, _serverUrl, Config);
            TransInfo = new TransInfo(_defaultClient, _securityClient, _serverUrl, Config);
            GiftTransaction = new GiftTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            Refund = new Refund(_defaultClient, _securityClient, _serverUrl, Config);
            SaleTransaction = new SaleTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            TokenTransaction = new TokenTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            Verify = new Verify(_defaultClient, _securityClient, _serverUrl, Config);
            GPayTransaction = new GPayTransaction(_defaultClient, _securityClient, _serverUrl, Config);
            DesktopPDCTransaction = new DesktopPDCTransaction(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}