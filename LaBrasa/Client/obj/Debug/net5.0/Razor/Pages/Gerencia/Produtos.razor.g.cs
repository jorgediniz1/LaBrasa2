#pragma checksum "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3719fd93e94c41f3808a1ac0f36d1a980f0d225"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 2 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
using LaBrasa.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produtos")]
    public partial class Produtos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Produtos</h3>\r\n");
            __builder.AddMarkupContent(1, @"<style>
    .btn {
        border-radius: 0;
    }

    .btn-danger {

    }

    .btn-primary, .btn-success {
       
    }

    .float {
        position: absolute;
        right: 0;
        margin-right: 10px;
        top: 0;
        margin-top: 5px;
    }
</style>

");
            __builder.OpenElement(2, "div");
#nullable restore
#line 29 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
     if (visibilidadePainel)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group");
            __builder.AddMarkupContent(5, "<input class=\"form-control\" placeholder=\"Pesquisar...\">\r\n            ");
            __builder.AddMarkupContent(6, "<button class=\"btn btn-danger\" style=\"border-radius: 0!important\"><i class=\"oi oi-magnifying-glass\"></i></button>\r\n            ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-success");
            __builder.AddAttribute(9, "style", "margin-left: 25px;");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
                                                                                 alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "list-group mt-3");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "list-group-item");
            __builder.AddMarkupContent(16, "\r\n                Espeto de jacaré ");
            __builder.AddMarkupContent(17, "<b>R$50,00</b>\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "float");
            __builder.AddMarkupContent(20, "<button class=\"btn btn-danger\">X</button> ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
                                                                                                        EditarProduto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, "<li class=\"list-group-item\">Dapibus ac facilisis in</li>\r\n            ");
            __builder.AddMarkupContent(27, "<li class=\"list-group-item\">Morbi leo risus</li>\r\n            ");
            __builder.AddMarkupContent(28, "<li class=\"list-group-item\">Porta ac consectetur ac</li>\r\n            ");
            __builder.AddMarkupContent(29, "<li class=\"list-group-item\">Vestibulum at eros</li>");
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
     if (visibilidadeForm)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddContent(31, 
#nullable restore
#line 56 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
             tituloForm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "form");
            __builder.AddMarkupContent(34, @"<div class=""row""><div class=""form-group col-8""><label for=""exampleInputEmail1"">Nome</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Nome""></div>
                <div class=""form-group col-4""><label for=""exampleInputEmail1"">Id</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Id""></div></div>

            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group col-12");
            __builder.AddMarkupContent(39, "<label for=\"exampleFormControlSelect1\">Categoria</label>\r\n                    ");
            __builder.OpenElement(40, "select");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "id", "exampleFormControlSelect1");
            __builder.OpenElement(43, "option");
            __builder.AddContent(44, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "option");
            __builder.AddContent(47, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "option");
            __builder.AddContent(50, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "option");
            __builder.AddContent(53, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "option");
            __builder.AddContent(56, "5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n            ");
            __builder.AddMarkupContent(58, @"<div class=""row""><div class=""form-group col-6""><label for=""exampleInputEmail1"">Preço Custo</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Nome""></div>
                <div class=""form-group col-6""><label for=""exampleInputEmail1"">Preço Venda</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Id""></div></div>

            ");
            __builder.AddMarkupContent(59, @"<div class=""row""><div class=""form-group col-4""><label for=""exampleInputEmail1"">Qtd Minima</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1""></div>
                <div class=""form-group col-4""><label for=""exampleInputEmail1"">Estoque</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1""></div>
                <div class=""form-group col-4""><label for=""exampleInputEmail1"">A adicionar</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1""></div></div>

            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.AddMarkupContent(62, "<button type=\"submit\" class=\"btn btn-danger col-6\">Submit</button>\r\n                ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "btn btn-light col-6");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
                                                              alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Voltar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 114 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Produtos.razor"
       
    //private WeatherForecast[] forecasts;

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    //}
    string tituloForm;
    bool visibilidadePainel = true;
    bool visibilidadeForm = false;

    private void alterarVisibilidade()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Novo Produto";
    }

    private void EditarProduto()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Editar Produto";
    }

    public void deletarPessoa()
        {
          
        }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
