#pragma checksum "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61ed951cc2353e228b527f9ea2256176ca337aa7"
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
#line 2 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vendas")]
    public partial class Vendas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.OpenComponent<MudBlazor.MudGrid>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(3);
                __builder2.AddAttribute(4, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                     6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                            4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                   4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDatePicker>(8);
                    __builder3.AddAttribute(9, "Label", "Data inicial");
                    __builder3.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                                                         Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 8 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                                            date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => date = __value, date))));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudItem>(14);
                __builder2.AddAttribute(15, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                     6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                            4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                   4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDatePicker>(19);
                    __builder3.AddAttribute(20, "Label", "Data final");
                    __builder3.AddAttribute(21, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                                                                       Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Placeholder", "Select Date");
                    __builder3.AddAttribute(24, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 11 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                                                          date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => date = __value, date))));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<MudBlazor.MudButton>(27);
            __builder.AddAttribute(28, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 15 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                               Color.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Buscar");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.AddMarkupContent(33, "<div class=\"row mt-3\"><div style=\"font-size: 12px; width: 200px; margin: 0 auto; text-align: center; color: green;\">R$ <label style=\"font-size: 20px; font-weight: 500; color: green;\">512,00</label></div></div>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudSimpleTable>(34);
            __builder.AddAttribute(35, "Style", "overflow-x: auto;");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(37, "thead");
                __builder2.OpenElement(38, "tr");
#nullable restore
#line 26 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
             foreach (var h in headings)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(39, "th");
                __builder2.AddContent(40, 
#nullable restore
#line 28 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                     h

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 29 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "tbody");
#nullable restore
#line 33 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
         foreach (var row in rows)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(43, "tr");
#nullable restore
#line 36 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                 foreach (var x in row.Split())
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 38 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                         x

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 41 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n<br>\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(47);
            __builder.AddAttribute(48, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 45 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 45 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
                                           Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, "PDF");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Treinee\LaBrasa\Labrasa\Client\Pages\Gerencia\Vendas.razor"
       
    MudDatePicker _picker;
    DateTime? date = DateTime.Today;
    private bool autoClose;

    string[] headings = { "ID", "Data", "Valor" };
    string[] rows = {
        @"1 30/11/2021 R$84,00",
        @"2 30/11/2021 R$55,00",
        @"3 30/11/2021 R$102,00",
        @"4 30/11/2021 R$25,00",
        @"5 30/11/2021 R$65,00",
        @"6 30/11/2021 R$90,00",
    };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591