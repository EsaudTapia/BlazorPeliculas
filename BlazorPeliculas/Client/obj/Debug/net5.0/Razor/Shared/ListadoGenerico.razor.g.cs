#pragma checksum "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c70cbca18487029108b576ee9b5b1fdb5c763a"
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
    public partial class ListadoGenerico<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
 if(Listado==null){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     if (Cargando == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "cargando...");
#nullable restore
#line 7 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
__builder.AddContent(1, Cargando);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     
}else if(Listado.Count==0){
    if (NoHayRegistros == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros para mostrar ...");
#nullable restore
#line 16 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                                      
    }

    else
    {
        
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
__builder.AddContent(3, NoHayRegistros);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                       
    }
}else{
    foreach(var elemento in Listado)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
__builder.AddContent(4, HayRegistros(elemento));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                               
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\franc\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> HayRegistros { get; set; }
    [Parameter] public List<Titem> Listado { get; set;}     

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
