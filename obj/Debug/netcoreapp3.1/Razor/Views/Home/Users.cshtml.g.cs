#pragma checksum "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8945c217a2cc8f97e60142bdfe927cb67454f157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/Home/Users.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8945c217a2cc8f97e60142bdfe927cb67454f157", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Individual>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/Home/Users.cshtml"
 foreach(var ind in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"text-align: center;\">");
#nullable restore
#line 6 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/Home/Users.cshtml"
                              Write(ind.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/Home/Users.cshtml"
                                             Write(ind.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 7 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/ViewModelFun/Views/Home/Users.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Individual>> Html { get; private set; }
    }
}
#pragma warning restore 1591