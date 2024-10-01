using InfraEstrutura;
using Entidades;
using InfraEstrutura.Contexto;
using InfraEstrutura.Repositorio;

namespace Projeto2025_exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Contexto_Empresa contexto = new Contexto_Empresa(); 
            using (var contexto = new Contexto_Empresa())
            {
                CategoriaRepositorio cat = new CategoriaRepositorio(contexto);
                cat.Inserir(new Categoria() {
                    descricao = "teste",
                }) ;
                contexto.SaveChanges();
            }

        }
    }
}
