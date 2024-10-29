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
    public partial class FrmConsultaPagamento : Form
    {
        private IRepositorioPagamento repositorio;
        public int id;
        public FrmConsultaPagamento(IRepositorioPagamento repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(p => p.nomePagamento.Contains(txtPagamento.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["venda"].Visible = false;
                gdDados.Columns["aluguel"].Visible = false;
                gdDados.Columns["nomePagamento"].HeaderText = "Tipo de Pagamento";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }

        private void FrmConsultaPagamento_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }
    }
}
