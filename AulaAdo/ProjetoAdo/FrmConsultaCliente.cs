using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ProjetoAdo
{
    public partial class FrmConsultaCliente : Form
    {
        public int codigo;

        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != String.Empty)
            {
                ClientesDAO dao = new ClientesDAO();
                List<Clientes> lista = dao.consultar(txtNome.Text);
                dgvDados.DataSource = lista;
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter o ID da Linha Clicada
            codigo = int.Parse(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
