#pragma checksum "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\Users\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f8deb3e54ff79777aa776e395ee74ed935593e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Users), @"mvc.1.0.view", @"/Views/Users/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Users.cshtml", typeof(AspNetCore.Views_Users_Users))]
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
#line 1 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\Users\Users.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f8deb3e54ff79777aa776e395ee74ed935593e", @"/Views/Users/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 39, true);
            WriteLiteral("\r\n<h3>Here are some users!</h3>\r\n<ul>\r\n");
            EndContext();
#line 6 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\Users\Users.cshtml"
     foreach(User user in Model)
    {

#line default
#line hidden
            BeginContext(127, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(140, 14, false);
#line 8 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\Users\Users.cshtml"
       Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(154, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(156, 13, false);
#line 8 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\Users\Users.cshtml"
                       Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(169, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "C:\Users\tkrec\Downloads\c#\ViewModelFun\Views\Users\Users.cshtml"
    }

#line default
#line hidden
            BeginContext(183, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
