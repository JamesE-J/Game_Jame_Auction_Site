#pragma checksum "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4510d0e7009f98632de63e7ad7c1bf2c3f63e9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ThreeThingAuction.Areas.Identity.Pages.Admin.Areas_Identity_Views_Admin_ThingList), @"mvc.1.0.view", @"/Areas/Identity/Views/Admin/ThingList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/Admin/ThingList.cshtml", typeof(ThreeThingAuction.Areas.Identity.Pages.Admin.Areas_Identity_Views_Admin_ThingList))]
namespace ThreeThingAuction.Areas.Identity.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\_ViewImports.cshtml"
using ThreeThingAuction.Areas.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4510d0e7009f98632de63e7ad7c1bf2c3f63e9b", @"/Areas/Identity/Views/Admin/ThingList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ebe60423b6d001c31db8380992d12e54a3e242", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Admin_ThingList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ThreeThingAuction.Models.Thing>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateThings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThingDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteThings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
  
    ViewData["Title"] = "ThingList";

#line default
#line hidden
            BeginContext(99, 36, true);
            WriteLiteral("\r\n<h2>Auction List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(135, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b62952e11f4c1d9bb82eb66da3d9b0", async() => {
                BeginContext(164, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(271, 40, false);
#line 16 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 42, false);
#line 19 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
           Write(Html.DisplayNameFor(model => model.Teamid));

#line default
#line hidden
            EndContext();
            BeginContext(409, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(465, 44, false);
#line 22 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
           Write(Html.DisplayNameFor(model => model.BidValue));

#line default
#line hidden
            EndContext();
            BeginContext(509, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(565, 43, false);
#line 25 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
           Write(Html.DisplayNameFor(model => model.EventId));

#line default
#line hidden
            EndContext();
            BeginContext(608, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(720, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(781, 39, false);
#line 34 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(820, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(888, 41, false);
#line 37 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Teamid));

#line default
#line hidden
            EndContext();
            BeginContext(929, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(997, 43, false);
#line 40 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
               Write(Html.DisplayFor(modelItem => item.BidValue));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1108, 42, false);
#line 43 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventId));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1217, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfd3c038d5240e09f69f749924f67f0", async() => {
                BeginContext(1269, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1280, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1304, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96e3fb3bbac4766854b6cd696cb14c0", async() => {
                BeginContext(1357, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Views\Admin\ThingList.cshtml"
        }

#line default
#line hidden
            BeginContext(1422, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1459, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8b98e2d2c84190a0b75337e7685940", async() => {
                BeginContext(1481, 15, true);
                WriteLiteral("Back to MyAdmin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1500, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ThreeThingAuction.Models.Thing>> Html { get; private set; }
    }
}
#pragma warning restore 1591
