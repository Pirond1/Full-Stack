namespace Projeto2025_exemplo
{
    partial class FrmConsultaCategoria
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
            label1 = new Label();
            txtDescricao = new TextBox();
            button1 = new Button();
            gdDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gdDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 27);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(353, 23);
            txtDescricao.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(407, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gdDados
            // 
            gdDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdDados.Location = new Point(12, 72);
            gdDados.Name = "gdDados";
            gdDados.Size = new Size(482, 255);
            gdDados.TabIndex = 3;
            gdDados.CellDoubleClick += gdDados_CellDoubleClick;
            // 
            // FrmConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 339);
            Controls.Add(gdDados);
            Controls.Add(button1);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Name = "FrmConsultaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta da Categoria";
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescricao;
        private Button button1;
        private DataGridView gdDados;
    }
}