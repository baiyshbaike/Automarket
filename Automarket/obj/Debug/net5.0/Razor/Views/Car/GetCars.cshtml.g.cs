#pragma checksum "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f9b24dd4299d30640ba79c1dcad264ef16d9d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetCars), @"mvc.1.0.view", @"/Views/Car/GetCars.cshtml")]
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
#line 1 "D:\Programming\backend\C#\Automarket\Automarket\Views\_ViewImports.cshtml"
using Automarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\backend\C#\Automarket\Automarket\Views\_ViewImports.cshtml"
using Automarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f9b24dd4299d30640ba79c1dcad264ef16d9d3", @"/Views/Car/GetCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea89afa076838a456b05fd875eee46d14a4ea88b", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_GetCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Automarket.Domain.Entity.Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
 foreach (var car in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 9 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
  Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 10 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
  Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 11 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
  Write(car.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 12 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
  Write(car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 13 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
  Write(car.DateCreate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "D:\Programming\backend\C#\Automarket\Automarket\Views\Car\GetCars.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Automarket.Domain.Entity.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
