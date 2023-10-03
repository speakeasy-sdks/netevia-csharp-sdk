
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasybar.Models.Operations
{
    using Speakeasybar.Models.Shared;
    using Speakeasybar.Utils;
    
    public class RestAPIv2VerifyInquiryRequest
    {

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=GMID")]
        public string Gmid { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=NeedSwipeCard")]
        public NeedSwipeCard? NeedSwipeCard { get; set; }

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public object RequestBody { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=TerminalType")]
        public TerminalType? TerminalType { get; set; }

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=TransType")]
        public TransType TransType { get; set; } = default!;
    }
}