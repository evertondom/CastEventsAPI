using EventsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.Data
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        public Context(DbContextOptions<Context> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ingresso>()
                .HasOne(ingresso => ingresso.Evento)
                .WithMany(evento => evento.Ingressos)
                .HasForeignKey(ingresso => ingresso.EventoId);
        }
    }
}
