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

namespace Projeto2025_exemplo
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

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                if(txtLogin.Text == "admin" && txtSenha.Text == "admin")
                {
                    idFuncionario = -1;
                    this.Close();
                }
                else
                {
                    var funcionario = repositorio.Recuperar(f => f.login == txtLogin.Text && f.senha == txtSenha.Text);
                    if (funcionario != null)
                    {
                        idFuncionario = funcionario.id;
                        this.Close();
                    }
                    else MessageBox.Show("Dados Incorretos!");
                }               
            }
            else MessageBox.Show("Informe o Login e Senha!");
        }
    }
}
