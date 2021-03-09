#pragma checksum "C:\Data\repos\Public\OdeToFood.Blue\OdeToFood.Blue\OdeToFood.Blue.App\Pages\Restaurants\ClientRestaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bfedda78b7804a2096423b991fe7723463fdeef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Blue.App.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), @"mvc.1.0.razor-page", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
namespace OdeToFood.Blue.App.Pages.Restaurants
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
#line 1 "C:\Data\repos\Public\OdeToFood.Blue\OdeToFood.Blue\OdeToFood.Blue.App\Pages\_ViewImports.cshtml"
using OdeToFood.Blue.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfedda78b7804a2096423b991fe7723463fdeef", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded9e8d46578635fc99bfee832416d183a3199d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_ClientRestaurants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Data\repos\Public\OdeToFood.Blue\OdeToFood.Blue\OdeToFood.Blue.App\Pages\Restaurants\ClientRestaurants.cshtml"
  
    ViewData["Title"] = "ClientRestaurants";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Client Restaurants</h2>\r\n\r\n<table class=\"table\" id=\"restaurants\">\r\n\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/bs4/dt-1.10.24/datatables.min.css"" />

    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/bs4/dt-1.10.24/datatables.min.js""></script>

    <script>
        const cuisine = [""Unknown"", ""Mexican"", ""Italian"", ""Indian""];
        $(() => $.ajax(""/Api/restaurants/"",
            { method: ""get"" }).then(response => {
                $(""#restaurants"").dataTable({
                    data: response,
                    columns: [
                        { ""data"": ""name"" },
                        { ""data"": ""location"" },
                        { ""data"": ""cuisine"", ""render"": data => cuisine[data]}
                    ]
                })
            }));
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Blue.App.Pages.Restaurants.ClientRestaurantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Blue.App.Pages.Restaurants.ClientRestaurantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Blue.App.Pages.Restaurants.ClientRestaurantsModel>)PageContext?.ViewData;
        public OdeToFood.Blue.App.Pages.Restaurants.ClientRestaurantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
