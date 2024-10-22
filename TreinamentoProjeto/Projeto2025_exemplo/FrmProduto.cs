using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using InfraEstrutura.Contexto;
using InfraEstrutura.Repositorio;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Projeto2025_exemplo
{
    public partial class FrmProduto : Form
    {
        private IRepositorioCategoria repositoriocat;
        private IRepositorioProdutos repositoriopro;

        public FrmProduto(IRepositorioProdutos repositoriopro, IRepositorioCategoria repositoriocat)
        {
            InitializeComponent();
            this.repositoriopro = repositoriopro;
            this.repositoriocat = repositoriocat;
        }

        public Produtos carregaPropriedades()
        {
            Produtos prod;
            if (txtID.Text != "")
            {
                //Alterar, estou recuperando o registro antigo para manter a referencia do objeto do entity
                prod = repositoriopro.Recuperar(p => p.id == int.Parse(txtID.Text));
            }
            else prod = new Produtos(); //Inserir

            prod.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            prod.descricao = txtDescricao.Text;
            prod.valor = decimal.Parse(txtValor.Text);
            prod.ativo = ckbAtivo.Checked;
            prod.qtde = int.Parse(txtQuantidade.Text);
            //Recuperar ID de Categoria selecionada para CHAVE ESTRANGEIRA
            prod.idCategoria = (int)cbbCategoria.SelectedValue;

            return prod;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            ckbAtivo.Checked = false;
            cbbCategoria.SelectedIndex = -1; //Limpar ComboBox
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            cbbCategoria.DataSource = repositoriocat.ListarTodos();
            cbbCategoria.DisplayMember = "descricao";
            cbbCategoria.ValueMember = "id";

            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            Limpar();
            txtDescricao.Focus();
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
            txtDescricao.Focus();
            ckbAtivo.Checked = true;
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
                txtDescricao.Focus();
            }
            else
            {
                MessageBox.Show("Localize o Produto!");
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaProduto>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                //select * from produto where id = form2.id
                var prod = repositoriopro.Recuperar(c => c.id == form2.id);
                if (prod != null)
                {
                    txtID.Text = prod.id.ToString();
                    txtDescricao.Text = prod.descricao;
                    txtValor.Text = prod.valor.ToString();
                    txtQuantidade.Text = prod.qtde.ToString();
                    if (prod.ativo)
                    {
                        ckbAtivo.Checked = true;
                    }
                    else ckbAtivo.Checked = false;
                    cbbCategoria.SelectedValue = prod.idCategoria;

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text != String.Empty)
                {
                    Produtos prod = carregaPropriedades();
                    if (prod.id == 0)
                    {
                        //inserir
                        repositoriopro.Inserir(prod);
                    }
                    else
                    {
                        //alterar
                        repositoriopro.Alterar(prod);
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
                var prod = carregaPropriedades();
                repositoriopro.Excluir(prod);
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
            else MessageBox.Show("Localize o Produto!");
        }
    }
}
