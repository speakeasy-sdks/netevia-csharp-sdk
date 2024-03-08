
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

    public interface ICloudPDCIngenicoTransactionV2
    {

        /// <summary>
        /// Cloud Payment Device Controller - card reader device management API.
        /// 
        /// <remarks>
        /// Payment Device Controller API, dedicated<br/>
        /// *&lt;span style=&quot;color:green&quot;&gt;Valid actions:&lt;/span&gt;*<br/>
        /// ---<br/>
        /// ___<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;Register&lt;/span&gt;: is used to associate Pin pad’s serial number with GMID/GTID. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;Unregister&lt;/span&gt;: is used to unlink Pin pad’s serial number from GMID/GTID and de-activate GMID/GTID. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;GetStatus&lt;/span&gt;: is used to judge whether Pin pad is available. We can use the API to get the device bound info as well. This transaction only supported in the EMV, QuickChip endpoint<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;AskNumberQuestion&lt;/span&gt;: is used to get user input on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;AskSelectionQuestion&lt;/span&gt;: is used to get user selection results on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;ShowMessage&lt;/span&gt;: is used to display message on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;UploadImage&lt;/span&gt;: is used to upload image to the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;SetImageList&lt;/span&gt;: is used to set up the index of images that need to be displayed on the Pin pad. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;UploadMessage&lt;/span&gt;: is used to permanently replace built-in message in Pin pad. Even if restart the Pin pad. A reboot is required following UploadMessage. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;ResetMessage&lt;/span&gt;: is used to restore built-in message in Pin pad. A reboot is required following ResetMessage. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;RebootDevice&lt;/span&gt;: is used to restart Pin pad. This transaction only supported in the EMV, QuickChip endpoint.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;UploadFile&lt;/span&gt;: is used to upload the configuration files to the pin pad, preparing for entering tip value by pinpad. After uploading successfully, you’d better restart the pinpad. The configuration file named “CUSTPROMPT.PGZ” exists on our server. You can send the request message with your GMID,GTID and upload it.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;PrintReceipt&lt;/span&gt;: is used for re-printing receipts. The request must contain the GTRC of the original transaction.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;ESignature&lt;/span&gt;: is used for capturing client&apos;s electronic signature on request without performing a transaction.<br/>
        /// - &lt;span style=&quot;color:red&quot;&gt;CardRead&lt;/span&gt;: is used for reading Gift cards details.<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<ControlCloudPDCv2IngenicoResponse> CreateAsync(ControlCloudPDCv2IngenicoRequest request);
    }

    public class CloudPDCIngenicoTransactionV2: ICloudPDCIngenicoTransactionV2
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.10.1";
        private const string _sdkGenVersion = "2.279.1";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.10.1 2.279.1 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;

        public CloudPDCIngenicoTransactionV2(ISpeakeasyHttpClient defaultClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<ControlCloudPDCv2IngenicoResponse> CreateAsync(ControlCloudPDCv2IngenicoRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/Payment/{TransType}#Ingenico", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ControlCloudPDCv2IngenicoResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ResponseGenericPDC = JsonConvert.DeserializeObject<object>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

    }
}