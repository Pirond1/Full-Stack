using InfraEstrutura;
using Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ProvaFinal
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
            services.AddDbContext<Contexto>(); //Classe que representa o Contexto

            services.AddScoped<FrmPrincipal>();
            services.AddScoped<FrmCliente>();
            services.AddScoped<FrmEndereco>();

            services.AddSingleton<IRepositorioCliente, ClienteRepositorio>();
            services.AddSingleton<IRepositorioEndereco, EnderecoRepositorio>();
        }
    }
}