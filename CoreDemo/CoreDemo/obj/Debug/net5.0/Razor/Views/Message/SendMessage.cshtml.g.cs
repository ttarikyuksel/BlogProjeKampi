#pragma checksum "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d545e9b8186506b41d41613aaa9a843f840a4c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendMessage), @"mvc.1.0.view", @"/Views/Message/SendMessage.cshtml")]
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
#line 1 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d545e9b8186506b41d41613aaa9a843f840a4c48", @"/Views/Message/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
  
    ViewData["Title"] = "SendMessage";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Mesaj Oluştur</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
 using (Html.BeginForm("SendMessage", "Message", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.Label("Alıcı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"text\" class=\"form-contol\"/>\r\n    <br />\r\n");
#nullable restore
#line 16 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.Label("Konu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.TextBoxFor(x=>x.Subject, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.ValidationMessageFor(x=>x.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />    \r\n");
#nullable restore
#line 20 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.Label("Mesajınız"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.TextAreaFor(x=>x.MessageDetail,15,3, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
Write(Html.ValidationMessageFor(x=>x.MessageDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Mesajı Gönder</button>\r\n");
#nullable restore
#line 25 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591