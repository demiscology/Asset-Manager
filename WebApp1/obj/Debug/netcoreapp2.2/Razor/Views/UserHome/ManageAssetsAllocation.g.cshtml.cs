#pragma checksum "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e343b8eea47194957af1b133efb773ac9c21828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserHome_ManageAssetsAllocation), @"mvc.1.0.view", @"/Views/UserHome/ManageAssetsAllocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserHome/ManageAssetsAllocation.cshtml", typeof(AspNetCore.Views_UserHome_ManageAssetsAllocation))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#line 2 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\_ViewImports.cshtml"
using WebApp1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e343b8eea47194957af1b133efb773ac9c21828", @"/Views/UserHome/ManageAssetsAllocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6545200b2b1f984d3aecce45fd26db78e2f32d9d", @"/Views/_ViewImports.cshtml")]
    public class Views_UserHome_ManageAssetsAllocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp1.Models.ManageAssetsAllocation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
  
    ViewData["Title"] = "ManageAssetsAllocation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(168, 1231, true);
            WriteLiteral(@"
<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h1><a class=""fa fa-users"">--</a><a class=""fa fa-building"">--</a><a class=""fa fa-wrench"" style=""margin-right:2px""></a>Manage Asset Allocations </h1>
            </div>

        </div>
        <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""x_panel"">
                <div class=""x_title"">
                    <h2>Update or Delete Asset Allocations</h2>

                    <div class=""clearfix""></div>
                </div>
                <div class=""x_content"">
                    <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th>Asset Owner</th>
                                <th>Asset Brief Description</th>
                      ");
            WriteLiteral("          <th>Asser Address</th>\r\n                                <th>Tenant Name</th>\r\n                                <th>Tenant Address</th>\r\n                                <th>Tenant Phone Number</th>\r\n");
            EndContext();
            BeginContext(1452, 151, true);
            WriteLiteral("                                <th>Delete</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                             foreach (var asset in Model)
                            {

#line default
#line hidden
            BeginContext(1693, 35, true);
            WriteLiteral("                                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1728, "\"", 1742, 1);
#line 40 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
WriteAttributeValue("", 1733, asset.Id, 1733, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1743, 43, true);
            WriteLiteral(">\r\n                                    <td>");
            EndContext();
            BeginContext(1787, 15, false);
#line 41 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                   Write(asset.AssetName);

#line default
#line hidden
            EndContext();
            BeginContext(1802, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1850, 16, false);
#line 42 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                   Write(asset.AssetBreif);

#line default
#line hidden
            EndContext();
            BeginContext(1866, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1914, 18, false);
#line 43 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                   Write(asset.AssetAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1932, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1980, 16, false);
#line 44 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                   Write(asset.TenantName);

#line default
#line hidden
            EndContext();
            BeginContext(1996, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2044, 19, false);
#line 45 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                   Write(asset.TenantAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2063, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2111, 18, false);
#line 46 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                   Write(asset.TenantNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2129, 130, true);
            WriteLiteral("</td>\r\n                                    <td><button class=\"btn btn-block btn-danger\" onclick=\"getVal(this.value)\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2259, "\"", 2276, 1);
#line 47 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
WriteAttributeValue("", 2267, asset.Id, 2267, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2277, 64, true);
            WriteLiteral(">Unallocate</button></td>\r\n                                </tr>");
            EndContext();
#line 48 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\ManageAssetsAllocation.cshtml"
                                     }

#line default
#line hidden
            BeginContext(2344, 112, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2491, 420, true);
            WriteLiteral(@"<script type=""text/javascript"">
    function getVal(value) {
        

        $.ajax({
            type: ""POST"",
            url: ""/UserHome/ManageAssetsAllocation"",
            datatype: 'json',
            data: {'data':value},
            success: function (response) {
                alert(""Successfully Unallocated"");
                $(""value"").hide();
            }
        });
    }
</script>

");
            EndContext();
            BeginContext(2911, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e343b8eea47194957af1b133efb773ac9c2182810404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2970, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp1.Models.ManageAssetsAllocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
