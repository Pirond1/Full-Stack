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
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            criaçãoDePedidosToolStripMenuItem = new ToolStripMenuItem();
            ordemToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            aluguelToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { criaçãoDeCadastrosToolStripMenuItem, criaçãoDePedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(270, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // criaçãoDeCadastrosToolStripMenuItem
            // 
            criaçãoDeCadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marcaToolStripMenuItem, modeloToolStripMenuItem, automóvelToolStripMenuItem, tipoDeOrdemToolStripMenuItem, pagamentoToolStripMenuItem, funcionarioToolStripMenuItem, clienteToolStripMenuItem });
            criaçãoDeCadastrosToolStripMenuItem.Name = "criaçãoDeCadastrosToolStripMenuItem";
            criaçãoDeCadastrosToolStripMenuItem.Size = new Size(130, 20);
            criaçãoDeCadastrosToolStripMenuItem.Text = "Criação de Cadastros";
            // 
            // marcaToolStripMenuItem
            // 
            marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            marcaToolStripMenuItem.Size = new Size(153, 22);
            marcaToolStripMenuItem.Text = "Marca";
            marcaToolStripMenuItem.Click += marcaToolStripMenuItem_Click;
            // 
            // modeloToolStripMenuItem
            // 
            modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            modeloToolStripMenuItem.Size = new Size(153, 22);
            modeloToolStripMenuItem.Text = "Modelo";
            modeloToolStripMenuItem.Click += modeloToolStripMenuItem_Click;
            // 
            // automóvelToolStripMenuItem
            // 
            automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            automóvelToolStripMenuItem.Size = new Size(153, 22);
            automóvelToolStripMenuItem.Text = "Automóvel";
            automóvelToolStripMenuItem.Click += automóvelToolStripMenuItem_Click;
            // 
            // tipoDeOrdemToolStripMenuItem
            // 
            tipoDeOrdemToolStripMenuItem.Name = "tipoDeOrdemToolStripMenuItem";
            tipoDeOrdemToolStripMenuItem.Size = new Size(153, 22);
            tipoDeOrdemToolStripMenuItem.Text = "Tipo de Ordem";
            tipoDeOrdemToolStripMenuItem.Click += tipoDeOrdemToolStripMenuItem_Click;
            // 
            // pagamentoToolStripMenuItem
            // 
            pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            pagamentoToolStripMenuItem.Size = new Size(153, 22);
            pagamentoToolStripMenuItem.Text = "Pagamento";
            pagamentoToolStripMenuItem.Click += pagamentoToolStripMenuItem_Click;
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(153, 22);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            funcionarioToolStripMenuItem.Click += funcionarioToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(153, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // criaçãoDePedidosToolStripMenuItem
            // 
            criaçãoDePedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordemToolStripMenuItem, vendaToolStripMenuItem, aluguelToolStripMenuItem });
            criaçãoDePedidosToolStripMenuItem.Name = "criaçãoDePedidosToolStripMenuItem";
            criaçãoDePedidosToolStripMenuItem.Size = new Size(120, 20);
            criaçãoDePedidosToolStripMenuItem.Text = "Criação de Pedidos";
            // 
            // ordemToolStripMenuItem
            // 
            ordemToolStripMenuItem.Name = "ordemToolStripMenuItem";
            ordemToolStripMenuItem.Size = new Size(180, 22);
            ordemToolStripMenuItem.Text = "Ordem";
            ordemToolStripMenuItem.Click += ordemToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(180, 22);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // aluguelToolStripMenuItem
            // 
            aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            aluguelToolStripMenuItem.Size = new Size(180, 22);
            aluguelToolStripMenuItem.Text = "Aluguel";
            aluguelToolStripMenuItem.Click += aluguelToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 254);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
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
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem criaçãoDePedidosToolStripMenuItem;
        private ToolStripMenuItem ordemToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem aluguelToolStripMenuItem;
    }
}