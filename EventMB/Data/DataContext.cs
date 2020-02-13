using Microsoft.EntityFrameworkCore;
using EventMB.Models;


namespace EventMB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Evento> Eventos {get;set;}
        public DbSet<Ingresso> Ingressos {get;set;}

    }

}