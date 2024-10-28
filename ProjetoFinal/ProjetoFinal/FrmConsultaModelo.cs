using Entidades;
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
    public partial class FrmConsultaModelo : Form
    {
        private IRepositorioModelo repositorio;
        public int id;
        public FrmConsultaModelo(IRepositorioModelo repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.nomeModelo.Contains(txtModelo.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["marca"].Visible = false;
                gdDados.Columns["automovel"].Visible = false;
                gdDados.Columns["nomemodelo"].HeaderText = "Modelo";
                gdDados.Columns["idmarca"].HeaderText = "ID Marca";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
