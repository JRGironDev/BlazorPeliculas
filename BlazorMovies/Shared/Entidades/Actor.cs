﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.Entidades
{
    public class Actor
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        public string? Biografia { get; set; }

        public string? Foto { get; set; }

        public DateTime? FechaNacimiento { get; set; }
    }
}
