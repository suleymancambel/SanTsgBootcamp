#pragma checksum "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27c25e514da235f51c22f833a11c37206f646a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PriceSearch_PriceSearch), @"mvc.1.0.view", @"/Views/PriceSearch/PriceSearch.cshtml")]
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
#line 1 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\_ViewImports.cshtml"
using SanTsgBootcamp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\_ViewImports.cshtml"
using SanTsgBootcamp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c25e514da235f51c22f833a11c37206f646a36", @"/Views/PriceSearch/PriceSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b1d6df4bc1f144c3c1a9bd03f8d75c98d0a4f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PriceSearch_PriceSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BeginTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BeginTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
  
    ViewData["Title"] = "PriceSearch";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>PriceSearch</h3>

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
  /* Add a grey background color to the table header ");
            WriteLiteral(@"and on hover */
  background-color: #f1f1f1;
}
</style>



<input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for City.."">

<table id=""myTable"">
  <tr class=""header"">
    <th></th>
  
  </tr>

	<thead>
		<tr>
			<th><h5>Hotel Name</h5></th>
			<th><h5>Hotel Address</h5></th>
			<th><h5>Hotel Price</h5></th>
			<th><h5>Currency</h5></th>
			

			
		
		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 68 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<tr>\r\n\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27c25e514da235f51c22f833a11c37206f646a365902", async() => {
#nullable restore
#line 71 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
                                                                                                                  Write(item.name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-offerid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
                                                                                  WriteLiteral(item.offers[0].offerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["offerid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-offerid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["offerid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 72 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
   Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 73 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
   Write(item.offers[0].price.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t<td>");
#nullable restore
#line 74 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"
   Write(item.offers[0].price.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\r\n\t\r\n\r\n\t\r\n\t\t\t\t\r\n\t\t\t\r\n\r\n\t</tr>\r\n");
#nullable restore
#line 83 "C:\Users\suleyman\Desktop\SanTsgBootcamp\SanTsgBootcamp.Web\Views\PriceSearch\PriceSearch.cshtml"




		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	</tbody>
</table>






     
   
 
      
     
 

<script>
function myFunction() {
  // Declare variables
  var input, filter, table, tr, td, i, txtValue;
  input = document.getElementById(""myInput"");
  filter = input.value.toUpperCase();
  table = document.getElementById(""myTable"");
  tr = table.getElementsByTagName(""tr"");

  // Loop through all table rows, and hide those who don't match the search query
  for (i = 0; i < tr.length; i++) {
    td = tr[i].getElementsByTagName(""td"")[0];
    if (td) {
      txtValue = td.textContent || td.innerText;
      if (txtValue.toUpperCase().indexOf(filter) > -1) {
        tr[i].style.display = """";
      } else {
        tr[i].style.display = ""none"";
      }
    }
  }
}
</script>
");
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
