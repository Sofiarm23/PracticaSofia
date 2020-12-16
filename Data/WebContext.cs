using Microsoft.EntityFrameworkCore;
using PracticaSofia.Models;

namespace PracticaSofia.Data
{
    public class WebContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public WebContext(DbContextOptions dbo):base (dbo){}
    }
}