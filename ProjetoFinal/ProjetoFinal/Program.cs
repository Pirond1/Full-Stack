using InfraEstrutura.Contexto;
using InfraEstrutura.Repositorio;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetoFinal
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

            using (serviceProvider = services.BuildServiceProvider())
            {
                var MainForm = serviceProvider.GetRequiredService<FrmPrincipal>();
                Application.Run(MainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<Contexto_Empresa>(); //Classe que representa o Contexto

            services.AddScoped<Form1>();
            services.AddScoped<FrmPrincipal>();
            services.AddScoped<FrmMarca>();
            services.AddScoped<FrmConsultaMarca>();
            services.AddScoped<FrmModelo>();
            services.AddScoped<FrmConsultaModelo>();
            services.AddScoped<FrmAutomovel>();
            services.AddScoped<FrmConsultaAutomovel>();
            services.AddScoped<FrmTipoOrdem>();
            services.AddScoped<FrmConsultaTipoOrdem>();
            services.AddScoped<FrmPagamento>();
            services.AddScoped<FrmConsultaPagamento>();


            services.AddSingleton<IRepositorioMarca, MarcaRepositorio>();
            services.AddSingleton<IRepositorioModelo, ModeloRepositorio>();
            services.AddSingleton<IRepositorioAutomovel, AutomovelRepositorio>();
            services.AddSingleton<IRepositorioTipoOrdem, TipoOrdemRepositorio>();
            services.AddSingleton<IRepositorioPagamento, PagamentoRepositorio>();
        }
    }
}