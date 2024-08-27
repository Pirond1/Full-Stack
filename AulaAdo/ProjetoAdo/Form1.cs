using Entidades;

namespace ProjetoAdo
{
    public partial class Form1 : Form
    {
        Clientes cliente = new Clientes();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gbDados.Enabled = true;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            limpar();
            txtNome.Focus();
        }

        void limpar()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtNascimento.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                gbDados.Enabled = true;
                btnNovo.Enabled = false;
                btnLocalizar.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                txtNome.Focus();
            }
            else MessageBox.Show("Localize o Cliente");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                MessageBox.Show("Excluido com Sucesso!");

                limpar();
                gbDados.Enabled = false;
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
            }
            else MessageBox.Show("Localize o Cliente");
        }

        public void carregarPropriedades()
        {
            cliente.Nome = txtNome.Text;
            cliente.ID = txtID.Text == "" ? 0 : int.Parse(txtID.Text); //Operador Ternário
            cliente.DataNascimento = txtNascimento.Value;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != string.Empty)
                {
                    carregarPropriedades();

                    if(cliente.ID == 0)
                    {
                        (new ClientesDAO()).inserir(cliente);
                    }

                    MessageBox.Show("Salvo com Sucesso!");

                    limpar();
                    gbDados.Enabled = false;
                    btnNovo.Enabled = true;
                    btnLocalizar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Preencha os Campos!");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Salvar!");
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            gbDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            limpar();
            gbDados.Enabled = false;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }
    }
}
