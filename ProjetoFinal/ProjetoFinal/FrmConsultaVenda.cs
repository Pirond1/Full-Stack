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
    public partial class FrmConsultaVenda : Form
    {
        private IRepositorioVenda repositorio;
        public int id;
        public FrmConsultaVenda(IRepositorioVenda repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void FrmConsultaVenda_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.id == int.Parse(txtVenda.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["dataRetirada"].HeaderText = "Data da Retirada";
                gdDados.Columns["idPagamento"].HeaderText = "ID Pagamento";
                gdDados.Columns["idOrdem"].HeaderText = "ID Ordem";
            }
        }
    }
}
