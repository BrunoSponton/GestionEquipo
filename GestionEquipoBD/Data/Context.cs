using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data.Entity;

namespace Proyecto2024.BD.Data
{
    public class Context : DbContext
    {
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Entrenamiento> Entrenamientos { get; set; }
        public DbSet<EstPartido> EstPartidos { get; set; }
        public DbSet<AsistEntrenamiento> AsistEntrenamientos { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}

