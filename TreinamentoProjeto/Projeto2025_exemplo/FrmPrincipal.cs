using Entidades;
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

namespace Projeto2025_exemplo
{
    public partial class FrmPrincipal : Form
    {
        private IRepositorioFuncionario repositorioFuncionario;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmCategoria>();
            form.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetService<FrmProduto>();
            form2.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var form2 = Program.serviceProvider.GetRequiredService<FrmLogin>();
            form2.ShowDialog();
            if (form2.idFuncionario == -1)
            {
                MessageBox.Show("Bem Vindo(a) Admin");
            }
            else if (form2.idFuncionario > 0)
            {
                var funcionario = repositorioFuncionario.Recuperar(f => f.id == form2.idFuncionario);
                MessageBox.Show("Bem Vindo(a) " + funcionario.nome);
            }
            else this.Close();
        }
    }
}
