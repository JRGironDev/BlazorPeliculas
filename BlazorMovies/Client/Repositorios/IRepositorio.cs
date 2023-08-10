using BlazorMovies.Shared.Entidades;

namespace BlazorMovies.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
