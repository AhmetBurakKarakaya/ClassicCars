#pragma checksum "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb6f1163e46f9e791bce016a1766d7f0409349b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb6f1163e46f9e791bce016a1766d7f0409349b", @"/Areas/Admin/Views/Blog/Edit.cshtml")]
    public class Areas_Admin_Views_Blog_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassicCars.Data.Entities.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
  
    Layout = "/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Blog Güncelle</h2>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 18 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
   Write(Html.LabelFor(model => model.Title, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
   Write(Html.LabelFor(model => model.Description, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
       Write(Html.TextAreaFor(model => model.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 35 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
   Write(Html.LabelFor(model => model.Tumbnail, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Tumbnail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Tumbnail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
   Write(Html.LabelFor(model => model.IsActive, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\" style=\"margin-left: 2em!important\">\r\n                ");
#nullable restore
#line 45 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
           Write(Html.EditorFor(model => model.IsActive, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 50 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"
Write(Html.HiddenFor(model => model.createTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <a href=""Admin/Blog/Index"">
                <input type=""submit"" value=""Edit"" class=""btn btn-default"" />
            </a>
        </div>
    </div>


</div>
");
#nullable restore
#line 62 "C:\Users\karak\Desktop\ClassicCars\ClassicCars\ClassicCars\Areas\Admin\Views\Blog\Edit.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
