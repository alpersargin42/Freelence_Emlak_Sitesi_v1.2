#pragma checksum "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0ba24219e8c4238d1a0baa0c5a4bdd3f9d1222d3f6396078ac1d727d4dc47d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendBox), @"mvc.1.0.view", @"/Views/Message/SendBox.cshtml")]
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
#line 1 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e0ba24219e8c4238d1a0baa0c5a4bdd3f9d1222d3f6396078ac1d727d4dc47d5", @"/Views/Message/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Views/Shared/Advertiser_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Giden Kutusu</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Alıcı</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı Aç</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
           Write(item.ReceiverUser.AdvertiserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
            Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 640, "\"", 686, 2);
            WriteAttributeValue("", 647, "/Message/MessageDetails/", 647, 24, true);
#nullable restore
#line 26 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
WriteAttributeValue("", 671, item.MessageID, 671, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-gradient-warning\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\SARGIN\Desktop\Trkmn_Group\WebApplication1\WebApplication1\Views\Message\SendBox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591