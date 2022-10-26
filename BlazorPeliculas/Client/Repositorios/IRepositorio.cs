using BlazorPeliculas.Shared.Entidades;
using System.Collections.Generic;

namespace BlazorPeliculas.Client.Repositorios
{
    public interface IRepositorio
    {
        //interfaz sirve para definir
        //los metodos que obligatoriamente se van a
        //utilizar en el repositorio
        //y que se van a implementar
        //en la clase que herede de
        //esta interfaz
        
        List<Pelicula> ObtenerPeliculas();
        
        
    }
}
