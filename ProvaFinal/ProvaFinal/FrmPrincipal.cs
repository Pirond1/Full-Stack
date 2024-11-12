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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, Seja Bem Vindo!");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmCliente>();
            form.ShowDialog();
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            var form = Program.serviceProvider.GetService<FrmEndereco>();
            form.ShowDialog();
        }
    }
}
