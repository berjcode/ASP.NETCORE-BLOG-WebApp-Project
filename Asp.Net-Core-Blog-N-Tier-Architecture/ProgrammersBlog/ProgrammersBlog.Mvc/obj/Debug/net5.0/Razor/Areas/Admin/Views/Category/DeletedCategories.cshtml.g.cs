#pragma checksum "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58a3bd434da0dcb984c2a4176a669a7e0b4fdd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_DeletedCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/DeletedCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58a3bd434da0dcb984c2a4176a669a7e0b4fdd5", @"/Areas/Admin/Views/Category/DeletedCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_DeletedCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.CategoryListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/deletedCategories.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Silinmiş Kategoriler";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div id=""modalPlaceHolder"" aria-hidden=""true""></div>
    <div class=""card mb-4 mt-2"">
                            <div class=""card-header"">
                                <i class=""fas fa-table mr-1""></i>
                           Silinmiş Kategoriler     Kategoriler
                            </div>
        <div class=""card-body"">
            <div class=""spinner-border"" role=""status"" style=""display: none;"">
                <span class=""sr-only"">Yükleniyor...</span>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                    <tr>
                        <th>ID</th>
                        <th>Adı</th>
                        <th>Açıklaması</th>
                        <th>Aktif Mi?</th>
                        <th>Silinmiş Mi?</th>
                        <th>Not</th>
                        <th>Oluşturulma Tarihi</th>
          ");
            WriteLiteral(@"              <th>Oluşturan Kullanıcı Adı</th>
                        <th>Son Düzenlenme Tarihi</th>
                        <th>Son Düzenleyen Kullanıcı Adı</th>
                        <th>İşlemler</th>
                    </tr>
                    </thead>
                    <tfoot>
                    <tr>
                        <th>ID</th>
                        <th>Adı</th>
                        <th>Açıklaması</th>
                        <th>Aktif Mi?</th>
                        <th>Silinmiş Mi?</th>
                        <th>Not</th>
                        <th>Oluşturulma Tarihi</th>
                        <th>Oluşturan Kullanıcı Adı</th>
                        <th>Son Düzenlenme Tarihi</th>
                        <th>Son Düzenleyen Kullanıcı Adı</th>
                        <th>İşlemler</th>
                    </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 51 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                     foreach (var category in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("name", " name=\"", 2202, "\"", 2221, 1);
#nullable restore
#line 53 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
WriteAttributeValue("", 2209, category.Id, 2209, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                           Write(category.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <button class=\"btn btn-warning btn-sm btn-undo\" data-id=\"");
#nullable restore
#line 65 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                                                                                    Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-undo\"></span></button>\r\n                                <button class=\"btn btn-danger btn-sm btn-delete\" data-id=\"");
#nullable restore
#line 66 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                                                                                     Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span></button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\abdbl\Desktop\projeAdi\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\DeletedCategories.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n     </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58a3bd434da0dcb984c2a4176a669a7e0b4fdd512234", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n \r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.CategoryListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
