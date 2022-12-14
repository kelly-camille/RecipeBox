#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77cc7679561b2de83f0d5d0a66a2da0269ac55c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Details), @"mvc.1.0.view", @"/Views/Tags/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77cc7679561b2de83f0d5d0a66a2da0269ac55c5", @"/Views/Tags/Details.cshtml")]
    public class Views_Tags_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Tag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2 class=\"text-center my-4\">Tags</h2>\r\n\r\n<hr />\r\n\r\n<h3>Name: ");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
     Write(Html.DisplayFor(model => model.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
 if (Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>This tag does not have any recipes</h3>\r\n");
#nullable restore
#line 16 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>Recipes this tag contains:</h3>\r\n  <ul>\r\n");
#nullable restore
#line 21 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 23 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
   Write(join.Recipe.RecipeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 26 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 28 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Back to Tags", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 29 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Edit Tag", "Edit", new { id = Model.TagId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 30 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Delete Tag", "Delete", new { id = Model.TagId }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Tag> Html { get; private set; }
    }
}
#pragma warning restore 1591
