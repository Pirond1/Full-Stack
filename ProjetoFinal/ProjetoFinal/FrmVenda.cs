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
    public partial class FrmVenda : Form
    {
        private IRepositorioVenda repositorioVenda;
        private IRepositorioPagamento repositorioPagamento;
        private IRepositorioOrdem repositorioOrdem;
        public FrmVenda(IRepositorioVenda repositorioVenda, IRepositorioPagamento repositorioPagamento, IRepositorioOrdem repositorioOrdem)
        {
            InitializeComponent();
            this.repositorioVenda = repositorioVenda;
            this.repositorioPagamento = repositorioPagamento;
            this.repositorioOrdem = repositorioOrdem;
        }

        public Venda carregaPropriedades()
        {
            Venda ven;
            if (txtID.Text != "")
            {
                //Alterar, estou recuperando o registro antigo para manter a referencia do objeto do entity
                ven = repositorioVenda.Recuperar(m => m.id == int.Parse(txtID.Text));
            }
            else ven = new Venda(); //Inserir

            ven.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            ven.dataRetirada = DateTime.Parse(txtData.Text);
            ven.idPagamento = (int)cbbPagamento.SelectedValue;
            ven.idOrdem = (int)cbbOrdem.SelectedValue;

            return ven;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtData.Text = DateTime.Now.ToString();
            cbbPagamento.SelectedIndex = -1; //Limpar ComboBox
            cbbOrdem.SelectedIndex = -1;
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            cbbPagamento.DataSource = repositorioPagamento.ListarTodos();
            cbbPagamento.DisplayMember = "nomePagamento";
            cbbPagamento.ValueMember = "id";

            cbbOrdem.DataSource = repositorioOrdem.Listar(a => a.tipo_ordem.nomeTipo == "Venda");
            cbbOrdem.DisplayMember = "id";
            cbbOrdem.ValueMember = "id";

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
                MessageBox.Show("Localize a Venda!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtData.Text != "" || cbbPagamento.SelectedIndex != -1 || cbbOrdem.SelectedIndex != -1)
                {
                    Venda ven = carregaPropriedades();
                    if (ven.id == 0)
                    {
                        //inserir
                        repositorioVenda.Inserir(ven);
                    }
                    else
                    {
                        //alterar
                        repositorioVenda.Alterar(ven);
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
                var ven = carregaPropriedades();
                repositorioVenda.Excluir(ven);
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
            else MessageBox.Show("Localize a Venda!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaVenda>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var ven = repositorioVenda.Recuperar(c => c.id == form2.id);
                if (ven != null)
                {
                    txtID.Text = ven.id.ToString();
                    txtData.Text = ven.dataRetirada.ToString();
                    cbbPagamento.SelectedValue = ven.idPagamento;
                    cbbOrdem.SelectedValue = ven.idOrdem;


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
