#pragma checksum "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Advertiser\AdvertiserNavbarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a971c9ce1e67876a76e2262d3a79bffe2196186f193e5b4d6a44e51023daaa48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertiser_AdvertiserNavbarPartial), @"mvc.1.0.view", @"/Views/Advertiser/AdvertiserNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a971c9ce1e67876a76e2262d3a79bffe2196186f193e5b4d6a44e51023daaa48", @"/Views/Advertiser/AdvertiserNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advertiser_AdvertiserNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\r\n    <ul class=\"nav\">\r\n");
            WriteLiteral(@"        <li class=""nav-item"">
        <a class=""nav-link"" href=""/Advertiser/AdvertiserEditProfile"">
        <span class=""menu-title"">Profilim</span>
        <i class=""mdi mdi-contacts menu-icon""></i>
        </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Dashboard/Index"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Estate/EstateListByAdvertiser"">
                <span class=""menu-title"">İlanlarım</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Estate/EstateAdd"">
                <span class=""menu-title"">Yeni İlan</span>
                <i class=""mdi mdi-plus menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a cla");
            WriteLiteral("ss=\"nav-link\" href=\"/Message/Index/\">\r\n                <span class=\"menu-title\">Mesajlar</span>\r\n                <i class=\"mdi mdi-message menu-icon\"></i>\r\n            </a>\r\n        </li>\r\n");
            WriteLiteral("        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" href=\"/Estate/Index\">\r\n                <span class=\"menu-title\">Siteye Git</span>\r\n                <i class=\"mdi mdi-car menu-icon\"></i>\r\n            </a>\r\n        </li>\r\n");
            WriteLiteral(@"        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Login/LogOut"">
                <span class=""menu-title"">Çıkış Yap</span>
                <i class=""mdi mdi-logout menu-icon""></i>
            </a>
        </li>


    </ul>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591