#pragma checksum "C:\Users\seriu\Desktop\Shop\Shop\Pages\Oplata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bab4941173cc367246859048b9575141a2ffe93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.Pages.Pages_Oplata), @"mvc.1.0.razor-page", @"/Pages/Oplata.cshtml")]
namespace Shop.Pages
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
#line 1 "C:\Users\seriu\Desktop\Shop\Shop\Pages\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bab4941173cc367246859048b9575141a2ffe93", @"/Pages/Oplata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cba9361ab1a6ef83b4de057abd9306c5ee5d552", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Oplata : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://money.yandex.ru/quickpay/confirm.xml"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\seriu\Desktop\Shop\Shop\Pages\Oplata.cshtml"
  
    ViewBag.Title = "Страница оплаты";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\"margin-top:20%;\">Оплата товара \"");
#nullable restore
#line 7 "C:\Users\seriu\Desktop\Shop\Shop\Pages\Oplata.cshtml"
                                      Write(Model.Product.nameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h2>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bab4941173cc367246859048b9575141a2ffe934263", async() => {
                WriteLiteral("\r\n        <input name=\"label\"");
                BeginWriteAttribute("value", " value=\"", 289, "\"", 321, 1);
#nullable restore
#line 10 "C:\Users\seriu\Desktop\Shop\Shop\Pages\Oplata.cshtml"
WriteAttributeValue("", 297, Model.Product.idProduct, 297, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\">\r\n        <input name=\"receiver\" value=\"4100115419954862\" type=\"hidden\">\r\n        <input name=\"quickpay-form\" value=\"shop\" type=\"hidden\">\r\n        <input type=\"hidden\" name=\"targets\"");
                BeginWriteAttribute("value", " value=\"", 519, "\"", 567, 3);
                WriteAttributeValue("", 527, "Оплата", 527, 6, true);
                WriteAttributeValue(" ", 533, "заказа", 534, 7, true);
#nullable restore
#line 13 "C:\Users\seriu\Desktop\Shop\Shop\Pages\Oplata.cshtml"
WriteAttributeValue(" ", 540, Model.Product.nameProduct, 541, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <label for=\"sum\">Сумма: </label><br />\r\n        <input name=\"sum\"");
                BeginWriteAttribute("value", " value=\"", 644, "\"", 679, 1);
#nullable restore
#line 15 "C:\Users\seriu\Desktop\Shop\Shop\Pages\Oplata.cshtml"
WriteAttributeValue("", 652, Model.Product.priceProduct, 652, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""10"" data-type=""number"" type=""text""><br /><br />
        <label for=""sum"">Способ оплаты: </label><br />
        <input type=""radio"" name=""paymentType"" value=""PC"">Яндекс.Деньгами
        <input type=""radio"" name=""paymentType"" value=""AC"">Банковской картой
        <input type=""radio"" name=""paymentType"" value=""2S"">Сбербанк онлайн
        <input type=""submit"" name=""submit-button"" value=""Оплатить"">
        <input name=""successURL"" value=""http://mystore.somee.com/Home/Paid"" type=""hidden"">
        <input name=""quickpay-back-url"" value=""http://mystore.somee.com/"" type=""hidden"">
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Pages.OplataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.Pages.OplataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.Pages.OplataModel>)PageContext?.ViewData;
        public Shop.Pages.OplataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591