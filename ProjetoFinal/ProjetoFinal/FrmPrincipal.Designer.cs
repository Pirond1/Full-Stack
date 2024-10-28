namespace ProjetoFinal
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
            menuStrip1 = new MenuStrip();
            criaçãoDeCadastrosToolStripMenuItem = new ToolStripMenuItem();
            marcaToolStripMenuItem = new ToolStripMenuItem();
            modeloToolStripMenuItem = new ToolStripMenuItem();
            automóvelToolStripMenuItem = new ToolStripMenuItem();
            tipoDeOrdemToolStripMenuItem = new ToolStripMenuItem();
            pagamentoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { criaçãoDeCadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // criaçãoDeCadastrosToolStripMenuItem
            // 
            criaçãoDeCadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marcaToolStripMenuItem, modeloToolStripMenuItem, automóvelToolStripMenuItem, tipoDeOrdemToolStripMenuItem, pagamentoToolStripMenuItem });
            criaçãoDeCadastrosToolStripMenuItem.Name = "criaçãoDeCadastrosToolStripMenuItem";
            criaçãoDeCadastrosToolStripMenuItem.Size = new Size(130, 20);
            criaçãoDeCadastrosToolStripMenuItem.Text = "Criação de Cadastros";
            // 
            // marcaToolStripMenuItem
            // 
            marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            marcaToolStripMenuItem.Size = new Size(180, 22);
            marcaToolStripMenuItem.Text = "Marca";
            marcaToolStripMenuItem.Click += marcaToolStripMenuItem_Click;
            // 
            // modeloToolStripMenuItem
            // 
            modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            modeloToolStripMenuItem.Size = new Size(180, 22);
            modeloToolStripMenuItem.Text = "Modelo";
            modeloToolStripMenuItem.Click += modeloToolStripMenuItem_Click;
            // 
            // automóvelToolStripMenuItem
            // 
            automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            automóvelToolStripMenuItem.Size = new Size(180, 22);
            automóvelToolStripMenuItem.Text = "Automóvel";
            automóvelToolStripMenuItem.Click += automóvelToolStripMenuItem_Click;
            // 
            // tipoDeOrdemToolStripMenuItem
            // 
            tipoDeOrdemToolStripMenuItem.Name = "tipoDeOrdemToolStripMenuItem";
            tipoDeOrdemToolStripMenuItem.Size = new Size(180, 22);
            tipoDeOrdemToolStripMenuItem.Text = "Tipo de Ordem";
            tipoDeOrdemToolStripMenuItem.Click += tipoDeOrdemToolStripMenuItem_Click;
            // 
            // pagamentoToolStripMenuItem
            // 
            pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            pagamentoToolStripMenuItem.Size = new Size(180, 22);
            pagamentoToolStripMenuItem.Text = "Pagamento";
            pagamentoToolStripMenuItem.Click += pagamentoToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem criaçãoDeCadastrosToolStripMenuItem;
        private ToolStripMenuItem marcaToolStripMenuItem;
        private ToolStripMenuItem modeloToolStripMenuItem;
        private ToolStripMenuItem automóvelToolStripMenuItem;
        private ToolStripMenuItem tipoDeOrdemToolStripMenuItem;
        private ToolStripMenuItem pagamentoToolStripMenuItem;
    }
}