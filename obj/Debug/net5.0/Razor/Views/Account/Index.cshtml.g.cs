#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edbbd17cfb8f4900a28f5533999bc1eccaf44b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 5 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edbbd17cfb8f4900a28f5533999bc1eccaf44b6", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Authentication with Identity</h2>\r\n<hr />\r\n");
#nullable restore
#line 9 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Hello ");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n");
#nullable restore
#line 12 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
     using (Html.BeginForm("LogOff", "Account"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-default\" value=\"Log out\" />\r\n");
#nullable restore
#line 15 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 19 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
  Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 20 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
  Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 21 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 22 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Account\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
