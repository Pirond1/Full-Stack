namespace ProjetoFinal
{
    partial class FrmConsultaOrdem
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
            txtOrdem = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdDados).BeginInit();
            SuspendLayout();
            // 
            // gdDados
            // 
            gdDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdDados.Location = new Point(12, 69);
            gdDados.Name = "gdDados";
            gdDados.Size = new Size(403, 216);
            gdDados.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(340, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(12, 25);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(306, 23);
            txtOrdem.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 8;
            label1.Text = "ID Ordem";
            // 
            // FrmConsultaOrdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 299);
            Controls.Add(gdDados);
            Controls.Add(button1);
            Controls.Add(txtOrdem);
            Controls.Add(label1);
            Name = "FrmConsultaOrdem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaOrdem";
            Load += FrmConsultaOrdem_Load;
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdDados;
        private Button button1;
        private TextBox txtOrdem;
        private Label label1;
    }
}