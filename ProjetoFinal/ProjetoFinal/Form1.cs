using InfraEstrutura.Contexto;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Contexto_Empresa contexto = new Contexto_Empresa
            using (var contexto = new Contexto_Empresa())
            {

            }
        }
    }
}
