namespace Projeto2025_exemplo
{
    partial class FrmCadCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdados = new Panel();
            txtdescricao = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label1 = new Label();
            pbotoes = new Panel();
            btnlocalizar = new Button();
            btnexcluir = new Button();
            btncancelar = new Button();
            btnsalvar = new Button();
            btnalterar = new Button();
            btnnovo = new Button();
            pdados.SuspendLayout();
            pbotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pdados
            // 
            pdados.Controls.Add(txtdescricao);
            pdados.Controls.Add(label2);
            pdados.Controls.Add(txtid);
            pdados.Controls.Add(label1);
            pdados.Dock = DockStyle.Top;
            pdados.Location = new Point(0, 0);
            pdados.Margin = new Padding(3, 4, 3, 4);
            pdados.Name = "pdados";
            pdados.Size = new Size(758, 360);
            pdados.TabIndex = 0;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(32, 137);
            txtdescricao.Margin = new Padding(3, 4, 3, 4);
            txtdescricao.MaxLength = 150;
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(706, 27);
            txtdescricao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 113);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // txtid
            // 
            txtid.Location = new Point(32, 55);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(114, 27);
            txtid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // pbotoes
            // 
            pbotoes.Controls.Add(btnlocalizar);
            pbotoes.Controls.Add(btnexcluir);
            pbotoes.Controls.Add(btncancelar);
            pbotoes.Controls.Add(btnsalvar);
            pbotoes.Controls.Add(btnalterar);
            pbotoes.Controls.Add(btnnovo);
            pbotoes.Dock = DockStyle.Bottom;
            pbotoes.Location = new Point(0, 183);
            pbotoes.Margin = new Padding(3, 4, 3, 4);
            pbotoes.Name = "pbotoes";
            pbotoes.Size = new Size(758, 133);
            pbotoes.TabIndex = 1;
            // 
            // btnlocalizar
            // 
            btnlocalizar.Location = new Point(614, 40);
            btnlocalizar.Name = "btnlocalizar";
            btnlocalizar.Size = new Size(89, 40);
            btnlocalizar.TabIndex = 5;
            btnlocalizar.Text = "Localizar";
            btnlocalizar.UseVisualStyleBackColor = true;
            btnlocalizar.Click += btnlocalizar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(500, 40);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(89, 40);
            btnexcluir.TabIndex = 4;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(393, 40);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(89, 40);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(274, 40);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(89, 40);
            btnsalvar.TabIndex = 2;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(156, 40);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(89, 40);
            btnalterar.TabIndex = 1;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click;
            // 
            // btnnovo
            // 
            btnnovo.Location = new Point(42, 40);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(89, 40);
            btnnovo.TabIndex = 0;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // FrmCadCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 316);
            Controls.Add(pbotoes);
            Controls.Add(pdados);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCadCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categoria";
            Load += FrmCadCategoria_Load;
            pdados.ResumeLayout(false);
            pdados.PerformLayout();
            pbotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pdados;
        private Panel pbotoes;
        private TextBox txtdescricao;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private Button btnlocalizar;
        private Button btnexcluir;
        private Button btncancelar;
        private Button btnsalvar;
        private Button btnalterar;
        private Button btnnovo;
    }
}