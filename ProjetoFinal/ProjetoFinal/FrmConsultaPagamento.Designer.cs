namespace ProjetoFinal
{
    partial class FrmConsultaPagamento
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
            txtPagamento = new TextBox();
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
            // txtPagamento
            // 
            txtPagamento.Location = new Point(12, 26);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(306, 23);
            txtPagamento.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Forma de Pagamento";
            // 
            // FrmConsultaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 290);
            Controls.Add(gdDados);
            Controls.Add(button1);
            Controls.Add(txtPagamento);
            Controls.Add(label1);
            Name = "FrmConsultaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaPagamento";
            Load += FrmConsultaPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdDados;
        private Button button1;
        private TextBox txtPagamento;
        private Label label1;
    }
}