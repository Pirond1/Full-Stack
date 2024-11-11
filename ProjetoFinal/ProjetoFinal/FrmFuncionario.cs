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
    public partial class FrmFuncionario : Form
    {
        private IRepositorioFuncionario repositorio;
        public FrmFuncionario(IRepositorioFuncionario repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        void limpar()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtSalario.Text = "";
            txtNascimento.Text = DateTime.Now.ToString();
        }

        public Funcionario carregaPropriedades()
        {
            Funcionario fun;
            if (txtID.Text != "")
            {
                //alterar , estou recuperando o registro antigo
                //para manter a referencia do objeto do entity
                fun = repositorio.Recuperar(c => c.id ==
                                int.Parse(txtID.Text));
            }
            else fun = new Funcionario(); //inserir

            fun.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            fun.nome = txtNome.Text;
            fun.login = txtLogin.Text;
            fun.senha = txtSalario.Text;
            fun.dataNascimento = DateTime.Parse(txtNascimento.Text);
            fun.salario = Decimal.Parse(txtSalario.Text);

            return fun;
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
            else MessageBox.Show("Localize o Funcionario");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNome.Text != String.Empty || txtLogin.Text != String.Empty || txtSenha.Text != String.Empty || txtSalario.Text != "")
                {
                    Funcionario fun = carregaPropriedades();

                    if (fun.id == 0)
                    {
                        //inserindo
                        repositorio.Inserir(fun);
                    }
                    else
                    //alterar
                    {

                        repositorio.Alterar(fun);
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

                var fun = carregaPropriedades();
                repositorio.Excluir(fun);
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
            else MessageBox.Show("Localize o Funcionario");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.
                    GetRequiredService<FrmConsultaFuncionario>();
            form2.ShowDialog();



            if (form2.id > 0)
            {
                var fun = repositorio.Recuperar(c => c.id == form2.id);
                txtID.Text = fun.id.ToString();
                txtNome.Text = fun.nome;
                txtLogin.Text = fun.login;
                txtSenha.Text = fun.senha;
                txtNascimento.Text = fun.nome.ToString();
                txtSalario.Text = fun.senha;

                pDados.Enabled = false;
                btnNovo.Enabled = false;
                btnLocalizar.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }
    }
}
