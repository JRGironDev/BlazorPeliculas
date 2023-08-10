using BlazorMovies.Shared.Entidades;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            await js.InvokeVoidAsync("console.log", "prueba de console log");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
