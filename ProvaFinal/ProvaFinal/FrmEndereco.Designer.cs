namespace ProvaFinal
{
    partial class FrmEndereco
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
            btnSalvar = new Button();
            txtCidade = new TextBox();
            label2 = new Label();
            txtRua = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cbbCliente = new ComboBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(127, 152);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 42);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(68, 61);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(273, 23);
            txtCidade.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 64);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Cidade:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(68, 20);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(273, 23);
            txtRua.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 103);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Cliente:";
            // 
            // cbbCliente
            // 
            cbbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCliente.FormattingEnabled = true;
            cbbCliente.Location = new Point(68, 100);
            cbbCliente.Name = "cbbCliente";
            cbbCliente.Size = new Size(273, 23);
            cbbCliente.TabIndex = 11;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 206);
            Controls.Add(cbbCliente);
            Controls.Add(label3);
            Controls.Add(btnSalvar);
            Controls.Add(txtCidade);
            Controls.Add(label2);
            Controls.Add(txtRua);
            Controls.Add(label1);
            Name = "FrmEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEndereco";
            Load += FrmEndereco_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtCidade;
        private Label label2;
        private TextBox txtRua;
        private Label label1;
        private Label label3;
        private ComboBox cbbCliente;
    }
}