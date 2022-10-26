using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServiciosSingleton singleton { get; set; }
        [Inject] ServiciosTransient transient { get; set; }
        [Inject] IJSRuntime js { get; set; }
        //hacemos clase parcial para divir 
        protected int currentCount = 0;
        static int currentCountStatic = 0;

        IJSObjectReference modulo;


        [JSInvokable]
        public async Task IncrementCount()
        {
            modulo = await js.InvokeAsync<IJSObjectReference>("import", "./js/CounterJs.js");
            await modulo.InvokeVoidAsync("mostrarAlerta","matenmeeeeee");
            currentCount++;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;
            currentCountStatic++;
            await js.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        [JSInvokable]
        protected async Task IncrementCountJS()
        {
            await js.InvokeVoidAsync("pruebaPuntoNetInstancia",
                DotNetObjectReference.Create(this));
        }

        
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);

        }
    }
}
