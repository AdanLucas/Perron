
namespace Perron.View.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemIngrediente = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1330, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saborToolStripMenuItem,
            this.tamanhoToolStripMenuItem,
            this.preçoToolStripMenuItem,
            this.menuItemIngrediente});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // saborToolStripMenuItem
            // 
            this.saborToolStripMenuItem.Name = "saborToolStripMenuItem";
            this.saborToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.saborToolStripMenuItem.Text = "Sabor";
            // 
            // tamanhoToolStripMenuItem
            // 
            this.tamanhoToolStripMenuItem.Name = "tamanhoToolStripMenuItem";
            this.tamanhoToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.tamanhoToolStripMenuItem.Text = "Tamanho";
            // 
            // preçoToolStripMenuItem
            // 
            this.preçoToolStripMenuItem.Name = "preçoToolStripMenuItem";
            this.preçoToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.preçoToolStripMenuItem.Text = "Preço";
            // 
            // menuItemIngrediente
            // 
            this.menuItemIngrediente.Name = "menuItemIngrediente";
            this.menuItemIngrediente.Size = new System.Drawing.Size(199, 32);
            this.menuItemIngrediente.Text = "Ingrediente";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 829);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria Perron";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamanhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemIngrediente;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}