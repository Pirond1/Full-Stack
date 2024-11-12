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
    public partial class FrmConsultaAluguel : Form
    {
        private IRepositorioAluguel repositorio;
        public int id;
        public FrmConsultaAluguel(IRepositorioAluguel repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void FrmConsultaAluguel_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.id == int.Parse(txtAluguel.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["dataRetirada"].HeaderText = "Data da Retirada";
                gdDados.Columns["dataDevolucao"].HeaderText = "Data da Devolução";
                gdDados.Columns["idPagamento"].HeaderText = "ID Pagamento";
                gdDados.Columns["idOrdem"].HeaderText = "ID Ordem";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
