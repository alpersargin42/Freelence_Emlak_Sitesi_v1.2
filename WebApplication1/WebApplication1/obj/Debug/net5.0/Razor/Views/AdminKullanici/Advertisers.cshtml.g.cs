#pragma checksum "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a551f20ae0973394289396abe4ca2a39117b67ee83028b6b2742fc8ba303bd32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminKullanici_Advertisers), @"mvc.1.0.view", @"/Views/AdminKullanici/Advertisers.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a551f20ae0973394289396abe4ca2a39117b67ee83028b6b2742fc8ba303bd32", @"/Views/AdminKullanici/Advertisers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminKullanici_Advertisers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Advertiser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
  
    ViewData["Title"] = "Advertisers";
    Layout = "~/Views/Shared/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Kullanıcılar</h1>\r\n<br/>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kullanıcı Adı</th>\r\n        <th>Kullanıcı Maili</th>\r\n        <th>Kullanıcı Şifresi</th>\r\n    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 44 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
           Write(item.AdvertiserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
           Write(item.AdvertiserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
           Write(item.AdvertiserMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
           Write(item.AdvertiserPassword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\AdminKullanici\Advertisers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Advertiser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
