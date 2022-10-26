using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServiciosSingleton singleton { get; set; }
        [Inject] ServiciosTransient transient { get; set; }

        //hacemos clase parcial para divir 
        private int currentCount = 0;

        private void IncrementCount()
        {
            
            currentCount++;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;
        }
    }
}
