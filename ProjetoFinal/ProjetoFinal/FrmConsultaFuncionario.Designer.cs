namespace ProjetoFinal
{
    partial class FrmConsultaFuncionario
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
            gdDados = new DataGridView();
            button1 = new Button();
            txtFuncionario = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdDados).BeginInit();
            SuspendLayout();
            // 
            // gdDados
            // 
            gdDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdDados.Location = new Point(12, 70);
            gdDados.Name = "gdDados";
            gdDados.Size = new Size(403, 216);
            gdDados.TabIndex = 7;
            gdDados.CellContentClick += gdDados_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(340, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFuncionario
            // 
            txtFuncionario.Location = new Point(12, 26);
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new Size(306, 23);
            txtFuncionario.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome Funcionario";
            // 
            // FrmConsultaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 296);
            Controls.Add(gdDados);
            Controls.Add(button1);
            Controls.Add(txtFuncionario);
            Controls.Add(label1);
            Name = "FrmConsultaFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaFuncionario";
            Load += FrmConsultaFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdDados;
        private Button button1;
        private TextBox txtFuncionario;
        private Label label1;
    }
}