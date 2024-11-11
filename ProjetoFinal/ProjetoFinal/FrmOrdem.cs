using Entidades;
using InfraEstrutura.Contexto;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class FrmOrdem : Form
    {
        private IRepositorioOrdem repositorioOrdem;
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioTipoOrdem repositorioTipoOrdem;
        private IRepositorioFuncionario repositorioFuncionario;
        private IRepositorioCliente repositorioCliente;
        public FrmOrdem(IRepositorioOrdem repositorioOrdem, IRepositorioAutomovel repositorioAutomovel, IRepositorioTipoOrdem repositorioTipoOrdem, IRepositorioFuncionario repositorioFuncionario, IRepositorioCliente repositorioCliente)
        {
            InitializeComponent();
            this.repositorioOrdem = repositorioOrdem;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioTipoOrdem = repositorioTipoOrdem;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioCliente = repositorioCliente;
        }

        public Ordem carregaPropriedades()
        {
            Ordem ord;
            if (txtID.Text != "")
            {
                //Alterar, estou recuperando o registro antigo para manter a referencia do objeto do entity
                ord = repositorioOrdem.Recuperar(m => m.id == int.Parse(txtID.Text));
            }
            else ord = new Ordem(); //Inserir

            ord.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            ord.dataOrdem = DateTime.Parse(txtData.Text);
            ord.idAutomovel = (int)cbbAutomovel.SelectedValue;
            ord.idTipo_Ordem = (int)cbbTipoOrdem.SelectedValue;
            ord.idFuncionario = (int)cbbFuncionario.SelectedValue;
            ord.idCliente = (int)cbbCliente.SelectedValue;

            return ord;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtData.Text = DateTime.Now.ToString();
            cbbAutomovel.SelectedIndex = -1; //Limpar ComboBox
            cbbTipoOrdem.SelectedIndex = -1;
            cbbFuncionario.SelectedIndex = -1; 
            cbbCliente.SelectedIndex = -1; 
        }

        private void FrmOrdem_Load(object sender, EventArgs e)
        {
            cbbAutomovel.DataSource = repositorioAutomovel.ListarTodos();
            cbbAutomovel.DisplayMember = "numeroChassi";
            cbbAutomovel.ValueMember = "id";

            cbbTipoOrdem.DataSource = repositorioTipoOrdem.ListarTodos();
            cbbTipoOrdem.DisplayMember = "nomeTipo";
            cbbTipoOrdem.ValueMember = "id";

            cbbFuncionario.DataSource = repositorioFuncionario.ListarTodos();
            cbbFuncionario.DisplayMember = "nome";
            cbbFuncionario.ValueMember = "id";

            cbbCliente.DataSource = repositorioCliente.ListarTodos();
            cbbCliente.DisplayMember = "CPF";
            cbbCliente.ValueMember = "id";

            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            Limpar();
            txtData.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pDados.Enabled = true;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            Limpar();
            txtData.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                pDados.Enabled = true;
                btnNovo.Enabled = false;
                btnLocalizar.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                txtData.Focus();
            }
            else
            {
                MessageBox.Show("Localize a Ordem!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtData.Text != "" || cbbAutomovel.SelectedIndex != 0 || cbbTipoOrdem.SelectedIndex != 0 || cbbFuncionario.SelectedIndex != 0 || cbbCliente.SelectedIndex != 0)
                {
                    Ordem ord = carregaPropriedades();
                    if (ord.id == 0)
                    {
                        //inserir
                        repositorioOrdem.Inserir(ord);
                    }
                    else
                    {
                        //alterar
                        repositorioOrdem.Alterar(ord);
                    }
                    Program.serviceProvider.GetRequiredService<Contexto_Empresa>().SaveChanges();
                    MessageBox.Show("Salvo com Sucesso!");

                    pDados.Enabled = false;
                    btnNovo.Enabled = true;
                    btnLocalizar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = false;
                    Limpar();
                }
                else MessageBox.Show("Preencha os Campos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar!\nMensagem de Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                var ord = carregaPropriedades();
                repositorioOrdem.Excluir(ord);
                Program.serviceProvider.GetRequiredService<Contexto_Empresa>().SaveChanges();

                MessageBox.Show("Excluido com Sucesso!");
                pDados.Enabled = false;
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                Limpar();
            }
            else MessageBox.Show("Localize a Ordem!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaOrdem>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var ord = repositorioOrdem.Recuperar(c => c.id == form2.id);
                if (ord != null)
                {
                    txtID.Text = ord.id.ToString();
                    txtData.Text = ord.dataOrdem.ToString();
                    cbbAutomovel.SelectedValue = ord.idAutomovel;
                    cbbTipoOrdem.SelectedValue = ord.idTipo_Ordem;
                    cbbFuncionario.SelectedValue = ord.idFuncionario;
                    cbbCliente.SelectedValue = ord.idCliente;

                    pDados.Enabled = false;
                    btnNovo.Enabled = false;
                    btnLocalizar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                }
            }
        }
    }
}
