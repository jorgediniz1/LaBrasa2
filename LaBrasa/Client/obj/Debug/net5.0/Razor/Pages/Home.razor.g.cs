#pragma checksum "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196a4ef5c9084e023f01160070717c3f101cef2e"
// <auto-generated/>
#pragma warning disable 1591
namespace LaBrasa.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using LaBrasa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using LaBrasa.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Treinee\LaBrasa\Labrasa\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .input-group-text {
        width: 80px;
    }

    .top {
        background-color: red;
        margin-left: -50px;
        margin-right: -50px;
        height: 200px;
        margin-bottom: 32px;
    }

    .max {
        min-width: 300px;
        max-width: 600px;
        margin: 0 auto;
    }

    .btn {
        border-radius: 0;
        width: 300px;
        margin-top: 32px;
    }

    img {
        width: 150px;
        margin: 0 auto;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<div class=""container-fluid""><div><div class=""row top""><img src=""assets/labrasalogo.png""></div>

        <div class=""row""><button class=""btn btn-danger col-12"">PRODUTOS</button></div>

        <div class=""row""><button class=""btn btn-danger col-12"">FUNCIONARIOS</button></div>

        <div class=""row""><button class=""btn btn-danger col-12"">VENDAS</button></div>

        <div class=""row""><button class=""btn btn-danger col-12"">CONTAS</button></div>

        <div class=""row""><button class=""btn btn-danger col-12"">DASHBOARD</button></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
