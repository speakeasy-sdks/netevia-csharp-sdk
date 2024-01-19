
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

    public interface IGiftTransaction
    {

        /// <summary>
        /// Gitf transactions.
        /// 
        /// <remarks>
        /// Initiate a &lt;b&gt;Gift&lt;/b&gt; credit transaction request to Netevia Gateway.&lt;sup&gt;1&lt;/sup&gt;&lt;br&gt;<br/>
        /// A &lt;b&gt;Gift&lt;/b&gt; transaction is used to allow Account to pay using Gift and transfer money or points to merchnat.&lt;br&gt;<br/>
        /// Available processors: &lt;b&gt;Givex&lt;/b&gt;.&lt;br&gt;<br/>
        /// The supported transaction types.&lt;br&gt;<br/>
        /// &lt;ul&gt;<br/>
        /// &lt;li&gt;Activation: this service enables a merchant to activate a Givex certificate for a certain value once it has been sold. &lt;/li&gt;<br/>
        /// &lt;li&gt;Inquiry: perform a card balance lookup, BalanceAmt and PointsBalance will be returned in a successful response.&lt;/li&gt;<br/>
        /// &lt;li&gt;Auth: reserve some or all of a card&apos;s balance for settle at a later time. please use Finalize to settle. After 7 days will be auto closed. &lt;/li&gt;<br/>
        /// &lt;li&gt;Sale: decrement all or part of the value of an existing certificate.&lt;/li&gt;<br/>
        /// &lt;li&gt;AddValue: add value to an existing certificate.&lt;/li&gt;<br/>
        /// &lt;li&gt;AdjustUp: add value to an existing certificate, the action cannot be voided. &lt;/li&gt;<br/>
        /// &lt;li&gt;AdjustDown: decrement value to an existing certificate, the action cannot be voided.&lt;/li&gt;<br/>
        /// &lt;li&gt;Finalize: complete a pre-auth and redeem the reserved funds.&lt;/li&gt;<br/>
        /// &lt;li&gt;Void: to void the original action.&lt;/li&gt;<br/>
        /// &lt;li&gt;Refund:  add value in a consumer comp or merchandise credit scenario at the front line. &lt;/li&gt;<br/>
        /// &lt;li&gt;PointsIssue: use for issuing points as part of a loyalty program.&lt;/li&gt;<br/>
        /// &lt;li&gt;PointsRedemption: use for redeeming points as part of a loyalty program.&lt;/li&gt;<br/>
        /// &lt;li&gt;PointsReduction: use for reducing points as part of a loyalty program. the points transaciton reference pre-defined formulas setup on the processor host through the promo code specified. The formula will caculate the amount of points to reduce based on the amount and promo code provided.&lt;/li&gt;<br/>
        /// &lt;li&gt;PointsVoid: void point action.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// &lt;hr&gt;<br/>
        /// New fields<br/>
        /// &lt;ul&gt;<br/>
        /// &lt;li&gt;SecurityCode: The securityCode is to validate the PIN value for the existing card&lt;/li&gt;<br/>
        /// &lt;li&gt;PromoCode: used for points issuance service, it needs to be set in the Givex system before using it.&lt;/li&gt;<br/>
        /// &lt;li&gt;Units: used for points issuance service&lt;/li&gt;<br/>
        /// &lt;li&gt;SKUItems: used for SKU base Scenes, Netevia format is SKU#:Amount:QTY example:&quot;SKUItems&quot;:&quot;5:500:2,2:275:1&quot;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// &lt;hr&gt;<br/>
        /// &lt;sup&gt;1&lt;/sup&gt;Use the examples for different &apos;Gift&apos; request flavours.<br/>
        /// &lt;div&gt;<br/>
        /// &lt;br&gt;&lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: If you don&apos;t see Request Schema, you are in &quot;Try it out&quot; mode and you need to press &quot;Cancel&quot;!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<RestAPIGiftResponse> CreateAsync(object request);
    }

    public class GiftTransaction: IGiftTransaction
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.7.5";
        private const string _sdkGenVersion = "2.237.2";
        private const string _openapiDocVersion = "0.1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.7.5 2.237.2 0.1.0 netevia";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public GiftTransaction(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<RestAPIGiftResponse> CreateAsync(object request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/restApi#Gift";
            
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
            
            var response = new RestAPIGiftResponse
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