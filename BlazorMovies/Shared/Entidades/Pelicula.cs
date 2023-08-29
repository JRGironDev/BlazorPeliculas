﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Titulo { get; set; } = null!;
        public string? Resumen { get; set; }
        public bool EnCartelera { get; set; }
        public string? Trailer { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public string? Poster { get; set; }
        public List<GeneroPelicula> GenerosPeliculas { get; set; } = new List<GeneroPelicula>();
        public List<PeliculaActor> PeliculasActor { get; set; } = new List<PeliculaActor>();
        public string? TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }
                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
    }
}
