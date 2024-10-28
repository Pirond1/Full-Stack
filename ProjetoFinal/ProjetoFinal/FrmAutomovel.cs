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
    public partial class FrmAutomovel : Form
    {
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioModelo repositorioModelo;
        private IRepositorioMarca repositorioMarca;
        public FrmAutomovel(IRepositorioModelo repositorioModelo, IRepositorioAutomovel repositorioAutomovel, IRepositorioMarca repositorioMarca)
        {
            InitializeComponent();
            this.repositorioModelo = repositorioModelo;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioMarca = repositorioMarca;
        }

        public Automovel carregaPropriedades()
        {
            Automovel aut;
            if (txtID.Text != "")
            {
                //Alterar, estou recuperando o registro antigo para manter a referencia do objeto do entity
                aut = repositorioAutomovel.Recuperar(a => a.id == int.Parse(txtID.Text));
            }
            else aut = new Automovel(); //Inserir

            aut.id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            aut.cor = txtCor.Text;
            aut.ano = int.Parse(txtAno.Text);
            aut.numeroPortas = int.Parse(txtPortas.Text);
            aut.numeroChassi = txtChassi.Text;
            aut.quilometragem = int.Parse(txtKm.Text);
            //Recuperar ID de Categoria selecionada para CHAVE ESTRANGEIRA
            aut.idModelo = (int)cbbModelo.SelectedValue;

            return aut;
        }

        void Limpar()
        {
            txtID.Text = "";
            txtCor.Text = "";
            txtAno.Text = "";
            txtPortas.Text = "";
            txtChassi.Text = "";
            txtKm.Text = "";
            cbbModelo.SelectedIndex = -1; //Limpar ComboBox
        }

        private void FrmAutomovel_Load(object sender, EventArgs e)
        {
            cbbModelo.DataSource = repositorioModelo.ListarTodos();
            cbbModelo.DisplayMember = "nomeModelo";
            cbbModelo.ValueMember = "id";

            pDados.Enabled = false;
            btnNovo.Enabled = true;
            btnLocalizar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            Limpar();
            txtAno.Focus();
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
            txtAno.Focus();
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
                txtAno.Focus();
            }
            else
            {
                MessageBox.Show("Localize o Automóvel!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAno.Text != "" || txtPortas.Text != "" || txtCor.Text != String.Empty || txtChassi.Text != String.Empty || txtKm.Text != "")
                {
                    Automovel aut = carregaPropriedades();
                    if (aut.id == 0)
                    {
                        //inserir
                        repositorioAutomovel.Inserir(aut);
                    }
                    else
                    {
                        //alterar
                        repositorioAutomovel.Alterar(aut);
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
                var aut = carregaPropriedades();
                repositorioAutomovel.Excluir(aut);
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
            else MessageBox.Show("Localize o Automóvel!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmConsultaAutomovel>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var aut = repositorioAutomovel.Recuperar(c => c.id == form2.id);
                if (aut != null)
                {
                    txtID.Text = aut.id.ToString();
                    txtAno.Text = aut.ano.ToString();
                    txtPortas.Text = aut.numeroPortas.ToString();
                    txtCor.Text = aut.cor;
                    cbbModelo.SelectedValue = aut.idModelo;

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
