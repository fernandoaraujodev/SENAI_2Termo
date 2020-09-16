using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using API_DbFirst.Domains;

namespace API_DbFirst.Context
{
    public partial class PedidoContext : DbContext
    {
        public PedidoContext()
        {
        }

        public PedidoContext(DbContextOptions<PedidoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoItem> PedidoItem { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DA6MBAT\\SQLEXPRESS;Initial Catalog=curso;User ID=sa;Password=ps132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PedidoItem>(entity =>
            {
                entity.HasIndex(e => e.IdPedido);

                entity.HasIndex(e => e.IdProduto);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.PedidoItem)
                    .HasForeignKey(d => d.IdPedido);

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.PedidoItem)
                    .HasForeignKey(d => d.IdProduto);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
