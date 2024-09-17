using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace InfraEstrutura.Contexto
{
    public class Contexto_Empresa: DbContext
    {
        public Contexto_Empresa() { 
            //criar ou alterar o banco de dados
            this.Database.EnsureCreated();
        }
        //quais entidades irão ser mapeadas como tabelas
        public DbSet<Produtos> produtos { get; set; }
        public DbSet<Categoria> categorias { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            var stringConexao = @"Server=LAB10-14;
            DataBase=dbEmpresa2025;integrated security=true; TrustServerCertificate=True;";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>(e => {
                //qtde maxima de caracteres
                e.Property(p=>p.descricao).HasMaxLength(150);
            
            });


            modelBuilder.Entity<Produtos>(e => {
                //qtde maxima de caracteres
                e.Property(p=>p.descricao).HasMaxLength(150);
                //precisao decimal
                e.Property(p=>p.valor).HasPrecision(8,2);

                //relacionamento
                
                e.HasOne(p => p.categoria) //lado um
                    .WithMany(p => p.produtos) //lado muitos
                    .HasForeignKey(p => p.idCategoria) //chave estrangeira
                    .HasConstraintName("fk_categoria_produtos") //nome relacionamento
                    .OnDelete(DeleteBehavior.NoAction);//comportamento delete

            });

        }

       

    }
}
