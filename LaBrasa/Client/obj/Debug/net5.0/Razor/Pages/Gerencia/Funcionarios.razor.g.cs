#pragma checksum "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830664eccd8425e1c8099f77d0bf07294b167198"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/funcionarios")]
    public partial class Funcionarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Funcionarios</h3>\r\n\r\n");
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
</style>");
#nullable restore
#line 25 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
 if (visibilidadePainel)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group");
            __builder.AddMarkupContent(4, "<input class=\"form-control\" placeholder=\"Pesquisar...\">\r\n        ");
            __builder.AddMarkupContent(5, "<button class=\"btn btn-danger\" style=\"border-radius: 0!important\"><i class=\"oi oi-magnifying-glass\"></i></button>\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "style", "margin-left: 25px;");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
                                                                             alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "list-group mt-3");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "list-group-item");
            __builder.AddMarkupContent(15, "\r\n            Gabriel Fernando Aguinel\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "float");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.OpenElement(20, "i");
            __builder.AddAttribute(21, "class", "oi oi-pencil");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
                                                                                  EditarFuncionario

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "list-group-item");
            __builder.AddMarkupContent(26, "\r\n            Juliano Marques Figueiredo\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "float");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.OpenElement(31, "i");
            __builder.AddAttribute(32, "class", "oi oi-pencil");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
                                                                                 EditarFuncionario

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "list-group-item");
            __builder.AddMarkupContent(37, "\r\n            Morbi leo risus\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "float");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.OpenElement(42, "i");
            __builder.AddAttribute(43, "class", "oi oi-pencil");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
                                                                                 EditarFuncionario

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "list-group-item");
            __builder.AddMarkupContent(48, "\r\n            Porta ac consectetur ac\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "float");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.OpenElement(53, "i");
            __builder.AddAttribute(54, "class", "oi oi-pencil");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
                                                                                 EditarFuncionario

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
 if (visibilidadeForm)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "div");
            __builder.AddContent(57, 
#nullable restore
#line 66 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
         tituloForm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "form");
            __builder.AddMarkupContent(60, @"<div class=""row""><div class=""form-group col-8""><label for=""exampleInputEmail1"">Nome</label>
                <input type=""text"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Nome""></div>
            <div class=""form-group col-4""><label for=""exampleInputEmail1"">Id</label>
                <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Id""></div></div>

        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group col-12");
            __builder.AddMarkupContent(65, "<label for=\"exampleFormControlSelect1\">Departamento</label>\r\n                ");
            __builder.OpenElement(66, "select");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "id", "exampleFormControlSelect1");
            __builder.OpenElement(69, "option");
            __builder.AddContent(70, "Gerencia");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "option");
            __builder.AddContent(73, "Atendimento");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "option");
            __builder.AddMarkupContent(76, "Produ????o");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row");
            __builder.AddMarkupContent(80, "<div class=\"form-group col-4\"><label for=\"exampleInputEmail1\">CPF</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"cpf\"></div>\r\n\r\n            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "form-group col-4");
            __builder.AddMarkupContent(83, "<label for=\"exampleFormControlSelect1\">Sexo</label>\r\n                ");
            __builder.OpenElement(84, "select");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "id", "exampleFormControlSelect1");
            __builder.OpenElement(87, "option");
            __builder.AddContent(88, "Masculino");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "option");
            __builder.AddContent(91, "Feminino");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "option");
            __builder.AddContent(94, "Outro");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n            ");
            __builder.AddMarkupContent(96, "<div class=\"form-group col-4\"><label for=\"exampleInputEmail1\">Telefone</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"() XXXXX-XXXX\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n        ");
            __builder.AddMarkupContent(98, "<div class=\"row\"><div class=\"form-group col-12\"><label for=\"exampleInputEmail1\">Endere??o</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"exampleInputEmail1\"></div></div>");
            __builder.AddMarkupContent(99, "<div class=\"row\"><div class=\"form-group col-12\"><label for=\"exampleInputEmail1\">Email</label>\r\n                <input type=\"email\" class=\"form-control\" id=\"exampleInputEmail1\"></div></div>\r\n\r\n        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row");
            __builder.AddMarkupContent(102, "<button type=\"submit\" class=\"btn btn-danger col-6\">Incluir</button>\r\n            ");
            __builder.OpenElement(103, "button");
            __builder.AddAttribute(104, "class", "btn btn-light col-6");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
                                                          alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(106, "Voltar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Funcionarios.razor"
       
    string tituloForm;
    bool visibilidadePainel = true;
    bool visibilidadeForm = false;

    private void alterarVisibilidade()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Novo Funcionario";
    }

    private void EditarFuncionario()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Editar Funcionario";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
