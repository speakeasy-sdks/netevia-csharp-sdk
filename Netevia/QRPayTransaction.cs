
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
    using Netevia.Models.Operations;
    using Netevia.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IQRPayTransaction
    {

        /// <summary>
        /// Integrated QRPay API interface
        /// 
        /// <remarks>
        /// QRPay flow char &lt;br&gt;<br/>
        /// &lt;img src=&quot;https://testlink.c9pg.com/images/QRPayImages/Image_QRPay.png&quot;&gt; <br/>
        /// Notes: FrontEndSystem is a system for initiating transaction orders, because there is no card number, need to scan the QR code to complete the entire transaction.<br/>
        /// &lt;br/&gt;<br/>
        /// &lt;br/&gt;<br/>
        /// The supported transaction types.&lt;br&gt;<br/>
        /// &lt;ul&gt;<br/>
        /// &lt;li&gt;CreateQRCode: Frontend system ask QRPay server create pre-order with transaction info. For this api have the option fields(QRCodeFormat,QRCodeType,NotificationCallback, ExpirtionTime). if the default is not good for you then you need set the value in the request.<br/>
        /// <br/>
        /// &lt;/li&gt;<br/>
        /// &lt;li&gt;GetQRPayInfo: Inquriy order info from QRPay server.&lt;/li&gt;<br/>
        /// &lt;li&gt;QRPaySale: WalletApp got user card number then do payments. &lt;/li&gt;<br/>
        /// &lt;li&gt;GetQRPayResult : The Api is use to inquiry the pay results, it have a option field NotificationCallback, if frontend system using async call then please set the value, default is empty.&lt;/li&gt;<br/>
        /// &lt;li&gt;NotifyQRPayResult: QRPay server ntofiy pay results to the connect terminal. import, please set the NotificationCallback field in the CreateQRCode request &lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// &lt;hr&gt;<br/>
        /// New fields<br/>
        /// &lt;ul&gt;<br/>
        /// &lt;li&gt;QRCodeFormat: Specify the QR code format text and image(svg), text is the default, if you request image, please set the value to svg now, future will support more image type.&lt;/li&gt;<br/>
        /// &lt;li&gt;QRCodeType: Specify the QR code type static and dynamic, dynamic QR code will only used one time, static QR code can used multiple times, dynamic is the default. In order to avoid repetitive creation of static QR codes, we will check the repetition according to the fields of GMID, GTID, MainAmt, TipAmt, InvoiceNumber. If there are duplicate creations, we will return the last valid static QR code.&lt;/li&gt;<br/>
        /// &lt;/li&gt;<br/>
        /// &lt;li&gt;QRCodeContext: the QR Code context will returned by QRServer. it is a url, the url like this pattern(https://gatewayapidocs.netevia.com/qrpay?GTRC=UUID). if the QRCodeFormat is text then the context is the true url, if the QRCodeFormat is image then the context is the URL of QRCode image with the format that you specified.<br/>
        /// &lt;/li&gt;<br/>
        /// &lt;li&gt;<br/>
        /// ExpirtionTime: This field specifies the validity period of the QRCode in minutes. If there is no expiration time, please set it to N, The default is 15 minutes.<br/>
        /// &lt;/li&gt;<br/>
        /// &lt;li&gt;<br/>
        /// NotificationCallback: Optional field. If you need to obtain the payment result asynchronously, please set this parameter.<br/>
        /// &lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;Use the examples for different &apos;TransType&apos; request flavours.<br/>
        /// &lt;div&gt;<br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<IntegrateQRPayResponse> CreateAsync(object request);
    }

    public class QRPayTransaction: IQRPayTransaction
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.9.1";
        private const string _sdkGenVersion = "2.258.0";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.9.1 2.258.0 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public QRPayTransaction(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<IntegrateQRPayResponse> CreateAsync(object request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/qrpay";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json");
            if (serializedBody == null)
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new IntegrateQRPayResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonResponseGeneric = JsonConvert.DeserializeObject<object>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            response.DefaultApplicationJsonResponseGeneric = JsonConvert.DeserializeObject<object>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }

        
    }
}