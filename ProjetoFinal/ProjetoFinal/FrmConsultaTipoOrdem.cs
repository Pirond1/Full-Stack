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
    public partial class FrmConsultaTipoOrdem : Form
    {
        private IRepositorioTipoOrdem repositorio;
        public int id;
        public FrmConsultaTipoOrdem(IRepositorioTipoOrdem repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(t => t.nomeTipo.Contains(txtTipoOrdem.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["ordem"].Visible = false;
                gdDados.Columns["nomeTipo"].HeaderText = "Tipo de Ordem";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }

        private void FrmConsultaTipoOrdem_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }
    }
}
