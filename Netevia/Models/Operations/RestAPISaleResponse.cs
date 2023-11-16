
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Netevia.Models.Operations
{
    using System.Net.Http;
    using System;
    
    public class RestAPISaleResponse
    {

        /// <summary>
        /// Succesfull transaction.<br/>
        /// 
        /// <remarks>
        /// &lt;br&gt;&lt;span style=&quot;color:red&quot;&gt;*NOTE: this is an abbreviated version of the response. To see all the typical fields, check Response Schema or use &quot;Try it out&quot; functionality!&lt;/span&gt;<br/>
        /// 
        /// </remarks>
        /// </summary>
        public object? TwoHundredApplicationJsonResponseGeneric { get; set; }

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage RawResponse { get; set; } = default!;

        /// <summary>
        /// Succesfull transaction
        /// </summary>
        public object? DefaultApplicationJsonResponseGeneric { get; set; }
    }
}