#pragma checksum "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\User\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684e6a4bf00664b157a9e16d8d27d9d555b65e6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_User), @"mvc.1.0.view", @"/Views/User/User.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/User.cshtml", typeof(AspNetCore.Views_User_User))]
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
#line 1 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 1 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\User\User.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684e6a4bf00664b157a9e16d8d27d9d555b65e6e", @"/Views/User/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_User_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 32, true);
            WriteLiteral("\r\n<h3>Here is a user!</h3>\r\n<h1>");
            EndContext();
            BeginContext(74, 15, false);
#line 5 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\User\User.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(89, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(91, 14, false);
#line 5 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\User\User.cshtml"
                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(105, 5, true);
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591