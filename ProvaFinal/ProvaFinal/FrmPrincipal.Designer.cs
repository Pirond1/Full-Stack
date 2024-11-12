namespace ProvaFinal
{
    partial class FrmPrincipal
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
            btnCliente = new Button();
            btnEndereco = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.Location = new Point(38, 37);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(104, 44);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnEndereco
            // 
            btnEndereco.Font = new Font("Segoe UI", 12F);
            btnEndereco.Location = new Point(209, 37);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(104, 44);
            btnEndereco.TabIndex = 1;
            btnEndereco.Text = "Endereços";
            btnEndereco.UseVisualStyleBackColor = true;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 112);
            Controls.Add(btnEndereco);
            Controls.Add(btnCliente);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnEndereco;
    }
}