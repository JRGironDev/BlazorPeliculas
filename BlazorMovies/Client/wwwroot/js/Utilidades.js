function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Contador desde javascript: " + resultado);
        });
}

function pruebaPuntoNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}