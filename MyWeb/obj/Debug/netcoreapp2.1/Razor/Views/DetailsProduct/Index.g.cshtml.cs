#pragma checksum "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bda97d41ce170ecc42ef09e085e8e0c957ebc91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetailsProduct_Index), @"mvc.1.0.view", @"/Views/DetailsProduct/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DetailsProduct/Index.cshtml", typeof(AspNetCore.Views_DetailsProduct_Index))]
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
#line 1 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\_ViewImports.cshtml"
using MyWeb;

#line default
#line hidden
#line 2 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\_ViewImports.cshtml"
using MyWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bda97d41ce170ecc42ef09e085e8e0c957ebc91", @"/Views/DetailsProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4221c565102d6b4904ec52217f6417507a218be", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailsProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWeb.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main_btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 620, true);
            WriteLiteral(@"

<!--================Single Product Area =================-->
<div class=""product_image_area"">
    <div class=""container"">
        <div class=""row s_product_inner"">
            <div class=""col-lg-6"">
                <div class=""s_product_img"">
                    <div id=""carouselExampleIndicators""
                         class=""carousel slide""
                         data-ride=""carousel"">
                        <ol class=""carousel-indicators""></ol>
                        <div class=""carousel-inner"">
                            <div class=""carousel-item active"">
                                ");
            EndContext();
            BeginContext(739, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99056559c97242f185d1098587e56fb5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 809, "~/images/avatar/", 809, 16, true);
#line 22 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml"
AddHtmlAttributeValue("", 825, Html.DisplayFor(model => model.Image), 825, 38, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(923, 262, true);
            WriteLiteral(@"
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-5 offset-lg-1"">
                <div class=""s_product_text"">
                    <h3>");
            EndContext();
            BeginContext(1186, 43, false);
#line 32 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml"
                   Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 31, true);
            WriteLiteral("</h3>\r\n                    <h2>");
            EndContext();
            BeginContext(1261, 38, false);
#line 33 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml"
                   Write(string.Format("{0:0,00}", Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 191, true);
            WriteLiteral(" đ</h2>\r\n                    <ul class=\"list\">\r\n                        <li>\r\n                            <a class=\"active\" href=\"#\">\r\n                                <span>Category</span> : ");
            EndContext();
            BeginContext(1491, 53, false);
#line 37 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml"
                                                   Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 212, true);
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                   \r\n                    <br />\r\n                    <div class=\"card_area\">\r\n                        ");
            EndContext();
            BeginContext(1756, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "594abe6480c9434591d41ad7bfa0a61e", async() => {
                BeginContext(1847, 12, true);
                WriteLiteral("Add to Cart ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\ASUS-VivoBook\Documents\Visual Studio 2017\Projects\ProjectSem3\MyWeb\Views\DetailsProduct\Index.cshtml"
                                                                                     WriteLiteral(Model.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1863, 482, true);
            WriteLiteral(@"
                        <a class=""icon_btn"" href=""#"">
                            <i class=""lnr lnr lnr-diamond""></i>
                        </a>
                        <a class=""icon_btn"" href=""#"">
                            <i class=""lnr lnr lnr-heart""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--================End Single Product Area =================-->
<br />
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWeb.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
