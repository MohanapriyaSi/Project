#pragma checksum "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08377e6d9f5c1db3105c2444e2f267746d54485b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Details), @"mvc.1.0.view", @"/Views/Transaction/Details.cshtml")]
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
#line 1 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\_ViewImports.cshtml"
using RetailBankingSystemClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\_ViewImports.cshtml"
using RetailBankingSystemClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08377e6d9f5c1db3105c2444e2f267746d54485b", @"/Views/Transaction/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"471e9eaadd0616d0bda77ce630595c0fc9f75f8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RetailBankingSystemClient.Models.Transaction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
  
    ViewData["Title"] = "GetBalance";
    Layout = "~/Views/Shared/CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetBalance</h1>\r\n\r\n<div>\r\n    <h4>Transaction</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRange));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateRange));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Particulars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Particulars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Wihtdraw));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Wihtdraw));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deposit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deposit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SavingsBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.SavingsBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "E:\Users\RetailBankingSystem (1)\RetailBankingSystem1\RetailBankingSystem\RetailBankingSystemClient\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RetailBankingSystemClient.Models.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
