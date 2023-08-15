using BlazorMovies.Shared.Entidades;

namespace BlazorMovies.Client.Repositorios
{
    public class Repositorio: IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula{Titulo = "Wakanda Forever", FechaLanzamiento = new DateTime(2023,07,20), Poster ="https://th.bing.com/th/id/OIP.BVdcDqFECNsi9Kwzh1oMewAAAA?pid=ImgDet&rs=1"},
                new Pelicula{Titulo = "Moana", FechaLanzamiento = new DateTime(2016,11,23), Poster="https://th.bing.com/th/id/R.5f57a69bcce774e7f7fcdedd7877fb3b?rik=9%2fB4LIl6ItEwFA&pid=ImgRaw&r=0" },
                new Pelicula{Titulo = "Inception", FechaLanzamiento = new DateTime(2010,7,16), Poster="https://th.bing.com/th/id/OIP.vnJImFIy1GEoBBAjyZ-tfQHaK-?pid=ImgDet&rs=1" },
            };
        }
    }
}
