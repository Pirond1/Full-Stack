namespace Projeto2025_exemplo
{
    partial class FrmProduto
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
            pDados = new Panel();
            label6 = new Label();
            ckbAtivo = new CheckBox();
            label4 = new Label();
            txtQuantidade = new TextBox();
            cbbCategoria = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            pBotoes = new Panel();
            btnLocalizar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            pDados.SuspendLayout();
            pBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pDados
            // 
            pDados.Controls.Add(label6);
            pDados.Controls.Add(ckbAtivo);
            pDados.Controls.Add(label4);
            pDados.Controls.Add(txtQuantidade);
            pDados.Controls.Add(cbbCategoria);
            pDados.Controls.Add(label5);
            pDados.Controls.Add(label3);
            pDados.Controls.Add(txtValor);
            pDados.Controls.Add(label2);
            pDados.Controls.Add(txtDescricao);
            pDados.Controls.Add(label1);
            pDados.Controls.Add(txtID);
            pDados.Location = new Point(5, 12);
            pDados.Name = "pDados";
            pDados.Size = new Size(792, 187);
            pDados.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 123);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "Ativar";
            // 
            // ckbAtivo
            // 
            ckbAtivo.AutoSize = true;
            ckbAtivo.Location = new Point(449, 144);
            ckbAtivo.Name = "ckbAtivo";
            ckbAtivo.Size = new Size(54, 19);
            ckbAtivo.TabIndex = 6;
            ckbAtivo.Text = "Ativo";
            ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 123);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(242, 141);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(188, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // cbbCategoria
            // 
            cbbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Location = new Point(572, 144);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(188, 23);
            cbbCategoria.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 123);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 123);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(20, 141);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(188, 23);
            txtValor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(20, 80);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(740, 23);
            txtDescricao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // txtID
            // 
            txtID.Location = new Point(20, 27);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // pBotoes
            // 
            pBotoes.Controls.Add(btnLocalizar);
            pBotoes.Controls.Add(btnExcluir);
            pBotoes.Controls.Add(btnCancelar);
            pBotoes.Controls.Add(btnSalvar);
            pBotoes.Controls.Add(btnAlterar);
            pBotoes.Controls.Add(btnNovo);
            pBotoes.Location = new Point(5, 205);
            pBotoes.Name = "pBotoes";
            pBotoes.Size = new Size(792, 89);
            pBotoes.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(659, 29);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(88, 31);
            btnLocalizar.TabIndex = 13;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(539, 29);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 31);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(415, 29);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 31);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(291, 29);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 31);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(166, 29);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(88, 31);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(44, 29);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 31);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(pBotoes);
            Controls.Add(pDados);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            pBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pDados;
        private TextBox txtID;
        private Panel pBotoes;
        private Label label1;
        private Label label3;
        private TextBox txtValor;
        private Label label2;
        private TextBox txtDescricao;
        private Label label5;
        private ComboBox cbbCategoria;
        private Label label4;
        private TextBox txtQuantidade;
        private Label label6;
        private CheckBox ckbAtivo;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnNovo;
    }
}