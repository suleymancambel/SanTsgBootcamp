#pragma checksum "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\getproductinfo\GetProductInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6437bf30bd737847c407468d6f9920ed54c933b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_getproductinfo_GetProductInfo), @"mvc.1.0.view", @"/Views/getproductinfo/GetProductInfo.cshtml")]
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
#line 1 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\_ViewImports.cshtml"
using SanTsgBootcamp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\_ViewImports.cshtml"
using SanTsgBootcamp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6437bf30bd737847c407468d6f9920ed54c933b0", @"/Views/getproductinfo/GetProductInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b1d6df4bc1f144c3c1a9bd03f8d75c98d0a4f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_getproductinfo_GetProductInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\getproductinfo\GetProductInfo.cshtml"
  
    ViewData["Title"] = "GetProductInfo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<style>
    #myInput {
  background-image: url('/css/searchicon.png'); /* Add a search icon to input */
  background-position: 10px 12px; /* Position the search icon */
  background-repeat: no-repeat; /* Do not repeat the icon image */
  width: 100%; /* Full-width */
  font-size: 16px; /* Increase font-size */
  padding: 12px 20px 12px 40px; /* Add some padding */
  border: 1px solid #ddd; /* Add a grey border */
  margin-bottom: 12px; /* Add some space below the input */
}

#myTable {
  border-collapse: collapse; /* Collapse borders */
  width: 100%; /* Full-width */
  border: 1px solid #ddd; /* Add a grey border */
  font-size: 18px; /* Increase font-size */
}

#myTable th, #myTable td {
  text-align: left; /* Left-align text */
  padding: 12px; /* Add padding */
}

#myTable tr {
  /* Add a bottom border to all table rows */
  border-bottom: 1px solid #ddd;
}

#myTable tr.header, #myTable tr:hover {
  /* Add a grey background color to the table header and on hover */");
            WriteLiteral(@"
  background-color: #f1f1f1;
}
</style>

<h3>Hotel Select</h3>

 


<table id=""myTable"">
  <tr class=""header"">
    
   <th >City Name</th>
    <th >Phone Number</th>
    <th >Hotel Picture</th>
    <th >Hotel Stars</th>
    
    
    
  </tr>
 
    <tr>
    
    
    <td>");
#nullable restore
#line 66 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\getproductinfo\GetProductInfo.cshtml"
   Write(Model.city.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 67 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\getproductinfo\GetProductInfo.cshtml"
   Write(Model.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><img");
            BeginWriteAttribute("src", " src=\"", 1488, "\"", 1514, 1);
#nullable restore
#line 68 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\getproductinfo\GetProductInfo.cshtml"
WriteAttributeValue("", 1494, Model.thumbnailFull, 1494, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n    <td>");
#nullable restore
#line 69 "C:\Users\suleyman\Source\Repos\suleymancambel\SanTsgBootcamp\SanTsgBootcamp.Web\Views\getproductinfo\GetProductInfo.cshtml"
   Write(Model.stars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    \r\n   \r\n    </tr>\r\n\r\n    \r\n\r\n\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
