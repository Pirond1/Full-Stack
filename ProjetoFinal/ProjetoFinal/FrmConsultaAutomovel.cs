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
    public partial class FrmConsultaAutomovel : Form
    {
        private IRepositorioAutomovel repositorio;
        public int id;
        public FrmConsultaAutomovel(IRepositorioAutomovel repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.numeroChassi.Contains(txtAutomovel.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["modelo"].Visible = false;
                gdDados.Columns["ordem"].Visible = false;
                gdDados.Columns["numerochassi"].HeaderText = "Numero Chassi";
                gdDados.Columns["cor"].HeaderText = "Cor";
                gdDados.Columns["ano"].HeaderText = "Ano";
                gdDados.Columns["numeroPortas"].HeaderText = "Numero de Portas";
                gdDados.Columns["quilometragem"].HeaderText = "Km";
                gdDados.Columns["numeroChassi"].HeaderText = "Numero do Chassi";
                gdDados.Columns["idmodelo"].HeaderText = "ID Modelo";
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }

        private void FrmConsultaAutomovel_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }
    }
}
