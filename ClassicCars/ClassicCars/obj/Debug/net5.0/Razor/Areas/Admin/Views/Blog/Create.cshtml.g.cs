#pragma checksum "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd4fdb278b0769bd1f2ba85cb91c317bbe48e08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd4fdb278b0769bd1f2ba85cb91c317bbe48e08", @"/Areas/Admin/Views/Blog/Create.cshtml")]
    public class Areas_Admin_Views_Blog_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassicCars.Data.Entities.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
  
    Layout = "/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Blog Ekle</h2>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        ");
#nullable restore
#line 16 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
       Write(Html.LabelFor(model => model.Title, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
       Write(Html.LabelFor(model => model.Description, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
           Write(Html.TextAreaFor(model => model.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
       Write(Html.LabelFor(model => model.Tumbnail, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Tumbnail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tumbnail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <a href=""Admin/Blog/Index"">
                    <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                </a>
            </div>
        </div>


    </div>
");
#nullable restore
#line 48 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Create.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassicCars.Data.Entities.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591