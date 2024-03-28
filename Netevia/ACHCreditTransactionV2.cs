
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

    public interface IACHCreditTransactionV2
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
        Task<RestAPIv2ACHCreditResponse> CreateAsync(RestAPIv2ACHCreditRequest request);
    }

    public class ACHCreditTransactionV2: IACHCreditTransactionV2
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.0";
        private const string _sdkGenVersion = "2.292.0";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.12.0 2.292.0 0.1.0 Netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public ACHCreditTransactionV2(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<RestAPIv2ACHCreditResponse> CreateAsync(RestAPIv2ACHCreditRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/Payment/{TransType}#ACHCredit", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestGeneric", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new RestAPIv2ACHCreditResponse
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