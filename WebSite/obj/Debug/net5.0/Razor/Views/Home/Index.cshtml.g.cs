#pragma checksum "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22bf9854e10dc4eb3c7d7557935300ff9f6c7820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22bf9854e10dc4eb3c7d7557935300ff9f6c7820", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9751a11891ba42cf18e84a4b82e03210f652818", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSite.Models.Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Монография преподователей";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<h2>Монография преподователей</h2>\r\n<p>\r\n    ");
#nullable restore
#line 8 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
Write(Html.ActionLink("Добавить преподователя", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table>\r\n    <tr>\r\n        <th>Имя преподователя</th>\r\n        <th>Должность</th>\r\n        <th>Учёная степень</th>\r\n        <th>Ученое звание</th>\r\n        <th>Стаж работы</th>\r\n        <th>Публикация</th>\r\n        <th></th>\r\n    </tr>\r\n \r\n");
#nullable restore
#line 21 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Degree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Exp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Monograph.Publish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Редактировать", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 44 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Удалить", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<p>\r\n    ");
#nullable restore
#line 50 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Index.cshtml"
Write(Html.ActionLink("Каталог издательств", "ListTeams"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebSite.Models.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
