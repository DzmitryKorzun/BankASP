#pragma checksum "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3adf49d2f6b8b5e7df257def9c247fdd535d725"
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
#line 1 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
using BankSystemASP.Domain.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3adf49d2f6b8b5e7df257def9c247fdd535d725", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"ru\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3adf49d2f6b8b5e7df257def9c247fdd535d7253646", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n  <title>Банк</title>\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 311, "\"", 350, 1);
#nullable restore
#line 13 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
WriteAttributeValue("", 318, Url.Content("~/css/styles.css"), 318, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 396, "\"", 437, 1);
#nullable restore
#line 14 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
WriteAttributeValue("", 403, Url.Content("~/css/RegStyle.css"), 403, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 483, "\"", 527, 1);
#nullable restore
#line 15 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
WriteAttributeValue("", 490, Url.Content("~/css/ButtonStyle.css"), 490, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 573, "\"", 624, 1);
#nullable restore
#line 16 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
WriteAttributeValue("", 580, Url.Content("~/css/AuthenticationForm.css"), 580, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 670, "\"", 724, 1);
#nullable restore
#line 17 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
WriteAttributeValue("", 677, Url.Content("~/css/RegistrationFormStyle.css"), 677, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3adf49d2f6b8b5e7df257def9c247fdd535d7257116", async() => {
                WriteLiteral("    \r\n    <table class=\"table\">\r\n    <tr><td>Имя</td><td>Возраст</td></tr>\r\n");
#nullable restore
#line 23 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr><td>");
#nullable restore
#line 25 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 25 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
                              Write(item.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 26 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</table>\r\n  <div class=\"form-popup\" id=\"myForm\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3adf49d2f6b8b5e7df257def9c247fdd535d7258549", async() => {
                    WriteLiteral(@"
      <h1>Логин</h1>  
      <label for=""email""><b>Почта</b></label>
      <input type=""text"" placeholder=""Введите Почту"" name=""email"" required>  
      <label for=""psw""><b>Пароль</b></label>
      <input type=""password"" placeholder=""Введите Пароль"" name=""psw"" required>  
      <button type=""submit"" class=""btn"">Логин</button>
      <button type=""submit"" class=""btn cancel"" onclick=""closeForm()"">Закрыть</button>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  </div>\r\n  \r\n    <div class=\"topnav\">\r\n      <div class=\"mainLogo\">\r\n        <h1>ДмитриБанк</h1>\r\n      </div>\r\n        <a>Главная</a>\r\n        <a>О банке</a>\r\n        <a>Курсы</a>\r\n        <a ");
#nullable restore
#line 47 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
      Write(Url.Action("",""));

#line default
#line hidden
#nullable disable
                WriteLiteral(@">Филлиалы</a>
      </div>
      <div class=""authenticationForm"">
        <div class=""text-field"">
          <label class=""text-field__label"" for=""login"">Логин</label>
          <input class=""text-field__input"" type=""text"" name=""login"" id=""login"" placeholder=""Login"">
        </div>
        <div class=""text-field"">
        <label class=""text-field__label"">Пароль</label>
        <input class=""text-field__input"" type=""password"" name=""password"" id=""password"" placeholder=""Password"">
        </div>
        <div class=""authentication-wrapper"">
          <button class=""signIn-button authentication-button"">Войти</button>
          <button class=""registration-button authentication-button""");
                BeginWriteAttribute("onclick", " onclick=\"", 2391, "\"", 2449, 3);
                WriteAttributeValue("", 2401, "location.href=\'", 2401, 15, true);
#nullable restore
#line 60 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Views\Home\Index.cshtml"
WriteAttributeValue("", 2416, Url.Action("GetUsers", "Users"), 2416, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2448, "\'", 2448, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Регистрация</button>\r\n        </div>\r\n      </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
