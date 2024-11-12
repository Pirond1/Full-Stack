using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace InfraEstrutura
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
            //criar ou alterar o banco de dados
            this.Database.EnsureCreated();
        }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Endereco> endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //base.OnConfiguring(optionsBuilder);
            var stringConexao = @"Server=LAB10-14; 
                 DataBase=dbProvaFinal;integrated security=true; TrustServerCertificate=True;";
            // ALTERAR O SERVER DE ACORDO COM O PC QUE ESTÁ (Em casa -> PC-SMARTGAMER / Faculdade -> LAB10-14)

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(e => {
                //qtde maxima de caracteres
                e.Property(p => p.nome).HasMaxLength(50);
                e.Property(p => p.email).HasMaxLength(50);
            });


            modelBuilder.Entity<Endereco>(e => {
                //qtde maxima de caracteres
                e.Property(p => p.rua).HasMaxLength(50);
                e.Property(p => p.cidade).HasMaxLength(50);

                //relacionamento

                e.HasOne(p => p.cliente) //lado um
                    .WithMany(p => p.endereco) //lado muitos
                    .HasForeignKey(p => p.idCliente) //chave estrangeira
                    .HasConstraintName("fk_cliente_endereco") //nome relacionamento
                    .OnDelete(DeleteBehavior.NoAction);//comportamento delete

            });
        }
    }
}
