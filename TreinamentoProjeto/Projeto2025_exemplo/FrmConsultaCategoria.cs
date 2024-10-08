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

namespace Projeto2025_exemplo
{
    public partial class FrmConsultaCategoria : Form
    {
        private IRepositorioCategoria repositorio;
        public int id;
        public FrmConsultaCategoria(IRepositorioCategoria repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select * from categoria where descricao like '"txtdescricao.text"*'
            var lista = repositorio.Listar(c => c.descricao.Contains(txtDescricao.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["produtos"].Visible = false;
                gdDados.Columns["descricao"].HeaderText = "Descrição";
            }
        }

        private void gdDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
