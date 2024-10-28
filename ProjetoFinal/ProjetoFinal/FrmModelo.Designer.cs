namespace ProjetoFinal
{
    partial class FrmModelo
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
            txtModelo = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            pDados = new Panel();
            cbbMarca = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            btnLocalizar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            pDados.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(16, 92);
            txtModelo.MaxLength = 50;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(229, 23);
            txtModelo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Marca";
            // 
            // txtID
            // 
            txtID.Location = new Point(16, 29);
            txtID.MaxLength = 150;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(136, 23);
            txtID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Código";
            // 
            // pDados
            // 
            pDados.Controls.Add(cbbMarca);
            pDados.Controls.Add(label3);
            pDados.Controls.Add(txtID);
            pDados.Controls.Add(txtModelo);
            pDados.Controls.Add(label1);
            pDados.Controls.Add(label2);
            pDados.Location = new Point(12, 12);
            pDados.Name = "pDados";
            pDados.Size = new Size(495, 141);
            pDados.TabIndex = 12;
            // 
            // cbbMarca
            // 
            cbbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMarca.FormattingEnabled = true;
            cbbMarca.Location = new Point(279, 92);
            cbbMarca.Name = "cbbMarca";
            cbbMarca.Size = new Size(202, 23);
            cbbMarca.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 73);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Modelo";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLocalizar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnNovo);
            panel1.Location = new Point(12, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 68);
            panel1.TabIndex = 13;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(412, 18);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(75, 31);
            btnLocalizar.TabIndex = 17;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(331, 18);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 18);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 31);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(169, 18);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(88, 18);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 31);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(7, 18);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 31);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // FrmModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 231);
            Controls.Add(panel1);
            Controls.Add(pDados);
            Name = "FrmModelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModelo";
            Load += FrmModelo_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtModelo;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel pDados;
        private ComboBox cbbMarca;
        private Label label3;
        private Panel panel1;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnNovo;
    }
}