#pragma checksum "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\InputDoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83134b464cf762f1c6c4ad36a2b2176a9c8deaf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InputDoc), @"mvc.1.0.view", @"/Views/Home/InputDoc.cshtml")]
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
#line 1 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83134b464cf762f1c6c4ad36a2b2176a9c8deaf8", @"/Views/Home/InputDoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9751a11891ba42cf18e84a4b82e03210f652818", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InputDoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSite.Models.Monograph>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\InputDoc.cshtml"
  
    ViewBag.Title = "Выходные документы";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Выходные документы</h2>\r\n<p>\r\n    ");
#nullable restore
#line 9 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\InputDoc.cshtml"
Write(Html.ActionLink("Список всех монографий", "AllPublish"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\InputDoc.cshtml"
Write(Html.ActionLink("Список монографий определённого преподавателя", "TeacherPublish"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     ");
#nullable restore
#line 11 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\InputDoc.cshtml"
Write(Html.ActionLink("Список преподавателей, отсортированный по алфавиту", "AllTeacher"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n \r\n<div>\r\n    ");
#nullable restore
#line 15 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\InputDoc.cshtml"
Write(Html.ActionLink("К списку", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebSite.Models.Monograph>> Html { get; private set; }
    }
}
#pragma warning restore 1591
