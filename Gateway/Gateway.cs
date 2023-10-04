
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
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IGatewaySDK
    {

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
        Task<RestAPIResponse> TransactionAsync(object request);
    }

    public class GatewaySDK: IGatewaySDK
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.5.0";
        private const string _sdkGenVersion = "2.146.1";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.5.0 2.146.1 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public GatewaySDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<RestAPIResponse> TransactionAsync(object request)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/restApi";
            

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
            
            var response = new RestAPIResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            throw new NotImplementedException();
            return response;
        }
        
    }
}