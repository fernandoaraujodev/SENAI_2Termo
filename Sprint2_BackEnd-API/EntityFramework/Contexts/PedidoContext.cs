using EntityFramework.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Contexts
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidosItens { get; set; }

        // sobreescrevendo para conectar ao SQL Server, sem precisar instanciar 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DA6MBAT\SQLEXPRESS;Initial Catalog=DbSenai;User ID=sa;Password=ps132");
                
                base.OnConfiguring(optionsBuilder);
        }
    }
}
