using Entidades;
using InfraEstrutura.Contexto;

using Microsoft.Extensions.DependencyInjection;
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
    public partial class FrmCadCategoria : Form
    {
       
        public FrmCadCategoria()
        {
            InitializeComponent();

        }

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            pdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            pdados.Enabled = true;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnalterar.Enabled = false;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = true;
            limpar();
            txtdescricao.Focus();
        }

        void limpar()
        {
            txtid.Text = "";
            txtdescricao.Text = "";

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                pdados.Enabled = true;
                btnnovo.Enabled = false;
                btnlocalizar.Enabled = false;
                btnalterar.Enabled = false;
                btncancelar.Enabled = true;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = true;
                txtdescricao.Focus();
            }
            else MessageBox.Show("Localize a categoria");
        }


        public Categoria carregaPropriedades()
        {
            Categoria cat = new Categoria();
            cat.id = 0;
            cat.descricao = txtdescricao.Text;
            return cat;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtdescricao.Text != String.Empty)
                {
                    Categoria cat=  carregaPropriedades();

                    if (cat.id == 0)
                    {
                        using(Contexto_Empresa con = new Contexto_Empresa())
                        {

                            con.categorias.Add(cat);
                            con.SaveChanges();
                        }
                    }
                    else
                    //alterar
                    {
                        using (Contexto_Empresa con = new Contexto_Empresa())
                        {
                            //Recuperar o Objeto
                            var catAux = con.categorias.Where(c=>c.id==int.Parse(txtid.Text)).FirstOrDefault();
                            if(catAux != null)
                            {
                                //Carregar as propriedades novas
                                catAux.descricao = txtdescricao.Text;
                                //Indicar que o Obj foi alterado
                                con.Entry<Categoria>(catAux).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                                //Salvar
                                con.SaveChanges();
                            }
                        }
                    }
                    MessageBox.Show("Salvo com sucesso");


                    limpar();
                    pdados.Enabled = false;
                    btnnovo.Enabled = true;
                    btnlocalizar.Enabled = true;
                    btnalterar.Enabled = false;
                    btncancelar.Enabled = false;
                    btnexcluir.Enabled = false;
                    btnsalvar.Enabled = false;

                }
                else MessageBox.Show("Preencha os campos");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar! " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
            pdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                using (Contexto_Empresa con = new Contexto_Empresa())
                {
                    //Recuperar o Objeto
                    var catAux = con.categorias.Where(c => c.id == int.Parse(txtid.Text)).FirstOrDefault();
                    if (catAux != null)
                    {
                        //Indicar que o Obj foi alterado
                        con.Entry<Categoria>(catAux).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        //Salvar
                        con.SaveChanges();
                    }
                }

                MessageBox.Show("Excluído com sucesso");
                limpar();
                pdados.Enabled = false;
                btnnovo.Enabled = true;
                btnlocalizar.Enabled = true;
                btnalterar.Enabled = false;
                btncancelar.Enabled = false;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = false;

            }
            else MessageBox.Show("Localize a categoria");
        }

        private void btnlocalizar_Click(object sender, EventArgs e)
        {

            var form2 = new FrmConsultaCategoria();
            form2.ShowDialog();

            

            if (form2.id > 0)
            {
                //select * from categoria where id = 2
                using (Contexto_Empresa con = new Contexto_Empresa())
                {
                    var cat = con.categorias.Where(p=>p.id==form2.id).FirstOrDefault();
                    if(cat != null)
                    {
                        txtid.Text = cat.id.ToString();
                        txtdescricao.Text = cat.descricao;
                    }
                }
             
                pdados.Enabled = false;
                btnnovo.Enabled = false;
                btnlocalizar.Enabled = false;
                btnalterar.Enabled = true;
                btncancelar.Enabled = true;
                btnexcluir.Enabled = true;
                btnsalvar.Enabled = false;
            }
        }
    }
}
