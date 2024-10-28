using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace InfraEstrutura.Contexto
{
    public class Contexto_Empresa : DbContext
    {
        public Contexto_Empresa()
        {
            //criar ou alterar o banco de dados
            this.Database.EnsureCreated();
        }
        //quais entidades irão ser mapeadas como tabelas
        public DbSet<Aluguel> aluguel { get; set; }
        public DbSet<Automovel> automovel { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<Marca> marca { get; set; }
        public DbSet<Modelo> modelo { get; set; }
        public DbSet<Ordem> ordem { get; set; }
        public DbSet<Pagamento> pagamento { get; set; }
        public DbSet<Tipo_Ordem> tipo_ordem { get; set; }
        public DbSet<Venda> venda { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
        //base.OnConfiguring(optionsBuilder);
        var stringConexao = @"Server=PC-SMARTGAMER; 
                 DataBase=dbProjetoFinal;integrated security=true; TrustServerCertificate=True;";
                 // ALTERAR O SERVER DE ACORDO COM O PC QUE ESTÁ (Em casa -> PC-SMARTGAMER / Faculdade -> LAB10-14)

             if (!optionsBuilder.IsConfigured)
             {
                 optionsBuilder.UseSqlServer(stringConexao);
             }

         }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             //  base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Marca>(e => {
                 //qtde maxima de caracteres
                 e.Property(p => p.nomeMarca).HasMaxLength(50);

             });


             modelBuilder.Entity<Modelo>(e => {
                 //qtde maxima de caracteres
                 e.Property(p => p.nomeModelo).HasMaxLength(50);

                 //relacionamento

                 e.HasOne(p => p.marca) //lado um
                     .WithMany(p => p.modelo) //lado muitos
                     .HasForeignKey(p => p.idMarca) //chave estrangeira
                     .HasConstraintName("fk_marca_modelo") //nome relacionamento
                     .OnDelete(DeleteBehavior.NoAction);//comportamento delete

             });

            modelBuilder.Entity<Automovel>(e =>
            {
                e.Property(p => p.cor).HasMaxLength(50);
                e.Property(p=> p.numeroChassi).HasMaxLength(50);

                e.HasOne(p => p.modelo)
                    .WithMany(p => p.automovel)
                    .HasForeignKey(p => p.idModelo)
                    .HasConstraintName("fk_modelo_automovel")
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Tipo_Ordem>(e =>
            {
                e.Property(p => p.nomeTipo).HasMaxLength(50);
            });

            modelBuilder.Entity<Pagamento>(e =>
            {
                e.Property(p => p.nomePagamento).HasMaxLength(50);
            });
        }
    }
}
