
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
            this.menuItemClasse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTamanho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemIngrediente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastroPreco = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastroPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1330, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClasse,
            this.menuItemTamanho,
            this.menuItemIngrediente,
            this.menuItemProduto,
            this.menuItemCadastroPreco,
            this.menuItemCadastroPessoa});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuItemClasse
            // 
            this.menuItemClasse.Name = "menuItemClasse";
            this.menuItemClasse.Size = new System.Drawing.Size(173, 28);
            this.menuItemClasse.Text = "Classe";
            // 
            // menuItemTamanho
            // 
            this.menuItemTamanho.Name = "menuItemTamanho";
            this.menuItemTamanho.Size = new System.Drawing.Size(173, 28);
            this.menuItemTamanho.Text = "Tamanho";
            // 
            // menuItemIngrediente
            // 
            this.menuItemIngrediente.Name = "menuItemIngrediente";
            this.menuItemIngrediente.Size = new System.Drawing.Size(173, 28);
            this.menuItemIngrediente.Text = "Mecadoria";
            // 
            // menuItemProduto
            // 
            this.menuItemProduto.Name = "menuItemProduto";
            this.menuItemProduto.Size = new System.Drawing.Size(173, 28);
            this.menuItemProduto.Text = "Produto";
            // 
            // menuItemCadastroPreco
            // 
            this.menuItemCadastroPreco.Name = "menuItemCadastroPreco";
            this.menuItemCadastroPreco.Size = new System.Drawing.Size(173, 28);
            this.menuItemCadastroPreco.Text = "Preço";
            // 
            // menuItemCadastroPessoa
            // 
            this.menuItemCadastroPessoa.Name = "menuItemCadastroPessoa";
            this.menuItemCadastroPessoa.Size = new System.Drawing.Size(173, 28);
            this.menuItemCadastroPessoa.Text = "Pessoa";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
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
        private System.Windows.Forms.ToolStripMenuItem menuItemProduto;
        private System.Windows.Forms.ToolStripMenuItem menuItemTamanho;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastroPreco;
        private System.Windows.Forms.ToolStripMenuItem menuItemIngrediente;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemClasse;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastroPessoa;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}