
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
            this.dgvSaboresCadastrados = new System.Windows.Forms.DataGridView();
            this.btnBuscarClasse = new System.Windows.Forms.Button();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoSabor = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.pagSabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaboresCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagSabor);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 461);
            this.tabControl1.TabIndex = 3;
            // 
            // pagSabor
            // 
            this.pagSabor.Controls.Add(this.dgvSaboresCadastrados);
            this.pagSabor.Controls.Add(this.btnBuscarClasse);
            this.pagSabor.Controls.Add(this.txtClasse);
            this.pagSabor.Controls.Add(this.label2);
            this.pagSabor.Controls.Add(this.label1);
            this.pagSabor.Controls.Add(this.txtDescricaoSabor);
            this.pagSabor.Location = new System.Drawing.Point(4, 34);
            this.pagSabor.Name = "pagSabor";
            this.pagSabor.Padding = new System.Windows.Forms.Padding(3);
            this.pagSabor.Size = new System.Drawing.Size(529, 423);
            this.pagSabor.TabIndex = 0;
            this.pagSabor.Text = "Dados Sabor";
            this.pagSabor.UseVisualStyleBackColor = true;
            // 
            // dgvSaboresCadastrados
            // 
            this.dgvSaboresCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaboresCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaboresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaboresCadastrados.Location = new System.Drawing.Point(3, 176);
            this.dgvSaboresCadastrados.MultiSelect = false;
            this.dgvSaboresCadastrados.Name = "dgvSaboresCadastrados";
            this.dgvSaboresCadastrados.ReadOnly = true;
            this.dgvSaboresCadastrados.RowHeadersWidth = 51;
            this.dgvSaboresCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaboresCadastrados.Size = new System.Drawing.Size(520, 249);
            this.dgvSaboresCadastrados.TabIndex = 12;
            // 
            // btnBuscarClasse
            // 
            this.btnBuscarClasse.FlatAppearance.BorderSize = 0;
            this.btnBuscarClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClasse.Location = new System.Drawing.Point(123, 99);
            this.btnBuscarClasse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarClasse.Name = "btnBuscarClasse";
            this.btnBuscarClasse.Size = new System.Drawing.Size(36, 34);
            this.btnBuscarClasse.TabIndex = 11;
            this.btnBuscarClasse.UseVisualStyleBackColor = true;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(10, 102);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(2);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(109, 30);
            this.txtClasse.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição Sabor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classe";
            // 
            // txtDescricaoSabor
            // 
            this.txtDescricaoSabor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoSabor.Location = new System.Drawing.Point(10, 37);
            this.txtDescricaoSabor.Name = "txtDescricaoSabor";
            this.txtDescricaoSabor.Size = new System.Drawing.Size(360, 30);
            this.txtDescricaoSabor.TabIndex = 5;
            // 
            // FrmCadastroSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 514);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroSabor";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.pagSabor.ResumeLayout(false);
            this.pagSabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaboresCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pagSabor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoSabor;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Button btnBuscarClasse;
        private System.Windows.Forms.DataGridView dgvSaboresCadastrados;
    }
}