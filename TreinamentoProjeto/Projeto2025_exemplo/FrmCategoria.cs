using Entidades;
using InfraEstrutura.Contexto;
using InfraEstrutura.Repositorio;
using Interfaces;
using Microsoft.EntityFrameworkCore.Query;
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

namespace Projeto2025_exemplo
{
    public partial class FrmCategoria : Form
    {
        private IRepositorioCategoria repositorio;

        public FrmCategoria(IRepositorioCategoria repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtDescricao.Text = "";
        }

        public Categoria carregaPropriedades()
        {
            Categoria cat = new Categoria()
            {
                id = txtID.Text == "" ? 0 : int.Parse(txtID.Text),
                descricao = txtDescricao.Text
            };
            return cat;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLocalizar.Enabled = false;
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
            btnLocalizar.Enabled = true;
            Limpar();
            txtDescricao.Focus();
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
                btnLocalizar.Enabled = true;
                Limpar();
                txtDescricao.Focus();
            }
            else
            {
                MessageBox.Show("Localize a Categoria!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text != String.Empty)
                {
                    Categoria cat = carregaPropriedades();
                    if (cat.id == 0 )
                    {
                        //inserir
                        repositorio.Inserir(cat);
                    }
                    else
                    {
                        //alterar
                        repositorio.Alterar(cat);
                    }
                    Program.serviceProvider.GetRequiredService<Contexto_Empresa>().SaveChanges();
                    MessageBox.Show("Salvo com Sucesso!");

                    pDados.Enabled = false;
                    btnNovo.Enabled = true;
                    btnLocalizar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnLocalizar.Enabled = false;
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
            btnLocalizar.Enabled = false;
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                carregaPropriedades();
                MessageBox.Show("Excluido com Sucesso!");
                pDados.Enabled = false;
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                btnLocalizar.Enabled = false;
                Limpar();
            }
            else MessageBox.Show("Localize a Categoria!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            pDados.Enabled = false;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLocalizar.Enabled = false;
            Limpar();
        }
    }
}
