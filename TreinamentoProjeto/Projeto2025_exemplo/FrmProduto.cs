using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfraEstrutura.Repositorio;
using Interfaces;

namespace Projeto2025_exemplo
{
    public partial class FrmProduto : Form
    {
        private IRepositorioCategoria repositoriocat;
        private IRepositorioProdutos repositoriopro;

        public FrmProduto(IRepositorioProdutos repositoriopro, IRepositorioCategoria repositoriocat)
        {
            InitializeComponent();
            this.repositoriopro = repositoriopro;
            this.repositoriocat = repositoriocat;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = repositoriocat.ListarTodos();
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "id";
        }
    }
}
