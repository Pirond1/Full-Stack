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
    public partial class FrmConsultaOrdem : Form
    {
        private IRepositorioOrdem repositorio;
        public int id;
        public FrmConsultaOrdem(IRepositorioOrdem repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void FrmConsultaOrdem_Load(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(c => c.id==int.Parse(txtOrdem.Text));

            gdDados.DataSource = lista;

            if (lista.Count > 0)
            {
                gdDados.Columns["venda"].Visible = false;
                gdDados.Columns["aluguel"].Visible = false;
                gdDados.Columns["dataOrdem"].HeaderText = "Data da Ordem";
                gdDados.Columns["idAutomovel"].HeaderText = "ID Automovel";
                gdDados.Columns["idTipo_Ordem"].HeaderText = "ID Tipo de Ordem";
                gdDados.Columns["idFuncionario"].HeaderText = "ID Funcionario";
                gdDados.Columns["idCliente"].HeaderText = "ID Cliente";
            }
        }
    }
}
