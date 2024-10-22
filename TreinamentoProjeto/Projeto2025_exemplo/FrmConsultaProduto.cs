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
    public partial class FrmConsultaProduto : Form
    {
        private IRepositorioProdutos repositorio;
        public int id;
        public FrmConsultaProduto(IRepositorioProdutos repositorio)
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
                gdDados.Columns["descricao"].HeaderText = "Descrição";
                gdDados.Columns["valor"].HeaderText = "Valor";
                gdDados.Columns["datacadastro"].HeaderText = "Data de Cadastro";
                gdDados.Columns["ativo"].HeaderText = "Ativo";
                gdDados.Columns["qtde"].HeaderText = "Quantidade";
                gdDados.Columns["idcategoria"].HeaderText = "ID Categoria";
                gdDados.Columns["categoria"].Visible = false;
            }
        }

        private void gdDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
