#pragma checksum "C:\Users\Piotr\Documents\Projekty\ASP.Net\Currencies Calculator\Currencies Calculator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f47ca6a5d4811ef25de15cd87a123e01a3e397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Piotr\Documents\Projekty\ASP.Net\Currencies Calculator\Currencies Calculator\Views\_ViewImports.cshtml"
using Currencies_Calculator;

#line default
#line hidden
#line 2 "C:\Users\Piotr\Documents\Projekty\ASP.Net\Currencies Calculator\Currencies Calculator\Views\_ViewImports.cshtml"
using Currencies_Calculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f47ca6a5d4811ef25de15cd87a123e01a3e397", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e8168a11fc8837b7170b6981d9faef2e985d09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Currencies_Calculator.Models.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Piotr\Documents\Projekty\ASP.Net\Currencies Calculator\Currencies Calculator\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Currencies Exchange Web Application v0.1";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(127, 50, true);
            WriteLiteral("<fieldset>\r\n\t<br />\r\n\tPick the first currency\r\n\r\n\t");
            EndContext();
            BeginContext(178, 88, false);
#line 10 "C:\Users\Piotr\Documents\Projekty\ASP.Net\Currencies Calculator\Currencies Calculator\Views\Home\Index.cshtml"
Write(Html.DropDownList("FirstCurrency", Model.CurrenciesCodes, new { @id = "FirstCurrency" }));

#line default
#line hidden
            EndContext();
            BeginContext(266, 50, true);
            WriteLiteral("\r\n\t<br />\r\n\t<br />\r\n\tPick the second currency\r\n\r\n\t");
            EndContext();
            BeginContext(317, 90, false);
#line 15 "C:\Users\Piotr\Documents\Projekty\ASP.Net\Currencies Calculator\Currencies Calculator\Views\Home\Index.cshtml"
Write(Html.DropDownList("SecondCurrency", Model.CurrenciesCodes, new { @id = "SecondCurrency" }));

#line default
#line hidden
            EndContext();
            BeginContext(407, 372, true);
            WriteLiteral(@"
	<br />
	<br />
	<input type=""text"" required name=""Amount"" min=""0.01"" step=""0.01"" placeholder=""0.00"" id=""Amount"">
	<br />
	<br />
	<p>
		<button type=""button""
				class=""btn btn-primary""
				id=""Exchange"">
			Exchange
		</button>

	</p>
	<br />
	<br />
	<p id=""ExchangedAmount"">

	</p>
	<br />
	<br />
	<p id=""MaxExchanged"">

	</p>
</fieldset>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(797, 1492, true);
                WriteLiteral(@"
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js""></script>
	<script type=""text/javascript"">
		function validateForm() {
			var isValid = false;
			if ($(""#FirstCurrency"").val() == $(""#SecondCurrency"").val()) {
				alert(""Select different currencies"");
			} else if ($(""#Amount"").val().is <= 0) {
				alert(""Amount must be positive"");
			} else if (isNaN($(""#Amount"").val())) {
				alert(""Input is not a number"");
			} else if ($(""#Amount"").val().toString().includes(`,`) == true) {
				alert(""Use dot as a decimal separator"");
			} else {
				isValid = true;
			}
			
			return isValid;
		}
	</script>

	<script type=""text/javascript"">
		$(document).ready(function () {
			$(""#Exchange"").click(function () {
				var a = $(""#Amount"").val().toString();

				console.log(`a = ${a}`);
				console.log(""exchanged clicked"");
				if (validateForm() == true) {
					$.post(""/Home/Exchange"", { firstCurrency: $(""#FirstCurrency"").val(), secondCurrency: $(""#SecondCurrency"")");
                WriteLiteral(@".val(), amountString: $(""#Amount"").val() },
						function (result) {
							var jsonObject = $.parseJSON(result)
							$(""#ExchangedAmount"").text(`Exchanged amount: ${jsonObject.PresentExchangedAmount} ${$(""#SecondCurrency"").val()}`);
							$(""#MaxExchanged"").text(`If you had exchanged it on ${jsonObject.MaxExchangedDate} , you would have get a ${jsonObject.MaxExchangedAmount} ${$(""#SecondCurrency"").val()}`);

						});
				}
			});
		});
	</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Currencies_Calculator.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
