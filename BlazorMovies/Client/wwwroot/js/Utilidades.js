function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Contador desde javascript: " + resultado);
        });
}