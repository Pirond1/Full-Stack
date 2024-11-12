using Entidades;
using InfraEstrutura;
using Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFinal
{
    public partial class FrmCliente : Form
    {
        private IRepositorioCliente repositorio;
        public FrmCliente(IRepositorioCliente repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        public Cliente carregaPropriedades()
        {
            Cliente cli;
            cli = new Cliente(); //Inserir

            cli.nome = txtNome.Text;
            cli.email = txtEmail.Text;

            return cli;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != String.Empty || txtEmail.Text != String.Empty)
                {
                    Cliente cli = carregaPropriedades();
                    repositorio.Inserir(cli);

                    Program.serviceProvider.GetRequiredService<Contexto>().SaveChanges();
                    MessageBox.Show("Salvo com Sucesso!");

                    Limpar();
                }
                else MessageBox.Show("Preencha os Campos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar!\nMensagem de Erro: " + ex.Message);
            }
        }
    }
}
