
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Gateway
{
    using Gateway.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

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
    public interface IGatewaySDK
    {
        public IApiSDK Api { get; }
        public IAPIACHCreditSDK APIACHCredit { get; }
        public IAPIACHDebitSDK APIACHDebit { get; }
        public IAPIAuthSDK APIAuth { get; }
        public IAPIBatchSDK APIBatch { get; }
        public IAPIGetTransInfoSDK APIGetTransInfo { get; }
        public IAPIGiftSDK APIGift { get; }
        public IAPIModifySDK APIModify { get; }
        public IAPIRefundSDK APIRefund { get; }
        public IAPISaleSDK APISale { get; }
        public IAPITokenSDK APIToken { get; }
        public IAPIVerifySDK APIVerify { get; }
        public IAPIVoidSDK APIVoid { get; }
        public IAPIv2SDK APIv2 { get; }
        public IAPIv2ACHCreditSDK APIv2ACHCredit { get; }
        public IAPIv2ACHDebitSDK APIv2ACHDebit { get; }
        public IAPIv2AuthSDK APIv2Auth { get; }
        public IAPIv2BatchSDK APIv2Batch { get; }
        public IAPIv2GetTransInfoSDK APIv2GetTransInfo { get; }
        public IAPIv2GiftSDK APIv2Gift { get; }
        public IAPIv2ModifySDK APIv2Modify { get; }
        public IAPIv2RefundSDK APIv2Refund { get; }
        public IAPIv2SaleSDK APIv2Sale { get; }
        public IAPIv2TokenSDK APIv2Token { get; }
        public IAPIv2VerifySDK APIv2Verify { get; }
        public IAPIv2VoidSDK APIv2Void { get; }
        public ICloudPDCSDK CloudPDC { get; }
        public ICloudPDCRefundSDK CloudPDCRefund { get; }
        public ICloudPDCSaleSDK CloudPDCSale { get; }
        public ICloudPDCv2IngenicoSDK CloudPDCv2Ingenico { get; }
        public ICloudPDCv2RefundSDK CloudPDCv2Refund { get; }
        public ICloudPDCv2SaleSDK CloudPDCv2Sale { get; }
        public IDesktopPDCSDK DesktopPDC { get; }
        public IDesktopPDCv2SDK DesktopPDCv2 { get; }
        public IGPaySDK GPay { get; }
        public IQRPaySDK QRPay { get; }
    }
    
    public class SDKConfig
    {
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
    public class GatewaySDK: IGatewaySDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://{environment}.netevia.com:{port}",
            "https://{environment}.netevia.com:{port}",
            "https://virtserver.swaggerhub.com/Netevia_INC/Netevia/0.1.0",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.0";
        private const string _sdkGenVersion = "2.146.1";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.3.0 2.146.1 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IApiSDK Api { get; private set; }
        public IAPIACHCreditSDK APIACHCredit { get; private set; }
        public IAPIACHDebitSDK APIACHDebit { get; private set; }
        public IAPIAuthSDK APIAuth { get; private set; }
        public IAPIBatchSDK APIBatch { get; private set; }
        public IAPIGetTransInfoSDK APIGetTransInfo { get; private set; }
        public IAPIGiftSDK APIGift { get; private set; }
        public IAPIModifySDK APIModify { get; private set; }
        public IAPIRefundSDK APIRefund { get; private set; }
        public IAPISaleSDK APISale { get; private set; }
        public IAPITokenSDK APIToken { get; private set; }
        public IAPIVerifySDK APIVerify { get; private set; }
        public IAPIVoidSDK APIVoid { get; private set; }
        public IAPIv2SDK APIv2 { get; private set; }
        public IAPIv2ACHCreditSDK APIv2ACHCredit { get; private set; }
        public IAPIv2ACHDebitSDK APIv2ACHDebit { get; private set; }
        public IAPIv2AuthSDK APIv2Auth { get; private set; }
        public IAPIv2BatchSDK APIv2Batch { get; private set; }
        public IAPIv2GetTransInfoSDK APIv2GetTransInfo { get; private set; }
        public IAPIv2GiftSDK APIv2Gift { get; private set; }
        public IAPIv2ModifySDK APIv2Modify { get; private set; }
        public IAPIv2RefundSDK APIv2Refund { get; private set; }
        public IAPIv2SaleSDK APIv2Sale { get; private set; }
        public IAPIv2TokenSDK APIv2Token { get; private set; }
        public IAPIv2VerifySDK APIv2Verify { get; private set; }
        public IAPIv2VoidSDK APIv2Void { get; private set; }
        public ICloudPDCSDK CloudPDC { get; private set; }
        public ICloudPDCRefundSDK CloudPDCRefund { get; private set; }
        public ICloudPDCSaleSDK CloudPDCSale { get; private set; }
        public ICloudPDCv2IngenicoSDK CloudPDCv2Ingenico { get; private set; }
        public ICloudPDCv2RefundSDK CloudPDCv2Refund { get; private set; }
        public ICloudPDCv2SaleSDK CloudPDCv2Sale { get; private set; }
        public IDesktopPDCSDK DesktopPDC { get; private set; }
        public IDesktopPDCv2SDK DesktopPDCv2 { get; private set; }
        public IGPaySDK GPay { get; private set; }
        public IQRPaySDK QRPay { get; private set; }

        public GatewaySDK(string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? GatewaySDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            Config = new SDKConfig()
            {
            };

            Api = new ApiSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIACHCredit = new APIACHCreditSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIACHDebit = new APIACHDebitSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIAuth = new APIAuthSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIBatch = new APIBatchSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIGetTransInfo = new APIGetTransInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIGift = new APIGiftSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIModify = new APIModifySDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIRefund = new APIRefundSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APISale = new APISaleSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIToken = new APITokenSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIVerify = new APIVerifySDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIVoid = new APIVoidSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2 = new APIv2SDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2ACHCredit = new APIv2ACHCreditSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2ACHDebit = new APIv2ACHDebitSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Auth = new APIv2AuthSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Batch = new APIv2BatchSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2GetTransInfo = new APIv2GetTransInfoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Gift = new APIv2GiftSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Modify = new APIv2ModifySDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Refund = new APIv2RefundSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Sale = new APIv2SaleSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Token = new APIv2TokenSDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Verify = new APIv2VerifySDK(_defaultClient, _securityClient, _serverUrl, Config);
            APIv2Void = new APIv2VoidSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDC = new CloudPDCSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCRefund = new CloudPDCRefundSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCSale = new CloudPDCSaleSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCv2Ingenico = new CloudPDCv2IngenicoSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCv2Refund = new CloudPDCv2RefundSDK(_defaultClient, _securityClient, _serverUrl, Config);
            CloudPDCv2Sale = new CloudPDCv2SaleSDK(_defaultClient, _securityClient, _serverUrl, Config);
            DesktopPDC = new DesktopPDCSDK(_defaultClient, _securityClient, _serverUrl, Config);
            DesktopPDCv2 = new DesktopPDCv2SDK(_defaultClient, _securityClient, _serverUrl, Config);
            GPay = new GPaySDK(_defaultClient, _securityClient, _serverUrl, Config);
            QRPay = new QRPaySDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}