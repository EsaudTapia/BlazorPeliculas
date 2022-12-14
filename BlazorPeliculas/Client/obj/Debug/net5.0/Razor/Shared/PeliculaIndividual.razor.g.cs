#pragma checksum "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d31fe80523e95fde219c637c3c1fd2b6e46ac931"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n         Titulo :");
            __builder.OpenElement(3, "b");
#nullable restore
#line 3 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
__builder.AddContent(4, pelicula.Titulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n   \r\n        ");
            __builder.OpenElement(6, "p");
            __builder.AddMarkupContent(7, "\r\n        Fecha: ");
            __builder.OpenElement(8, "b");
#nullable restore
#line 7 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
__builder.AddContent(9, pelicula.Lanzamiento.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
#nullable restore
#line 11 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
         if (MostrarBotones) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
                                ()=>EliminarPelicula.InvokeAsync(pelicula)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Borrar");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
       
    [Parameter] public Pelicula pelicula { get; set; }
    [Parameter] public bool MostrarBotones { get; set; } = false;
    [Parameter] public EventCallback<Pelicula> EliminarPelicula { get; set; }
   


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
