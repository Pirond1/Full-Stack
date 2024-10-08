
using InfraEstrutura.Contexto;
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
    public partial class FrmConsultaCategoria : Form
    {
         public int id;
        public FrmConsultaCategoria()
        {
            InitializeComponent();

        }

        private void FrmConsultaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gdDados.DataSource = null;
            gdDados.Refresh();

            using (Contexto_Empresa con = new Contexto_Empresa())
            {
                var lista = con.categorias.Where(p => p.descricao.Contains(txtdescricao.Text)).ToList();
                if(lista.Count > 0)
                {
                    gdDados.DataSource = lista;
                }
            }

        }

        private void gdDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int) gdDados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }
    }
}
