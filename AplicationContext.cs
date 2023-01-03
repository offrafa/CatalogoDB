using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CasaDoCodigo
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);

            ModelBuilder.Entity<Produto>().HasKey(t => t.Id);

            ModelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            ModelBuilder.Entity<Pedido>().HasMany(t => t.Itens).WithOne(t => t.Pedido);
            ModelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido).IsRequired();

            ModelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
            ModelBuilder.Entity<ItemPedido>().HasOne(t => t.Pedido);
            ModelBuilder.Entity<ItemPedido>().HasOne(t => t.Produto);

            ModelBuilder.Entity<Cadastro>().HasKey(t => t.Id);
            ModelBuilder.Entity<Cadastro>().HasOne(t => t.Pedido);

        }
    }
}
