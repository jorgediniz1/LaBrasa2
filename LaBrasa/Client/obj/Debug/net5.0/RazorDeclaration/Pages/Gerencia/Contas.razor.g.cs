// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaBrasa.Client.Pages.Gerencia
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/contas")]
    public partial class Contas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Contas.razor"
       

        MudDatePicker _picker;
        DateTime? date = DateTime.Today;
    private bool autoClose;

    string[] headings = { "Descrição", "Data Compra", "Data Vencimento", "Valor" };
    string[] rows = {
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
        @"HiperFrios 14/04/2021 14/05/2021 R$566,00",
    };

    string tituloForm;
    bool visibilidadePainel = true;
    bool visibilidadeForm = false;

    private void alterarVisibilidade()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Nova Conta";
    }

    private void EditarConta()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Editar Produto";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
