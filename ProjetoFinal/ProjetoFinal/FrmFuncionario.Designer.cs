namespace ProjetoFinal
{
    partial class FrmFuncionario
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
            label3 = new Label();
            txtID = new TextBox();
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            txtNascimento = new DateTimePicker();
            label6 = new Label();
            txtSalario = new TextBox();
            pDados = new Panel();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 65);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 22;
            label3.Text = "Login";
            // 
            // txtID
            // 
            txtID.Location = new Point(8, 29);
            txtID.MaxLength = 150;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(136, 23);
            txtID.TabIndex = 21;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(8, 83);
            txtLogin.MaxLength = 50;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(229, 23);
            txtLogin.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 20;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 11);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 24;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(281, 29);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(229, 23);
            txtNome.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 65);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 26;
            label4.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(281, 83);
            txtSenha.MaxLength = 50;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(229, 23);
            txtSenha.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 120);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 27;
            label5.Text = "Data de Nascimento";
            // 
            // txtNascimento
            // 
            txtNascimento.Format = DateTimePickerFormat.Short;
            txtNascimento.Location = new Point(8, 138);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(114, 23);
            txtNascimento.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 120);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 29;
            label6.Text = "Salário";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(281, 141);
            txtSalario.MaxLength = 50;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(229, 23);
            txtSalario.TabIndex = 30;
            // 
            // pDados
            // 
            pDados.Controls.Add(txtNome);
            pDados.Controls.Add(txtSalario);
            pDados.Controls.Add(label1);
            pDados.Controls.Add(label6);
            pDados.Controls.Add(txtLogin);
            pDados.Controls.Add(txtNascimento);
            pDados.Controls.Add(txtID);
            pDados.Controls.Add(label5);
            pDados.Controls.Add(label3);
            pDados.Controls.Add(label4);
            pDados.Controls.Add(label2);
            pDados.Controls.Add(txtSenha);
            pDados.Location = new Point(12, 12);
            pDados.Name = "pDados";
            pDados.Size = new Size(523, 187);
            pDados.TabIndex = 31;
            // 
            // pBotoes
            // 
            pBotoes.Controls.Add(btnLocalizar);
            pBotoes.Controls.Add(btnExcluir);
            pBotoes.Controls.Add(btnCancelar);
            pBotoes.Controls.Add(btnSalvar);
            pBotoes.Controls.Add(btnAlterar);
            pBotoes.Controls.Add(btnNovo);
            pBotoes.Location = new Point(12, 205);
            pBotoes.Name = "pBotoes";
            pBotoes.Size = new Size(523, 60);
            pBotoes.TabIndex = 31;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(431, 13);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(75, 31);
            btnLocalizar.TabIndex = 12;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(347, 13);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(263, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 31);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(179, 13);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(95, 13);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 31);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(11, 13);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 31);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 273);
            Controls.Add(pBotoes);
            Controls.Add(pDados);
            Name = "FrmFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFuncionario";
            Load += FrmFuncionario_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            pBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private TextBox txtID;
        private TextBox txtLogin;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label4;
        private TextBox txtSenha;
        private Label label5;
        private DateTimePicker txtNascimento;
        private Label label6;
        private TextBox txtSalario;
        private Panel pDados;
        private Panel pBotoes;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnNovo;
    }
}