#pragma checksum "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7babdd3c341d8c1a8a7e6e4e6357ce1ca7f4a6a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resume__SkillsPartial), @"mvc.1.0.view", @"/Views/Resume/_SkillsPartial.cshtml")]
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
#nullable restore
#line 1 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\_ViewImports.cshtml"
using Resume.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\_ViewImports.cshtml"
using Resume.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml"
using Resume.Domain.ViewModels.Skill;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7babdd3c341d8c1a8a7e6e4e6357ce1ca7f4a6a1", @"/Views/Resume/_SkillsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf294436411706a3681156ec50dcf97631e764f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Resume__SkillsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SkillViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section\">\r\n    <h2 class=\"title title--h2\">?????????? ?????? ????</h2>\r\n    <div class=\"box-gray\">\r\n\r\n");
#nullable restore
#line 8 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml"
         foreach (SkillViewModel item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"progress\">\r\n                <div class=\"progress-bar\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 330, "\"", 359, 1);
#nullable restore
#line 11 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml"
WriteAttributeValue("", 346, item.Percent, 346, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\">\r\n                    <div class=\"progress-text\"><span>");
#nullable restore
#line 12 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 12 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml"
                                                                        Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??</span></div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 15 "E:\47_Resume_Akhundi\47_Resume_Akhundi\47_Resume_Akhundi_Attach\Resume\Resume.Web\Views\Resume\_SkillsPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SkillViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
