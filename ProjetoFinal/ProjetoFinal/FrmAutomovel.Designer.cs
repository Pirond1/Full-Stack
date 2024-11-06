namespace ProjetoFinal
{
    partial class FrmAutomovel
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
            txtKm = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtChassi = new TextBox();
            label5 = new Label();
            txtPortas = new TextBox();
            label4 = new Label();
            txtAno = new TextBox();
            cbbModelo = new ComboBox();
            label3 = new Label();
            txtID = new TextBox();
            txtCor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pBotoes = new Panel();
            btnLocalizar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            txtVenda = new TextBox();
            label8 = new Label();
            txtAluguel = new TextBox();
            label9 = new Label();
            pDados.SuspendLayout();
            pBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pDados
            // 
            pDados.Controls.Add(txtAluguel);
            pDados.Controls.Add(label9);
            pDados.Controls.Add(txtVenda);
            pDados.Controls.Add(label8);
            pDados.Controls.Add(txtKm);
            pDados.Controls.Add(label7);
            pDados.Controls.Add(label6);
            pDados.Controls.Add(txtChassi);
            pDados.Controls.Add(label5);
            pDados.Controls.Add(txtPortas);
            pDados.Controls.Add(label4);
            pDados.Controls.Add(txtAno);
            pDados.Controls.Add(cbbModelo);
            pDados.Controls.Add(label3);
            pDados.Controls.Add(txtID);
            pDados.Controls.Add(txtCor);
            pDados.Controls.Add(label1);
            pDados.Controls.Add(label2);
            pDados.Location = new Point(10, 6);
            pDados.Name = "pDados";
            pDados.Size = new Size(497, 269);
            pDados.TabIndex = 0;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(10, 161);
            txtKm.MaxLength = 50;
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(229, 23);
            txtKm.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 143);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 26;
            label7.Text = "Quilometragem";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 73);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 25;
            label6.Text = "Nº Chassi";
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(259, 91);
            txtChassi.MaxLength = 50;
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(229, 23);
            txtChassi.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 10);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 23;
            label5.Text = "Nº Portas";
            // 
            // txtPortas
            // 
            txtPortas.Location = new Point(386, 28);
            txtPortas.MaxLength = 4;
            txtPortas.Name = "txtPortas";
            txtPortas.Size = new Size(102, 23);
            txtPortas.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 10);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 21;
            label4.Text = "Ano";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(259, 28);
            txtAno.MaxLength = 4;
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(102, 23);
            txtAno.TabIndex = 1;
            // 
            // cbbModelo
            // 
            cbbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbModelo.FormattingEnabled = true;
            cbbModelo.Location = new Point(259, 161);
            cbbModelo.Name = "cbbModelo";
            cbbModelo.Size = new Size(229, 23);
            cbbModelo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 73);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 18;
            label3.Text = "Cor";
            // 
            // txtID
            // 
            txtID.Location = new Point(10, 28);
            txtID.MaxLength = 150;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(136, 23);
            txtID.TabIndex = 15;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(10, 91);
            txtCor.MaxLength = 50;
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(229, 23);
            txtCor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 143);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 16;
            label2.Text = "Modelo";
            // 
            // pBotoes
            // 
            pBotoes.Controls.Add(btnLocalizar);
            pBotoes.Controls.Add(btnExcluir);
            pBotoes.Controls.Add(btnCancelar);
            pBotoes.Controls.Add(btnSalvar);
            pBotoes.Controls.Add(btnAlterar);
            pBotoes.Controls.Add(btnNovo);
            pBotoes.Location = new Point(10, 291);
            pBotoes.Name = "pBotoes";
            pBotoes.Size = new Size(497, 60);
            pBotoes.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(412, 13);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(75, 31);
            btnLocalizar.TabIndex = 12;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(331, 13);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 31);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(169, 13);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(88, 13);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 31);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(7, 13);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 31);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(10, 228);
            txtVenda.MaxLength = 50;
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(229, 23);
            txtVenda.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 210);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 28;
            label8.Text = "Valor de Venda";
            // 
            // txtAluguel
            // 
            txtAluguel.Location = new Point(259, 228);
            txtAluguel.MaxLength = 50;
            txtAluguel.Name = "txtAluguel";
            txtAluguel.Size = new Size(229, 23);
            txtAluguel.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 210);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 30;
            label9.Text = "Valor de Alguel";
            // 
            // FrmAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 359);
            Controls.Add(pBotoes);
            Controls.Add(pDados);
            Name = "FrmAutomovel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAutomovel";
            Load += FrmAutomovel_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            pBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pDados;
        private ComboBox cbbModelo;
        private Label label3;
        private TextBox txtID;
        private TextBox txtCor;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtAno;
        private Label label5;
        private TextBox txtPortas;
        private Label label6;
        private TextBox txtChassi;
        private TextBox txtKm;
        private Label label7;
        private Panel pBotoes;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnNovo;
        private TextBox txtAluguel;
        private Label label9;
        private TextBox txtVenda;
        private Label label8;
    }
}