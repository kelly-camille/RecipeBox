#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d676b82ceb6b94549693b656bac2fd10aafde64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Create), @"mvc.1.0.view", @"/Views/Recipes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d676b82ceb6b94549693b656bac2fd10aafde64", @"/Views/Recipes/Create.cshtml")]
    public class Views_Recipes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h4>Add a new recipe</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.RecipeName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.RecipeName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.Instructions));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.Instructions));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.Ingredients));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.Ingredients));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.LabelFor(model => model.Rating));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.TextBoxFor(model => model.Rating));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.Label("Select tag"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new item\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 29 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 30 "C:\Users\kelly\OneDrive\Desktop\Recipe-Box.Solution\RecipeBox\Views\Recipes\Create.cshtml"
Write(Html.ActionLink("Show all recipes", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
