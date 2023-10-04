
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
    using Gateway.Models.Operations;
    using Gateway.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IAPIACHCreditSDK
    {

        /// <summary>
        /// ACH Credit transactions.
        /// 
        /// <remarks>
        /// Initiate an &lt;b&gt;ACH&lt;/b&gt; credit transaction request to Netevia Gateway.&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// An &lt;b&gt;ACH&lt;/b&gt; credit transaction is used to allow merchants to pay using ACH and transfer money to other bank accounts.&lt;br&gt;<br/>
        /// To be more generic and have a similar approach as for Debit ACH, we can also simulate the single PayOut call for a batch of payments with multiple individual credit transactions calls that will be approved offline by us and when batching happens we can generate the PayOut request to GMS as a single API call(batch file upload) as they require. Now GMS processor support.<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;Use the examples for different &apos;ACH Credit&apos; request flavours.<br/>
        /// &lt;div&gt;<br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RestAPIACHCreditResponse> RestAPIACHCreditAsync(object request);
    }

    public class APIACHCreditSDK: IAPIACHCreditSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.4.0";
        private const string _sdkGenVersion = "2.146.1";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.4.0 2.146.1 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public APIACHCreditSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<RestAPIACHCreditResponse> RestAPIACHCreditAsync(object request)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/restApi#ACHCredit";
            

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
            
            var response = new RestAPIACHCreditResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            response.ResponseGeneric = JsonConvert.DeserializeObject<object>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        
    }
}