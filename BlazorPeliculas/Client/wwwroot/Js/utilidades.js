function pruebaPuntoNetStatic() {

    DotNet.invokeMethodAsync('BlazorPeliculas.Client', 'ObtenerCurrentCount')
        .then(data => {

            console.log("conteo desde javascript " + data);
        });

}


function pruebaPuntoNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync('IncrementCount');
}