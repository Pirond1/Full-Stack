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
using System.Xml.Linq;

namespace ProjetoFinal
{
    public partial class FrmAluguel : Form
    {
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioPagamento repositorioPagamento;
        private IRepositorioOrdem repositorioOrdem;
        public FrmAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioPagamento repositorioPagamento, IRepositorioOrdem repositorioOrdem)
        {
            InitializeComponent();
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioPagamento = repositorioPagamento;
            this.repositorioOrdem = repositorioOrdem;
        }

        public Aluguel carregaPropriedades()
        {
            Aluguel alu;
            if (txtID.Text != "")
            {
                //Alterar, estou recuperando o registro antigo para manter a referencia do objeto do entity
                alu = repositorioAluguel.Recuperar(m => m.id == int.Parse(txtID.Text));
            }
            else alu = new Aluguel(); //Inserir

            alu.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            alu.dataRetirada = DateTime.Parse(txtRetirada.Text);
            alu.dataDevolucao = DateTime.Parse(txtDevolucao.Text);
            alu.idPagamento = (int)cbbPagamento.SelectedValue;
            alu.idOrdem = (int)cbbOrdem.SelectedValue;

            return alu;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtRetirada.Text = DateTime.Now.ToString();
            txtDevolucao.Text = DateTime.Now.ToString();
            cbbPagamento.SelectedIndex = -1; //Limpar ComboBox
            cbbOrdem.SelectedIndex = -1;
        }

        private void FrmAluguel_Load(object sender, EventArgs e)
        {
            cbbPagamento.DataSource = repositorioPagamento.ListarTodos();
            cbbPagamento.DisplayMember = "nomePagamento";
            cbbPagamento.ValueMember = "id";

            cbbOrdem.DataSource = repositorioOrdem.Listar(a => a.tipo_ordem.nomeTipo == "Aluguel");
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
            txtRetirada.Focus();
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
            txtRetirada.Focus();
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
                txtRetirada.Focus();
            }
            else
            {
                MessageBox.Show("Localize o Aluguel!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRetirada.Text != "" || txtDevolucao.Text != "" || cbbPagamento.SelectedIndex != -1 || cbbOrdem.SelectedIndex != -1)
                {
                    Aluguel alu = carregaPropriedades();
                    if (alu.id == 0)
                    {
                        //inserir
                        repositorioAluguel.Inserir(alu);
                    }
                    else
                    {
                        //alterar
                        repositorioAluguel.Alterar(alu);
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
                var alu = carregaPropriedades();
                repositorioAluguel.Excluir(alu);
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
            else MessageBox.Show("Localize o Aluguel!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaAluguel>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var alu = repositorioAluguel.Recuperar(c => c.id == form2.id);
                if (alu != null)
                {
                    txtID.Text = alu.id.ToString();
                    txtRetirada.Text = alu.dataRetirada.ToString();
                    txtDevolucao.Text = alu.dataDevolucao.ToString();
                    cbbPagamento.SelectedValue = alu.idPagamento;
                    cbbOrdem.SelectedValue = alu.idOrdem;


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
