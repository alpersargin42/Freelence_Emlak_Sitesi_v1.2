#pragma checksum "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "903262dfb4e8757d81b64db97c2722001adbe6ad445c1325ee40e266fcc05041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertiser_AdvertiserEditProfile), @"mvc.1.0.view", @"/Views/Advertiser/AdvertiserEditProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"903262dfb4e8757d81b64db97c2722001adbe6ad445c1325ee40e266fcc05041", @"/Views/Advertiser/AdvertiserEditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advertiser_AdvertiserEditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrate.Advertiser>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
  
    ViewData["Title"] = "AdvertiserEditProfile";
    Layout = "~/Views/Shared/Advertiser_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
 using (Html.BeginForm("AdvertiserEditProfile", "Advertiser", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Hesap Düzenleme Paneli</h4><br />\r\n                ");
#nullable restore
#line 13 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
           Write(Html.HiddenFor(x => x.AdvertiserID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "903262dfb4e8757d81b64db97c2722001adbe6ad445c1325ee40e266fcc050415098", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">İsim Soyisim</label>\r\n                        ");
#nullable restore
#line 17 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.AdvertiserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Hakkımda</label>\r\n                        ");
#nullable restore
#line 21 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.AdvertiserAbout, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Email Adresi</label>\r\n                        ");
#nullable restore
#line 25 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.AdvertiserMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Şifre</label>\r\n                        ");
#nullable restore
#line 29 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.PasswordFor(x => x.AdvertiserPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.ValidationMessageFor(x => x.AdvertiserPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Şifre Tekrar</label>\r\n                        ");
#nullable restore
#line 34 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.PasswordFor(x => x.AdvertiserPassword1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 35 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
                   Write(Html.ValidationMessageFor(x => x.AdvertiserPassword1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-gradient-info mr-2\">Güncelle</button>\r\n                    <button class=\"btn btn-gradient-warning\">İptal Et</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserEditProfile.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrate.Advertiser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591