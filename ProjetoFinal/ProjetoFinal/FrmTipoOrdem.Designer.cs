namespace ProjetoFinal
{
    partial class FrmTipoOrdem
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
            txtTipoOrdem = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            pDados = new Panel();
            pBotoes = new Panel();
            btnLocalizar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pDados.SuspendLayout();
            pBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // txtTipoOrdem
            // 
            txtTipoOrdem.Location = new Point(8, 90);
            txtTipoOrdem.MaxLength = 150;
            txtTipoOrdem.Name = "txtTipoOrdem";
            txtTipoOrdem.Size = new Size(474, 23);
            txtTipoOrdem.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 69);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 10;
            label2.Text = "Tipo de Ordem";
            // 
            // txtID
            // 
            txtID.Location = new Point(8, 27);
            txtID.MaxLength = 150;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(136, 23);
            txtID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Código";
            // 
            // pDados
            // 
            pDados.Controls.Add(txtID);
            pDados.Controls.Add(txtTipoOrdem);
            pDados.Controls.Add(label1);
            pDados.Controls.Add(label2);
            pDados.Location = new Point(9, 9);
            pDados.Name = "pDados";
            pDados.Size = new Size(493, 126);
            pDados.TabIndex = 12;
            // 
            // pBotoes
            // 
            pBotoes.Controls.Add(btnLocalizar);
            pBotoes.Controls.Add(btnAlterar);
            pBotoes.Controls.Add(btnExcluir);
            pBotoes.Controls.Add(btnNovo);
            pBotoes.Controls.Add(btnCancelar);
            pBotoes.Controls.Add(btnSalvar);
            pBotoes.Location = new Point(9, 142);
            pBotoes.Name = "pBotoes";
            pBotoes.Size = new Size(493, 51);
            pBotoes.TabIndex = 13;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(411, 10);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(75, 31);
            btnLocalizar.TabIndex = 19;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(87, 10);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 31);
            btnAlterar.TabIndex = 15;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(330, 10);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(6, 10);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 31);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(249, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 31);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(168, 10);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmTipoOrdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 202);
            Controls.Add(pBotoes);
            Controls.Add(pDados);
            Name = "FrmTipoOrdem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTipoOrdem";
            Load += FrmTipoOrdem_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            pBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTipoOrdem;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel pDados;
        private Panel pBotoes;
        private Button btnLocalizar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}