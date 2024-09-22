using AT1._10_dotnetweb.Models;
using Microsoft.EntityFrameworkCore;

namespace AT1._10_dotnetweb.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base (options) { }
        
        public DbSet<Produto> Produtos { get; set; }
    }
}
