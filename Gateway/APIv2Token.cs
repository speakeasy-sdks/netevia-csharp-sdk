
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

    public interface IAPIv2TokenSDK
    {

        /// <summary>
        /// How to initiate Token based transaction requests.
        /// 
        /// <remarks>
        /// Initiate &lt;b&gt;Token&lt;/b&gt; based transaction requests to Netevia Gateway.&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// <br/>
        /// *&lt;span style=&quot;color:green&quot;&gt;Valid actions:&lt;/span&gt;*<br/>
        /// ---<br/>
        /// ___<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;CreateCardToken&lt;/span&gt;: is used to create card token.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;DeleteCardToken&lt;sup&gt;2&lt;/sup&gt;&lt;/span&gt;: is used to delete exist card token.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;GetCardTokenInfo&lt;/span&gt;: is used to retrieve card data(masked) linked to a token.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;UpdateCardTokenInfo&lt;/span&gt;: is used to update card token information. It supports update ExpDate, CustomerAddress, CustomerZipCode.<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;Use the examples for different &apos;Token&apos; flavours&lt;br&gt;<br/>
        /// &lt;sup&gt;2&lt;/sup&gt;Pay attention that calling this API will delete the provided &apos;CardToken&apos;<br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RestAPIv2TokenResponse> RestAsync(RestAPIv2TokenRequest request);
    }

    public class APIv2TokenSDK: IAPIv2TokenSDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.5.0";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.5.0 internal 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public APIv2TokenSDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<RestAPIv2TokenResponse> RestAsync(RestAPIv2TokenRequest request)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/Payment/{TransType}#Tokenization", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
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
            
            var response = new RestAPIv2TokenResponse
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