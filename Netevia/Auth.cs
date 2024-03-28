
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

    public interface IAuth
    {

        /// <summary>
        /// How to initiate different Auth/Finalize transaction requests.
        /// 
        /// <remarks>
        /// Initiate an &lt;b&gt;Auth/Finalize&lt;/b&gt; transaction request to Netevia Gateway.&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// An &lt;b&gt;Auth&lt;/b&gt; transaction places a temporary hold on the customer’s account. Approvals on authorizations are used later to transfer funds by Finalize or AddTip.&lt;br&gt;<br/>
        /// A &lt;b&gt;Finalize&lt;/b&gt; transaction is used to change an &lt;b&gt;Auth&lt;/b&gt; transaction to a &lt;b&gt;Sale&lt;/b&gt; transaction.<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;Use the examples for different &apos;Auth/Finalize&apos; flavours <br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RestAPIAuthResponse> FinalizeAsync(RequestGeneric request);
    }

    public class Auth: IAuth
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.0";
        private const string _sdkGenVersion = "2.292.0";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.12.0 2.292.0 0.1.0 Netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public Auth(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<RestAPIAuthResponse> FinalizeAsync(RequestGeneric request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/restApi#Auth_Finalize";

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

            var response = new RestAPIAuthResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
                    response.ResponseGeneric = JsonConvert.DeserializeObject<ResponseGeneric>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
            return response;
        }

    }
}