#pragma checksum "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac1219f955806a2347bf748257625cd48c4fb9f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserHome_AssetsAllocation), @"mvc.1.0.view", @"/Views/UserHome/AssetsAllocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserHome/AssetsAllocation.cshtml", typeof(AspNetCore.Views_UserHome_AssetsAllocation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac1219f955806a2347bf748257625cd48c4fb9f4", @"/Views/UserHome/AssetsAllocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6545200b2b1f984d3aecce45fd26db78e2f32d9d", @"/Views/_ViewImports.cshtml")]
    public class Views_UserHome_AssetsAllocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-label-left input_mask"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssetsAllocation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
  
    ViewData["Title"] = "AssetsAllocation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(105, 778, true);
            WriteLiteral(@"

<!-- page content -->
<div class=""right_col"" role=""main"">
    <div class="""">
        <div class=""page-title"">
            <div class=""title_left"">
                <h1>Assets Allocation <a class=""fa fa-building""></a>---<a style=""margin-left:5px;"" class=""fa fa-users""></a></h1>
            </div>


        </div>
        <div class=""clearfix""></div>

        <div class=""row"">

            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Allocate an asset to a tenant <a class=""fa fa-plus""></a></h2>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">

                        ");
            EndContext();
            BeginContext(883, 4101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1219f955806a2347bf748257625cd48c4fb9f46045", async() => {
                BeginContext(1026, 279, true);
                WriteLiteral(@"



                            <div class=""col-md-6 col-sm-6 col-xs-12 form-group has-feedback"">
                                <label for=""heard"">Select Tenant *:</label>
                                <select id=""heard"" name=""TenantId"" class=""form-control"" required>
");
                EndContext();
#line 37 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
                                     foreach (string tenant in (ViewData["tenants"] as Array))
                                    {

#line default
#line hidden
                BeginContext(1440, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1480, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1219f955806a2347bf748257625cd48c4fb9f47137", async() => {
                    BeginContext(1535, 33, false);
#line 39 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
                                                                                         Write(tenant.Remove(tenant.Length - 36));

#line default
#line hidden
                    EndContext();
                    BeginContext(1568, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
                                           WriteLiteral(tenant.Substring(tenant.Length - 36));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1578, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"

                                    }

#line default
#line hidden
                BeginContext(1621, 388, true);
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""col-md-6 col-sm-6 col-xs-12 form-group has-feedback"">
                                <label for=""heard"">Select Available Asset *:</label>
                                <select id=""heard"" name=""AssetID"" class=""form-control"" required>
                            
");
                EndContext();
#line 48 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
                                     foreach (string asset in (ViewData["assets"] as Array))
                                    {

#line default
#line hidden
                BeginContext(2142, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(2182, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1219f955806a2347bf748257625cd48c4fb9f410532", async() => {
                    BeginContext(2235, 31, false);
#line 50 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
                                                                                       Write(asset.Remove(asset.Length - 36));

#line default
#line hidden
                    EndContext();
                    BeginContext(2266, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"
                                           WriteLiteral(asset.Substring(asset.Length - 36));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2276, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 51 "C:\Users\Enoch Sodiya\source\repos\WebApp1\WebApp1\Views\UserHome\AssetsAllocation.cshtml"

                                    }

#line default
#line hidden
                BeginContext(2319, 2658, true);
                WriteLiteral(@"                                </select>
                            </div>

                            <div class=""col-md-6"">
                                <label >
                                    Start Date <span class=""required"">*</span>
                                </label>

                                <div class=""control-group"">
                                    <div class=""controls"">
                                        <div class=""col-md-6 col-sm-8 col-xs-12 xdisplay_inputx form-group has-feedback"">
                                            <input type=""text"" class=""form-control has-feedback-left"" name=""Start_Date"" id=""single_cal4"" placeholder=""Start_Date"" aria-describedby=""inputSuccess2Status4"">
                                            <span class=""fa fa-calendar-o form-control-feedback left"" aria-hidden=""true""></span>
                                            <span id=""inputSuccess2Status4"" class=""sr-only"">(success)</span>
                                     ");
                WriteLiteral(@"   </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""col-md-6"">
                                <label>
                                    End Date <span class=""required"">*</span>
                                </label>

                                <div class=""control-group"">
                                    <div class=""controls"">
                                        <div class=""col-md-6 col-sm-8 col-xs-12 xdisplay_inputx form-group has-feedback"">
                                            <input type=""text"" class=""form-control has-feedback-left"" name=""End_Date"" id=""single_cal2"" placeholder=""End_Date"" aria-describedby=""inputSuccess2Status4"">
                                            <span class=""fa fa-calendar-o form-control-feedback left"" aria-hidden=""true""></span>
                                            <span id=""inputSuccess2Status4"" class=""sr-only"">(success)<");
                WriteLiteral(@"/span>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label for=""email"">Agreed pay amount * :</label>
                                <input type=""text"" id=""email"" class=""form-control"" name=""Due_Payment"" data-parsley-trigger=""change"" required />
                            </div>
                            <input type=""submit"" name=""Submit"" class=""btn btn-success"" />
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4984, 134, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /page content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
