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
    public partial class FrmModelo : Form
    {
        private IRepositorioMarca repositorioMarca;
        private IRepositorioModelo repositorioModelo;

        public FrmModelo(IRepositorioMarca repositorioMarca, IRepositorioModelo repositorioModelo)
        {
            InitializeComponent();
            this.repositorioMarca = repositorioMarca;
            this.repositorioModelo = repositorioModelo;
        }

        public Modelo carregaPropriedades()
        {
            Modelo mod;
            if (txtID.Text != "")
            {
                //Alterar, estou recuperando o registro antigo para manter a referencia do objeto do entity
                mod = repositorioModelo.Recuperar(m => m.id == int.Parse(txtID.Text));
            }
            else mod = new Modelo(); //Inserir

            mod.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            mod.nomeModelo = txtModelo.Text;
            mod.idMarca = (int)cbbMarca.SelectedValue;

            return mod;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtModelo.Text = "";
            cbbMarca.SelectedIndex = -1; //Limpar ComboBox
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            cbbMarca.DataSource = repositorioMarca.ListarTodos();
            cbbMarca.DisplayMember = "nomeMarca";
            cbbMarca.ValueMember = "id";

            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            Limpar();
            txtModelo.Focus();
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
            txtModelo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" || cbbMarca.SelectedIndex != -1)
            {
                pDados.Enabled = true;
                btnNovo.Enabled = false;
                btnLocalizar.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                txtModelo.Focus();
            }
            else
            {
                MessageBox.Show("Localize o Modelo!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModelo.Text != String.Empty)
                {
                    Modelo mod = carregaPropriedades();
                    if (mod.id == 0)
                    {
                        //inserir
                        repositorioModelo.Inserir(mod);
                    }
                    else
                    {
                        //alterar
                        repositorioModelo.Alterar(mod);
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
                var mod = carregaPropriedades();
                repositorioModelo.Excluir(mod);
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
            else MessageBox.Show("Localize o Modelo!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaModelo>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                //select * from produto where id = form2.id
                var mod = repositorioModelo.Recuperar(c => c.id == form2.id);
                if (mod != null)
                {
                    txtID.Text = mod.id.ToString();
                    txtModelo.Text = mod.nomeModelo;
                    cbbMarca.SelectedValue = mod.idMarca;

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
