namespace ProjetoAdo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbDados = new GroupBox();
            txtNascimento = new DateTimePicker();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            gbBotoes = new GroupBox();
            btnLocalizar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            gbDados.SuspendLayout();
            gbBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // gbDados
            // 
            gbDados.Controls.Add(txtNascimento);
            gbDados.Controls.Add(label3);
            gbDados.Controls.Add(txtNome);
            gbDados.Controls.Add(label2);
            gbDados.Controls.Add(txtID);
            gbDados.Controls.Add(label1);
            gbDados.Dock = DockStyle.Top;
            gbDados.Location = new Point(0, 0);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(376, 228);
            gbDados.TabIndex = 0;
            gbDados.TabStop = false;
            // 
            // txtNascimento
            // 
            txtNascimento.Format = DateTimePickerFormat.Short;
            txtNascimento.Location = new Point(125, 139);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(120, 23);
            txtNascimento.TabIndex = 3;
            txtNascimento.Value = new DateTime(2024, 8, 26, 19, 58, 52, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 121);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Data Nascimento:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(120, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 65);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(125, 33);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 23);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // gbBotoes
            // 
            gbBotoes.Controls.Add(btnLocalizar);
            gbBotoes.Controls.Add(btnExcluir);
            gbBotoes.Controls.Add(btnCancelar);
            gbBotoes.Controls.Add(btnSalvar);
            gbBotoes.Controls.Add(btnAlterar);
            gbBotoes.Controls.Add(btnNovo);
            gbBotoes.Dock = DockStyle.Bottom;
            gbBotoes.Location = new Point(0, 228);
            gbBotoes.Name = "gbBotoes";
            gbBotoes.Size = new Size(376, 128);
            gbBotoes.TabIndex = 1;
            gbBotoes.TabStop = false;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(283, 23);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(78, 31);
            btnLocalizar.TabIndex = 9;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(148, 78);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(78, 31);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(15, 78);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 31);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(283, 78);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 31);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(148, 23);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(78, 31);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(15, 23);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(78, 31);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 356);
            Controls.Add(gbBotoes);
            Controls.Add(gbDados);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            gbBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDados;
        private Button btnNovo;
        private DateTimePicker txtNascimento;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private GroupBox gbBotoes;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
    }
}
