#pragma checksum "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dba5b95f60d4622ce0f1575d48cd77a7283c5861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBLog), @"mvc.1.0.view", @"/Views/Blog/EditBLog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dba5b95f60d4622ce0f1575d48cd77a7283c5861", @"/Views/Blog/EditBLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_EditBLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
  
    ViewData["Title"] = "EditBLog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenlenme Sayfası</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogID, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.Label("Blog Thumbnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogThumbnailImage, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID,(List<SelectListItem>)ViewBag.cv, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,10,3, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 30 "C:\Users\t_yuksel\Desktop\CoreDemo\CoreDemo\Views\Blog\EditBLog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
