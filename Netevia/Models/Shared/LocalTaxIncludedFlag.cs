
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Netevia.Models.Shared
{
    
    /// <summary>
    /// Provides details about the tax amount.&lt;br&gt;<br/>
    /// 
    /// <remarks>
    /// Valid values:&lt;br&gt;<br/>
    /// &lt;ul&gt;<br/>
    ///   &lt;li&gt;0: Sales Tax not Provided&lt;/li&gt;<br/>
    ///   &lt;li&gt;1: Local or Sales Tax Amount&lt;/li&gt;<br/>
    ///   &lt;li&gt;2: Tax Exempt&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum LocalTaxIncludedFlag
    {
        Zero = 0,
        One = 1,
        Two = 2,
    }

}