#pragma checksum "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3fde2ad861dd318b79a57637a6f3d31128975d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\_ViewImports.cshtml"
using DavidsList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\_ViewImports.cshtml"
using DavidsList.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\_ViewImports.cshtml"
using DavidsList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\_ViewImports.cshtml"
using DavidsList.Data.DbModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\_ViewImports.cshtml"
using DavidsList.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3fde2ad861dd318b79a57637a6f3d31128975d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad576ca9cfcfc963f8ebc96878382875907a1adb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome <b>");
#nullable restore
#line 6 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\Home\Index.cshtml"
                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> to David\'s List</h1>\r\n        <h2>Your best source for all things movies!</h2>\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
        <h1 class=""display-4"">Welcome <b>Guest</b> to David's List</h1>
        <h2>Your best source for all things movies!</h2>
        <h3>Please <a href=""/User/Login""><b>Log in</b></a> or <a href=""/User/Register""><b>Register</b></a> to access our full list of features.</h3>
    </div>
");
#nullable restore
#line 17 "C:\Users\andic\source\repos\DavidsList\DavidsList\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
