#pragma checksum "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ThreeThingAuction.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml", typeof(ThreeThingAuction.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__StatusMessage))]
namespace ThreeThingAuction.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\_ViewImports.cshtml"
using ThreeThingAuction.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ThreeThingAuction.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using ThreeThingAuction.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ebe60423b6d001c31db8380992d12e54a3e242", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"466dadd15e58da42c0f2c92dab8dac1247fd20b2", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2542f88497380ec7c22629c26b64bd0aff206ef0", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(136, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#line 6 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            BeginContext(202, 158, true);
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            EndContext();
            BeginContext(361, 5, false);
#line 8 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 10 "C:\Users\James Edmondson-Jone\Documents\Uni Work\Masters\DevProject\DevProj2019GroupY\ThreeThingAuction\ThreeThingAuction\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591