namespace ProjetoFinal
{
    partial class FrmConsultaVenda
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
            txtVenda = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdDados).BeginInit();
            SuspendLayout();
            // 
            // gdDados
            // 
            gdDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdDados.Location = new Point(12, 71);
            gdDados.Name = "gdDados";
            gdDados.Size = new Size(403, 216);
            gdDados.TabIndex = 11;
            gdDados.CellContentClick += gdDados_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(340, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(12, 27);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(306, 23);
            txtVenda.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "ID Venda";
            // 
            // FrmConsultaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 298);
            Controls.Add(gdDados);
            Controls.Add(button1);
            Controls.Add(txtVenda);
            Controls.Add(label1);
            Name = "FrmConsultaVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaVenda";
            Load += FrmConsultaVenda_Load;
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdDados;
        private Button button1;
        private TextBox txtVenda;
        private Label label1;
    }
}