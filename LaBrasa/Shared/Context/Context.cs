using LaBrasa.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaBrasa.Shared.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt){ }

        public DbSet<Produto> Produtos { get; set; }
    }
}
