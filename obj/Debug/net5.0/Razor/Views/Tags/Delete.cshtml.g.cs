#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31d5146168c154e6276cf97bd7c53245280ea786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Delete), @"mvc.1.0.view", @"/Views/Tags/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d5146168c154e6276cf97bd7c53245280ea786", @"/Views/Tags/Delete.cshtml")]
    public class Views_Tags_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Tag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Are you sure you want to delete this Tag</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Delete.cshtml"
Write(Html.ActionLink("Back", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Tag> Html { get; private set; }
    }
}
#pragma warning restore 1591
