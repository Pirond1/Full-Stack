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
    public partial class FrmLogin : Form
    {
        public IRepositorioFuncionario repositorio;
        public int idFuncionario = 0;
        public FrmLogin(IRepositorioFuncionario repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
                {
                    idFuncionario = -1;
                    this.Close();
                }
                else
                {
                    var funcionario = repositorio.Recuperar(f =>
                    f.login == txtLogin.Text && f.senha == txtSenha.Text);
                    if (funcionario != null)
                    {
                        //encontrou
                        idFuncionario = funcionario.id;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Dados incorretos");
                }   
            }
            else
                MessageBox.Show("Informar login e senha");
        }
    }
}
