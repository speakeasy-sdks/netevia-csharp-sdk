
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

    public interface ICloudPDCRefundv2
    {

        /// <summary>
        /// Initiate a Refund request.
        /// 
        /// <remarks>
        /// Initiate a Refund request to Netevia Payment Device Controller.   <br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<InitiateCloudPDCv2RefundResponse> CreateAsync(InitiateCloudPDCv2RefundRequest request);
    }

    public class CloudPDCRefundv2: ICloudPDCRefundv2
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.12.0";
        private const string _sdkGenVersion = "2.292.0";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.12.0 2.292.0 0.1.0 Netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public CloudPDCRefundv2(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<InitiateCloudPDCv2RefundResponse> CreateAsync(InitiateCloudPDCv2RefundRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/Payment/{TransType}#Ingenico_Refund", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestGenericPDC", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new InitiateCloudPDCv2RefundResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ResponseGenericPDC = JsonConvert.DeserializeObject<ResponseGenericPDC>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
                }

                return response;
            }
                    response.ResponseGeneric = JsonConvert.DeserializeObject<ResponseGeneric>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumConverter(), new AnyDeserializer() }});
            return response;
        }

    }
}