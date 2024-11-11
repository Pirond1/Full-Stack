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
    public partial class FrmCliente : Form
    {
        private IRepositorioCliente repositorio;
        public FrmCliente(IRepositorioCliente repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        void limpar()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
        }

        public Cliente carregaPropriedades()
        {
            Cliente cli;
            if (txtID.Text != "")
            {
                //alterar , estou recuperando o registro antigo
                //para manter a referencia do objeto do entity
                cli = repositorio.Recuperar(c => c.id ==
                                int.Parse(txtID.Text));
            }
            else cli = new Cliente(); //inserir

            cli.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            cli.nome = txtNome.Text;
            cli.CPF = txtCPF.Text;

            return cli;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
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
            limpar();
            txtNome.Focus();
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
                txtNome.Focus();
            }
            else MessageBox.Show("Localize o Cliente");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNome.Text != String.Empty || txtCPF.Text != String.Empty)
                {
                    Cliente cli = carregaPropriedades();

                    if (cli.id == 0)
                    {
                        //inserindo
                        repositorio.Inserir(cli);
                    }
                    else
                    //alterar
                    {

                        repositorio.Alterar(cli);
                    }
                    Program.serviceProvider.
                        GetRequiredService<Contexto_Empresa>().SaveChanges();
                    MessageBox.Show("Salvo com sucesso");


                    limpar();
                    pDados.Enabled = false;
                    btnNovo.Enabled = true;
                    btnLocalizar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = false;

                }
                else MessageBox.Show("Preencha os campos");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar! " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {

                var cli = carregaPropriedades();
                repositorio.Excluir(cli);
                Program.serviceProvider.
                        GetRequiredService<Contexto_Empresa>().SaveChanges();

                MessageBox.Show("Excluído com sucesso");
                limpar();
                pDados.Enabled = false;
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;

            }
            else MessageBox.Show("Localize o Cliente");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.
                    GetRequiredService<FrmConsultaCliente>();
            form2.ShowDialog();



            if (form2.id > 0)
            {
                var cli = repositorio.Recuperar(c => c.id == form2.id);
                txtID.Text = cli.id.ToString();
                txtNome.Text = cli.nome;
                txtCPF.Text = cli.CPF;

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
