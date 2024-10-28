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
    public partial class FrmTipoOrdem : Form
    {
        private IRepositorioTipoOrdem repositorio;

        public FrmTipoOrdem(IRepositorioTipoOrdem repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtTipoOrdem.Text = "";
        }

        public Tipo_Ordem carregaPropriedades()
        {
            Tipo_Ordem tip;
            if (txtID.Text != "")
            {
                tip = repositorio.Recuperar(t => t.id == int.Parse(txtID.Text));
            }
            else tip = new Tipo_Ordem();

            tip.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            tip.nomeTipo = txtTipoOrdem.Text;

            return tip;
        }

        private void FrmTipoOrdem_Load(object sender, EventArgs e)
        {
            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            Limpar();
            txtTipoOrdem.Focus();
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
            txtTipoOrdem.Focus();
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
                txtTipoOrdem.Focus();
            }
            else
            {
                MessageBox.Show("Localize o Tipo de Ordem!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTipoOrdem.Text != String.Empty)
                {
                    Tipo_Ordem tip = carregaPropriedades();
                    if (tip.id == 0)
                    {
                        //inserir
                        repositorio.Inserir(tip);
                    }
                    else
                    {
                        //alterar
                        repositorio.Alterar(tip);
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
                var tip = carregaPropriedades();
                repositorio.Excluir(tip);
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
            else MessageBox.Show("Localize o Tipo de Ordem!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaTipoOrdem>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                //select * from categoria where id = form2.id
                var tip = repositorio.Recuperar(t => t.id == form2.id);
                if (tip != null)
                {
                    txtID.Text = tip.id.ToString();
                    txtTipoOrdem.Text = tip.nomeTipo;

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
