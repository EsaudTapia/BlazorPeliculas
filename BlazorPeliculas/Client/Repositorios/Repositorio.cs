using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>(){
    new Pelicula() { Titulo= "Spiderman 1", Lanzamiento = new DateTime(2021,11,02)},
    new Pelicula() { Titulo= "Spiderman 2", Lanzamiento = new DateTime(2021,11,02)},
    new Pelicula() { Titulo= "Spiderman 3", Lanzamiento = new DateTime(2021,11,02)}

        };
              
        }
    }
}


