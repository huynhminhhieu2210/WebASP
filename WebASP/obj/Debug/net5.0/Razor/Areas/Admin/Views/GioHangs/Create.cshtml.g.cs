#pragma checksum "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\GioHangs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce45e23772c7663cd5e9dc8fe76ddc732e9d7463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GioHangs_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/GioHangs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce45e23772c7663cd5e9dc8fe76ddc732e9d7463", @"/Areas/Admin/Views/GioHangs/Create.cshtml")]
    public class Areas_Admin_Views_GioHangs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebASP.Models.GioHang>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAn_HK5_2021_2022\WebASP\WebASP\Areas\Admin\Views\GioHangs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>GioHang</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""TaiKhoanId"" class=""control-label""></label>
                <select asp-for=""TaiKhoanId"" class =""form-control"" asp-items=""ViewBag.TaiKhoanId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""SanPhamId"" class=""control-label""></label>
                <select asp-for=""SanPhamId"" class =""form-control"" asp-items=""ViewBag.SanPhamId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""SL"" class=""control-label""></label>
                <input asp-for=""SL"" class=""form-control"" />
                <span asp-validation-for=""SL"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=");
            WriteLiteral(@"""TongTien"" class=""control-label""></label>
                <input asp-for=""TongTien"" class=""form-control"" />
                <span asp-validation-for=""TongTien"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebASP.Models.GioHang> Html { get; private set; }
    }
}
#pragma warning restore 1591