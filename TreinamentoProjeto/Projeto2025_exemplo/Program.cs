using InfraEstrutura.Contexto;
using Microsoft.Extensions.DependencyInjection;
using Interfaces;
using InfraEstrutura.Repositorio;

namespace Projeto2025_exemplo
{
    internal static class Program
    {
        public static ServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            
            using(serviceProvider = services.BuildServiceProvider())
            {
                var MainForm = serviceProvider.GetRequiredService<FrmPrincipal>();
                Application.Run(MainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<Contexto_Empresa>(); //Classe que representa o Contexto
         
            //ADICIONAR TODOS OS FORMULÁRIOS DO MEU PROJETO 
            services.AddScoped<Form1>();
            services.AddScoped<FrmCategoria>();
            services.AddScoped<FrmConsultaCategoria>();
            services.AddScoped<FrmPrincipal>();

            //ADICIONAR TODOS AS ENTIDADES
            services.AddSingleton<IRepositorioCategoria, CategoriaRepositorio>();
            services.AddSingleton<IRepositorioProdutos, ProdutoRepositorio>();
        }
    }
}