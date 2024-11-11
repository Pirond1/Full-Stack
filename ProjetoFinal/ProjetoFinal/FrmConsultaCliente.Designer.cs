namespace ProjetoFinal
{
    partial class FrmConsultaCliente
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
            txtCliente = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdDados).BeginInit();
            SuspendLayout();
            // 
            // gdDados
            // 
            gdDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdDados.Location = new Point(12, 68);
            gdDados.Name = "gdDados";
            gdDados.Size = new Size(403, 216);
            gdDados.TabIndex = 11;
            gdDados.CellContentClick += gdDados_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(340, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(12, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(306, 23);
            txtCliente.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome Cliente";
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 292);
            Controls.Add(gdDados);
            Controls.Add(button1);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "FrmConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaCliente";
            Load += FrmConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdDados;
        private Button button1;
        private TextBox txtCliente;
        private Label label1;
    }
}