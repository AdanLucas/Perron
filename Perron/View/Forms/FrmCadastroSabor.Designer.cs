
namespace Perron.View.Forms
{
    partial class FrmCadastroSabor
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
            this.pagSabor = new System.Windows.Forms.TabPage();
            this.btnBuscarClasse = new System.Windows.Forms.Button();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.dgvSaboresCadastrados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoSabor = new System.Windows.Forms.TextBox();
            this.pagEngredientes = new System.Windows.Forms.TabPage();
            this.painelEngredienteSabor = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.pagSabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaboresCadastrados)).BeginInit();
            this.pagEngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagSabor);
            this.tabControl1.Controls.Add(this.pagEngredientes);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 564);
            this.tabControl1.TabIndex = 3;
            // 
            // pagSabor
            // 
            this.pagSabor.Controls.Add(this.btnBuscarClasse);
            this.pagSabor.Controls.Add(this.txtClasse);
            this.pagSabor.Controls.Add(this.dgvSaboresCadastrados);
            this.pagSabor.Controls.Add(this.label2);
            this.pagSabor.Controls.Add(this.label3);
            this.pagSabor.Controls.Add(this.label1);
            this.pagSabor.Controls.Add(this.txtDescricaoSabor);
            this.pagSabor.Location = new System.Drawing.Point(4, 34);
            this.pagSabor.Margin = new System.Windows.Forms.Padding(4);
            this.pagSabor.Name = "pagSabor";
            this.pagSabor.Padding = new System.Windows.Forms.Padding(4);
            this.pagSabor.Size = new System.Drawing.Size(519, 526);
            this.pagSabor.TabIndex = 0;
            this.pagSabor.Text = "Sabor";
            this.pagSabor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarClasse
            // 
            this.btnBuscarClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClasse.Location = new System.Drawing.Point(163, 114);
            this.btnBuscarClasse.Name = "btnBuscarClasse";
            this.btnBuscarClasse.Size = new System.Drawing.Size(70, 31);
            this.btnBuscarClasse.TabIndex = 11;
            this.btnBuscarClasse.Text = "Buscar";
            this.btnBuscarClasse.UseVisualStyleBackColor = true;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(13, 114);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(146, 30);
            this.txtClasse.TabIndex = 10;
            // 
            // dgvSaboresCadastrados
            // 
            this.dgvSaboresCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaboresCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaboresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaboresCadastrados.Location = new System.Drawing.Point(9, 222);
            this.dgvSaboresCadastrados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSaboresCadastrados.MultiSelect = false;
            this.dgvSaboresCadastrados.Name = "dgvSaboresCadastrados";
            this.dgvSaboresCadastrados.ReadOnly = true;
            this.dgvSaboresCadastrados.RowHeadersWidth = 51;
            this.dgvSaboresCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaboresCadastrados.Size = new System.Drawing.Size(506, 306);
            this.dgvSaboresCadastrados.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição Sabor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sabores Cadastrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classe";
            // 
            // txtDescricaoSabor
            // 
            this.txtDescricaoSabor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoSabor.Location = new System.Drawing.Point(13, 45);
            this.txtDescricaoSabor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoSabor.Name = "txtDescricaoSabor";
            this.txtDescricaoSabor.Size = new System.Drawing.Size(502, 30);
            this.txtDescricaoSabor.TabIndex = 5;
            // 
            // pagEngredientes
            // 
            this.pagEngredientes.Controls.Add(this.painelEngredienteSabor);
            this.pagEngredientes.Location = new System.Drawing.Point(4, 34);
            this.pagEngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.pagEngredientes.Name = "pagEngredientes";
            this.pagEngredientes.Padding = new System.Windows.Forms.Padding(4);
            this.pagEngredientes.Size = new System.Drawing.Size(519, 532);
            this.pagEngredientes.TabIndex = 1;
            this.pagEngredientes.Text = "Engredientes";
            this.pagEngredientes.UseVisualStyleBackColor = true;
            // 
            // painelEngredienteSabor
            // 
            this.painelEngredienteSabor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelEngredienteSabor.Location = new System.Drawing.Point(4, 4);
            this.painelEngredienteSabor.Margin = new System.Windows.Forms.Padding(4);
            this.painelEngredienteSabor.Name = "painelEngredienteSabor";
            this.painelEngredienteSabor.Size = new System.Drawing.Size(511, 524);
            this.painelEngredienteSabor.TabIndex = 0;
            // 
            // FrmCadastroSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 598);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroSabor";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.pagSabor.ResumeLayout(false);
            this.pagSabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaboresCadastrados)).EndInit();
            this.pagEngredientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pagSabor;
        private System.Windows.Forms.TabPage pagEngredientes;
        private System.Windows.Forms.DataGridView dgvSaboresCadastrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoSabor;
        private System.Windows.Forms.Panel painelEngredienteSabor;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Button btnBuscarClasse;
    }
}