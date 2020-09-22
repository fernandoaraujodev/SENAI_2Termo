using Jogame.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Contexts
{
    public class JogoContext : DbContext
    {
        //CodeFirst
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<JogoJogador> JogosJogadores { get; set; }

        // Conectando com meu banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DA6MBAT\SQLEXPRESS;Initial Catalog=Jogame;User ID=sa;Password=ps132");
        }
    }
}
