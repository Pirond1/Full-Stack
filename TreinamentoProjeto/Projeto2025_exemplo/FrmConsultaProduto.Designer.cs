namespace Projeto2025_exemplo
{
    partial class FrmConsultaProduto
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
            button1 = new Button();
            txtDescricao = new TextBox();
            label1 = new Label();
            gdDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gdDados).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(410, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Localizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 28);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(353, 23);
            txtDescricao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Descrição";
            // 
            // gdDados
            // 
            gdDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdDados.Location = new Point(12, 67);
            gdDados.Name = "gdDados";
            gdDados.Size = new Size(482, 255);
            gdDados.TabIndex = 6;
            gdDados.CellContentClick += gdDados_CellContentClick;
            // 
            // FrmConsultaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 333);
            Controls.Add(gdDados);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmConsultaProduto";
            Text = "FrmConsultaProduto";
            ((System.ComponentModel.ISupportInitialize)gdDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtDescricao;
        private Label label1;
        private DataGridView gdDados;
    }
}