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
    public partial class FrmPrincipal : Form
    {
        private IRepositorioFuncionario repositorio;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmMarca>();
            form.ShowDialog();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmModelo>();
            form.ShowDialog();
        }

        private void automóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmAutomovel>();
            form.ShowDialog();
        }

        private void tipoDeOrdemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmTipoOrdem>();
            form.ShowDialog();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmPagamento>();
            form.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var frm =
                Program.serviceProvider.GetRequiredService<FrmLogin>();
            frm.ShowDialog();
            if (frm.idFuncionario == -1)
            {
                MessageBox.Show("Bem vindo Admin!");
            }
            else
            {
                if (frm.idFuncionario > 0)
                {
                    //encontrou
                    var funcionario = repositorio.Recuperar(f => f.id == frm.idFuncionario);
                    MessageBox.Show("Bem vindo " + funcionario.nome + "!");
                }
                else
                    this.Close();
            }
        }


        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmFuncionario>();
            form.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmCliente>();
            form.ShowDialog();
        }

        private void ordemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmOrdem>();
            form.ShowDialog();
        }
    }
}
