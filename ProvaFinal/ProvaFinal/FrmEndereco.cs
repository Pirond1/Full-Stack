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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFinal
{
    public partial class FrmEndereco : Form
    {
        public IRepositorioEndereco repositorioEndereco;
        public IRepositorioCliente repositorioCliente;
        public FrmEndereco(IRepositorioEndereco repositorioEndereco, IRepositorioCliente repositorioCliente)
        {
            InitializeComponent();
            this.repositorioEndereco = repositorioEndereco;
            this.repositorioCliente = repositorioCliente;
        }

        void Limpar()
        {
            txtRua.Text = "";
            txtCidade.Text = "";
            cbbCliente.SelectedIndex = -1;
        }

        public Endereco carregaPropriedades()
        {
            Endereco end;
            end = new Endereco(); //Inserir

            end.rua = txtRua.Text;
            end.cidade = txtCidade.Text;
            end.idCliente = (int)cbbCliente.SelectedValue;

            return end;
        }

        private void FrmEndereco_Load(object sender, EventArgs e)
        {
            cbbCliente.DataSource = repositorioCliente.ListarTodos();
            cbbCliente.DisplayMember = "nome";
            cbbCliente.ValueMember = "id";
            Limpar();
            txtRua.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRua.Text != String.Empty || txtCidade.Text != String.Empty || cbbCliente.SelectedIndex != -1)
                {
                    Endereco end = carregaPropriedades();
                    repositorioEndereco.Inserir(end);

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
