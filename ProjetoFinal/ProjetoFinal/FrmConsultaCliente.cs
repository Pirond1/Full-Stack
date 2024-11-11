using Interfaces;
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
    public partial class FrmConsultaCliente : Form
    {
        private IRepositorioCliente repositorio;
        public int id;
        public FrmConsultaCliente(IRepositorioCliente repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.nome.Contains(txtCliente.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["ordem"].Visible = false;
                gdDados.Columns["nome"].HeaderText = "Nome";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
