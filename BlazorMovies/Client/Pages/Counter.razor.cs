using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Pages

{
    public partial class Counter
    {
        [Inject] ServicioSingleton singleton { get; set; } = null!;
        [Inject] ServicioTransient transient { get; set; } = null!;
        [Inject] IJSRuntime Js { get; set; } = null!;

        IJSObjectReference ?modulo;

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            modulo = await Js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("mostrarAlerta", "Hola desde Counter.razor");
            currentCount++;
            currentCountStatic = currentCount;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;
            await Js.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        private async Task IncrementCountJavaScript()
        {
            await Js.InvokeVoidAsync("pruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }

        [JSInvokable]  
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
