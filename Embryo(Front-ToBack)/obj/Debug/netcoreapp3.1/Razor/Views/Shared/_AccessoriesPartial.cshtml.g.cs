#pragma checksum "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e7ef31ba745b2d7b11707fc973ab3eb607a29b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AccessoriesPartial), @"mvc.1.0.view", @"/Views/Shared/_AccessoriesPartial.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\_ViewImports.cshtml"
using Embryo_Front_ToBack_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\_ViewImports.cshtml"
using Embryo_Front_ToBack_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e7ef31ba745b2d7b11707fc973ab3eb607a29b", @"/Views/Shared/_AccessoriesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4bf565d853f8940aa53a9d92b53bb10cc6ff441", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AccessoriesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Accessories>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div data-id=\"");
#nullable restore
#line 6 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml"
             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"one-cart\">\r\n        <div class=\"product\">\r\n            <i class=\"fa-solid fa-heart\"></i>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34e7ef31ba745b2d7b11707fc973ab3eb607a29b4373", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 217, "~/assets/images/accessories/", 217, 28, true);
#nullable restore
#line 9 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml"
AddHtmlAttributeValue("", 245, item.Image, 245, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"product-info\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 335, "\"", 342, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h5>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </a>\r\n            <div class=\"shop-icon\">\r\n                <i class=\"fa-solid fa-cart-shopping\"></i>\r\n            </div>\r\n            <span>$ ");
#nullable restore
#line 18 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            <div class=""star-icon"">
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star""></i>
                <i class=""fa-solid fa-star-half-stroke""></i>
                <i class=""fa-regular fa-star""></i>
            </div>
        </div>
    </div>
");
#nullable restore
#line 28 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Embryo(Front-ToBack)\Embryo(Front-ToBack)\Views\Shared\_AccessoriesPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Accessories>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
