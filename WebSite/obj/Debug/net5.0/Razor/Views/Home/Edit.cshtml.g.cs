#pragma checksum "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "111232dca993d29910b836ddc8d772ef1f016bb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"111232dca993d29910b836ddc8d772ef1f016bb0", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9751a11891ba42cf18e84a4b82e03210f652818", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSite.Models.Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<h2>Изменение преподователя</h2>\r\n \r\n");
#nullable restore
#line 9 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Преподователь</legend>\r\n \r\n        ");
#nullable restore
#line 14 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n        <p> Имя <br />\r\n            ");
#nullable restore
#line 17 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n \r\n        <p>Должность <br />\r\n        ");
#nullable restore
#line 21 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
   Write(Html.EditorFor(model => model.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n \r\n        <p>Ученая степень  <br />\r\n            ");
#nullable restore
#line 25 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.Degree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n         <p>Ученое звание  <br />\r\n            ");
#nullable restore
#line 28 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n         <p>Стаж работы  <br />\r\n            ");
#nullable restore
#line 31 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.Exp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>Публикация <br />\r\n            ");
#nullable restore
#line 34 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.MonographId, ViewBag.Monograph as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <input type=\"submit\" value=\"Сохранить\" />\r\n        </p>\r\n    </fieldset>\r\n");
#nullable restore
#line 40 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 42 "C:\Users\Andrey\Pet-Project\WebSite\WebSite\Views\Home\Edit.cshtml"
Write(Html.ActionLink("Вернуться к списку", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSite.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591