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
    public partial class FrmConsultaMarca : Form
    {
        private IRepositorioMarca repositorio;
        public int id;
        public FrmConsultaMarca(IRepositorioMarca repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.nomeMarca.Contains(txtMarca.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["modelo"].Visible = false;
                gdDados.Columns["nomemarca"].HeaderText = "Marca";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }

        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }
    }
}
