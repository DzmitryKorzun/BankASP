#pragma checksum "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2bd30d7b6d0be525dc80ddd985a3b62779969c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2bd30d7b6d0be525dc80ddd985a3b62779969c", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"ru\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2bd30d7b6d0be525dc80ddd985a3b62779969c2720", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n  <title>Банк</title>\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 246, "\"", 285, 1);
#nullable restore
#line 13 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml"
WriteAttributeValue("", 253, Url.Content("~/css/styles.css"), 253, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 331, "\"", 372, 1);
#nullable restore
#line 14 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml"
WriteAttributeValue("", 338, Url.Content("~/css/RegStyle.css"), 338, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 418, "\"", 462, 1);
#nullable restore
#line 15 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml"
WriteAttributeValue("", 425, Url.Content("~/css/ButtonStyle.css"), 425, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 508, "\"", 559, 1);
#nullable restore
#line 16 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml"
WriteAttributeValue("", 515, Url.Content("~/css/AuthenticationForm.css"), 515, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n  <link");
                BeginWriteAttribute("href", " href=\"", 605, "\"", 659, 1);
#nullable restore
#line 17 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml"
WriteAttributeValue("", 612, Url.Content("~/css/RegistrationFormStyle.css"), 612, 47, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2bd30d7b6d0be525dc80ddd985a3b62779969c6165", async() => {
                WriteLiteral(@"
    
  <div class=""form-popup"" id=""myForm"">
    <form action=""/action_page.php"" class=""form-container"">
      <h1>Логин</h1>  
      <label for=""email""><b>Почта</b></label>
      <input type=""text"" placeholder=""Введите Почту"" name=""email"" required>  
      <label for=""psw""><b>Пароль</b></label>
      <input type=""password"" placeholder=""Введите Пароль"" name=""psw"" required>  
      <button type=""submit"" class=""btn"">Логин</button>
      <button type=""submit"" class=""btn cancel"" onclick=""closeForm()"">Закрыть</button>
    </form>
  </div>
  
    <div class=""topnav"">
      <div class=""mainLogo"">
        <h1>ДмитриБанк</h1>
      </div>
        <a class=""active"" href=""#home"">Главная</a>
        <a");
                BeginWriteAttribute("href", " href=\"", 1433, "\"", 1470, 1);
#nullable restore
#line 39 "E:\Documents\Диплом\Программа\Банковская система\BankSystemASP\BankSystemASP\Pages\Index.cshtml"
WriteAttributeValue("", 1440, Url.Page("/moneyTransaction"), 1440, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">О банке</a>
        <a href=""#contact"">Курсы</a>
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
          <button class=""registration-button authentication-button"">Регистрация</button>
        </div>
      </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankSystemASP.Data.Models.User> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankSystemASP.Data.Models.User> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankSystemASP.Data.Models.User>)PageContext?.ViewData;
        public BankSystemASP.Data.Models.User Model => ViewData.Model;
    }
}
#pragma warning restore 1591
