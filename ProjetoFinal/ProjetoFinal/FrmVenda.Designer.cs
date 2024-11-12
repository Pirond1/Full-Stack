namespace ProjetoFinal
{
    partial class FrmVenda
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
            cbbOrdem = new ComboBox();
            label5 = new Label();
            cbbPagamento = new ComboBox();
            label6 = new Label();
            txtData = new DateTimePicker();
            label3 = new Label();
            txtID = new TextBox();
            label1 = new Label();
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
            // pDados
            // 
            pDados.Controls.Add(cbbOrdem);
            pDados.Controls.Add(label5);
            pDados.Controls.Add(cbbPagamento);
            pDados.Controls.Add(label6);
            pDados.Controls.Add(txtData);
            pDados.Controls.Add(label3);
            pDados.Controls.Add(txtID);
            pDados.Controls.Add(label1);
            pDados.Location = new Point(12, 12);
            pDados.Name = "pDados";
            pDados.Size = new Size(495, 140);
            pDados.TabIndex = 14;
            // 
            // cbbOrdem
            // 
            cbbOrdem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbOrdem.FormattingEnabled = true;
            cbbOrdem.Location = new Point(279, 91);
            cbbOrdem.Name = "cbbOrdem";
            cbbOrdem.Size = new Size(202, 23);
            cbbOrdem.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 72);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 19;
            label5.Text = "Ordem";
            // 
            // cbbPagamento
            // 
            cbbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPagamento.FormattingEnabled = true;
            cbbPagamento.Location = new Point(16, 91);
            cbbPagamento.Name = "cbbPagamento";
            cbbPagamento.Size = new Size(202, 23);
            cbbPagamento.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 72);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 17;
            label6.Text = "Forma de Pagamento";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(279, 29);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 8);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 12;
            label3.Text = "Data Retirada";
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
            panel1.TabIndex = 22;
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
            // FrmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 235);
            Controls.Add(panel1);
            Controls.Add(pDados);
            Name = "FrmVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVenda";
            Load += FrmVenda_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pDados;
        private ComboBox cbbOrdem;
        private Label label5;
        private ComboBox cbbPagamento;
        private Label label6;
        private DateTimePicker txtData;
        private Label label3;
        private TextBox txtID;
        private Label label1;
        private Panel panel1;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnNovo;
    }
}