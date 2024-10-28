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
    }
}
