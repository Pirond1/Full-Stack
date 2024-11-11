namespace ProjetoFinal
{
    partial class FrmOrdem
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
            cbbCliente = new ComboBox();
            label5 = new Label();
            cbbFuncionario = new ComboBox();
            label6 = new Label();
            cbbTipoOrdem = new ComboBox();
            label4 = new Label();
            txtData = new DateTimePicker();
            cbbAutomovel = new ComboBox();
            label3 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
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
            pDados.Controls.Add(cbbCliente);
            pDados.Controls.Add(label5);
            pDados.Controls.Add(cbbFuncionario);
            pDados.Controls.Add(label6);
            pDados.Controls.Add(cbbTipoOrdem);
            pDados.Controls.Add(label4);
            pDados.Controls.Add(txtData);
            pDados.Controls.Add(cbbAutomovel);
            pDados.Controls.Add(label3);
            pDados.Controls.Add(txtID);
            pDados.Controls.Add(label1);
            pDados.Controls.Add(label2);
            pDados.Location = new Point(12, 12);
            pDados.Name = "pDados";
            pDados.Size = new Size(495, 197);
            pDados.TabIndex = 13;
            // 
            // cbbCliente
            // 
            cbbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCliente.FormattingEnabled = true;
            cbbCliente.Location = new Point(279, 150);
            cbbCliente.Name = "cbbCliente";
            cbbCliente.Size = new Size(202, 23);
            cbbCliente.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 131);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 19;
            label5.Text = "CPF Cliente";
            // 
            // cbbFuncionario
            // 
            cbbFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFuncionario.FormattingEnabled = true;
            cbbFuncionario.Location = new Point(16, 150);
            cbbFuncionario.Name = "cbbFuncionario";
            cbbFuncionario.Size = new Size(202, 23);
            cbbFuncionario.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 131);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 17;
            label6.Text = "Nome Funcionario";
            // 
            // cbbTipoOrdem
            // 
            cbbTipoOrdem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoOrdem.FormattingEnabled = true;
            cbbTipoOrdem.Location = new Point(279, 94);
            cbbTipoOrdem.Name = "cbbTipoOrdem";
            cbbTipoOrdem.Size = new Size(202, 23);
            cbbTipoOrdem.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 75);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 15;
            label4.Text = "Tipo de Ordem";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(279, 29);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 14;
            // 
            // cbbAutomovel
            // 
            cbbAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAutomovel.FormattingEnabled = true;
            cbbAutomovel.Location = new Point(16, 94);
            cbbAutomovel.Name = "cbbAutomovel";
            cbbAutomovel.Size = new Size(202, 23);
            cbbAutomovel.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 8);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 12;
            label3.Text = "Data Ordem";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 10;
            label2.Text = "Chassi Automóvel";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLocalizar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnNovo);
            panel1.Location = new Point(12, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 68);
            panel1.TabIndex = 21;
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
            // FrmOrdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 294);
            Controls.Add(panel1);
            Controls.Add(pDados);
            Name = "FrmOrdem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOrdem";
            Load += FrmOrdem_Load;
            pDados.ResumeLayout(false);
            pDados.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pDados;
        private DateTimePicker txtData;
        private ComboBox cbbAutomovel;
        private Label label3;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private ComboBox cbbTipoOrdem;
        private Label label4;
        private ComboBox cbbCliente;
        private Label label5;
        private ComboBox cbbFuncionario;
        private Label label6;
        private Panel panel1;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnNovo;
    }
}