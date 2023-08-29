﻿using BlazorMovies.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovies.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GeneroPelicula>().HasKey(x => new { x.GeneroId, x.PeliculaId });
        }

        public DbSet<Genero> Generos => Set<Genero>();

        public DbSet<Actor> Actores => Set<Actor>();

        public DbSet<Pelicula> Peliculas => Set<Pelicula>();

        public DbSet<GeneroPelicula> GenerosPeliculas => Set<GeneroPelicula>();


    }
}
