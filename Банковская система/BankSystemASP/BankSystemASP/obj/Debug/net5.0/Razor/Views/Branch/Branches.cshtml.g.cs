#pragma checksum "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Branch\Branches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392177b7e6f18474b594951940319e3d509e28e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Branches), @"mvc.1.0.view", @"/Views/Branch/Branches.cshtml")]
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
#line 1 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Branch\Branches.cshtml"
using BankSystemASP.Domain.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392177b7e6f18474b594951940319e3d509e28e8", @"/Views/Branch/Branches.cshtml")]
    public class Views_Branch_Branches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Branch>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<HTML>\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "392177b7e6f18474b594951940319e3d509e28e82992", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <title>Филлиалы</title>\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "392177b7e6f18474b594951940319e3d509e28e84019", async() => {
                WriteLiteral(@"     
     Область
  <form>
   <p><select name=""Область"">
    <option type=""submit"" selected value=""s1""></option>
   </select>
   </form>
     Город
  <form>
   <p><select name=""Города"">
    <option type=""submit"" selected value=""s1""></option>
   </select>
   </form>

    Улица
  <form>
   <p><select name=""Улица"">
    <option type=""submit"" selected value=""s1""></option>
   </select>
   </form>

   
     Номер
  <form>
   <p><select name=""Область"">
");
#nullable restore
#line 35 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Branch\Branches.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <option type=\"submit\" selected value=\"s1\">");
#nullable restore
#line 37 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Branch\Branches.cshtml"
                                               Write(item.Namber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\n");
#nullable restore
#line 38 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Branch\Branches.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n   </select>\r\n   </form>\r\n\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</HTML>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Branch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
