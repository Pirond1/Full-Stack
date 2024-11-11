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
    public partial class FrmConsultaFuncionario : Form
    {
        private IRepositorioFuncionario repositorio;
        public int id;
        public FrmConsultaFuncionario(IRepositorioFuncionario repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.nome.Contains(txtFuncionario.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["ordem"].Visible = false;
                gdDados.Columns["nome"].HeaderText = "Nome";
                gdDados.Columns["login"].HeaderText = "Login";
                gdDados.Columns["senha"].HeaderText = "Senha";
                gdDados.Columns["salario"].HeaderText = "Salário";
                gdDados.Columns["dataNascimento"].HeaderText = "Data de Nascimento";
            }
        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
