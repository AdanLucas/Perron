
namespace Perron.View.Forms
{
    partial class FrmCadastroProduto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pagProduto = new System.Windows.Forms.TabPage();
            this.dgvProdutosCadastrados = new System.Windows.Forms.DataGridView();
            this.btnBuscarClasse = new System.Windows.Forms.Button();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.pagProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagProduto);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 567);
            this.tabControl1.TabIndex = 3;
            // 
            // pagProduto
            // 
            this.pagProduto.Controls.Add(this.dgvProdutosCadastrados);
            this.pagProduto.Controls.Add(this.btnBuscarClasse);
            this.pagProduto.Controls.Add(this.txtClasse);
            this.pagProduto.Controls.Add(this.label2);
            this.pagProduto.Controls.Add(this.label1);
            this.pagProduto.Controls.Add(this.txtDescricaoProduto);
            this.pagProduto.Location = new System.Drawing.Point(4, 34);
            this.pagProduto.Margin = new System.Windows.Forms.Padding(4);
            this.pagProduto.Name = "pagProduto";
            this.pagProduto.Padding = new System.Windows.Forms.Padding(4);
            this.pagProduto.Size = new System.Drawing.Size(708, 529);
            this.pagProduto.TabIndex = 0;
            this.pagProduto.Text = "Dados Produto";
            this.pagProduto.UseVisualStyleBackColor = true;
            // 
            // dgvProdutosCadastrados
            // 
            this.dgvProdutosCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosCadastrados.Location = new System.Drawing.Point(4, 217);
            this.dgvProdutosCadastrados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutosCadastrados.MultiSelect = false;
            this.dgvProdutosCadastrados.Name = "dgvProdutosCadastrados";
            this.dgvProdutosCadastrados.ReadOnly = true;
            this.dgvProdutosCadastrados.RowHeadersWidth = 51;
            this.dgvProdutosCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosCadastrados.Size = new System.Drawing.Size(693, 306);
            this.dgvProdutosCadastrados.TabIndex = 12;
            // 
            // btnBuscarClasse
            // 
            this.btnBuscarClasse.FlatAppearance.BorderSize = 0;
            this.btnBuscarClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClasse.Location = new System.Drawing.Point(164, 122);
            this.btnBuscarClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarClasse.Name = "btnBuscarClasse";
            this.btnBuscarClasse.Size = new System.Drawing.Size(48, 42);
            this.btnBuscarClasse.TabIndex = 11;
            this.btnBuscarClasse.UseVisualStyleBackColor = true;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(13, 126);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(144, 30);
            this.txtClasse.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classe";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(13, 46);
            this.txtDescricaoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(479, 30);
            this.txtDescricaoProduto.TabIndex = 5;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 633);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroProduto";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.pagProduto.ResumeLayout(false);
            this.pagProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pagProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Button btnBuscarClasse;
        private System.Windows.Forms.DataGridView dgvProdutosCadastrados;
    }
}