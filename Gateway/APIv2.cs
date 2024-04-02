
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

    public interface IAPIv2SDK
    {

        /// <summary>
        /// Generic batch query API.
        /// 
        /// <remarks>
        /// Initiate a batch query request to Netevia Gateway.&lt;br&gt;<br/>
        /// This is the full set of parameters that can be used. All the data is sent in the body of the request.&lt;br&gt;<br/>
        /// Depending on the transaction type only a subset of these fields are mandatory!&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// ***&lt;span style=&quot;color:green&quot;&gt;Valid actions:&lt;/span&gt;***  <br/>
        /// ---  <br/>
        /// ___<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;BatchLookup&lt;/span&gt; : is used to get the batch ID by batch date.  If the BatchDate is omitted, the open/current batch is returned. Then the batch ID can be used in BatchQuery API to get more info for that batch.  <br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;BatchQuery&lt;/span&gt; : is used to query transaction list by batch ID.  <br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;please refer to &apos;samples&apos; section for sample subsets <br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<BatchAPIv2Response> BatchAsync(BatchAPIv2Request request);

        /// <summary>
        /// Generic API.
        /// 
        /// <remarks>
        /// Initiate a transaction request to Netevia Gateway.&lt;br&gt;<br/>
        /// This is the full set of parameters that can be used. All the data is sent in the body of the request.&lt;br&gt;<br/>
        /// Depending on the transaction type only a subset of these fields are mandatory!&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;please refer to &apos;Examples&apos; section for sample subsets  <br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RestAPIv2Response> RestAsync(RestAPIv2Request request);
    }

    public class APIv2SDK: IAPIv2SDK
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

        public APIv2SDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<BatchAPIv2Response> BatchAsync(BatchAPIv2Request request)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/Payment/{TransType}#BatchLookup_BatchQuery", request);
            

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
            
            var response = new BatchAPIv2Response
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ResponseGeneric = JsonConvert.DeserializeObject<object>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        

        public async Task<RestAPIv2Response> RestAsync(RestAPIv2Request request)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/Payment/{TransType}", request);
            

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
            
            var response = new RestAPIv2Response
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            throw new InvalidOperationException("API returned unexpected status code or content type");
        }
        
    }
}