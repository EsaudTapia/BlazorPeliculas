#pragma checksum "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d318920a026a37cfa38e17ff832f744a94108db8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Single count:");
#nullable restore
#line 5 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
__builder.AddContent(2, singleton.Valor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Hola, ");
#nullable restore
#line 7 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
__builder.AddContent(6, UtilidadesString.Enmayuscular(nombre));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "Vamos a sumar 2  + 2 = ");
#nullable restore
#line 8 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
__builder.AddContent(10, 2+2);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "<h3>pelicula</h3>\r\n  ");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.ListadoPeliculas>(14);
            __builder.AddAttribute(15, "Peliculas", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculas.Shared.Entidades.Pelicula>>(
#nullable restore
#line 13 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
                               peliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.OpenElement(18, "h2");
            __builder.AddMarkupContent(19, "\r\n        crear pelicula\r\n        ");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.EjemploTextBox>(20);
            __builder.AddMultipleAttributes(21, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 21 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
                                       new Dictionary<string,object>()
{
        {"placeholder","gokuuuuu"},
        {"disabled","true"}
}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
                  AgregarPelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "click");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Index.razor"
       
    void AgregarPelicula()
    {
        peliculas.Add(new Pelicula() { Titulo = "shrek", Lanzamiento = DateTime.Today });
    }



    string nombre = "Felipe";
    
    private List<Pelicula> peliculas ;
    protected override void OnInitialized()
    {
        
        peliculas = repositorio.ObtenerPeliculas();
    }
    
 
    public Pelicula Spiderman { get { return ObtenerPelicula(); } }

    private Pelicula ObtenerPelicula() {
        return new Pelicula() { Titulo = "Spiderman", Lanzamiento = new DateTime(2019, 7, 2) };
    }

  

    //string Enmayuscular(string valor) => valor.ToUpper();
    private void manejarClick()
    {
        Console.WriteLine("me clic desde metodo!");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiciosSingleton singleton { get; set; }
    }
}
#pragma warning restore 1591
