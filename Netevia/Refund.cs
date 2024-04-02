
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
    using Netevia.Models.Errors;
    using Netevia.Models.Operations;
    using Netevia.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IRefund
    {

        /// <summary>
        /// How to initiate Refund transaction requests.
        /// 
        /// <remarks>
        /// Initiate a &lt;b&gt;Refund&lt;/b&gt; transaction request to Netevia Gateway.&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// A &lt;b&gt;Refund&lt;/b&gt; transaction is used to authorize a refund to a customer&apos;s credit card account.<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;Use the examples for different &apos;Refund&apos; flavours<br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RestAPIRefundResponse> CreateAsync(RequestGeneric request);
    }

    public class Refund: IRefund
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.13.0";
        private const string _sdkGenVersion = "2.295.1";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.13.0 2.295.1 0.1.0 Netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public Refund(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<RestAPIRefundResponse> CreateAsync(RequestGeneric request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/restApi#Refund";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new RestAPIRefundResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<ResponseGeneric>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.ResponseGeneric = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            return response;
        }

    }
}