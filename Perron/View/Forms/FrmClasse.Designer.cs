
namespace Perron.View.Forms
{
    partial class FrmClasse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gbClassesCadastradas = new System.Windows.Forms.GroupBox();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbClassesCadastradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descricão Classe";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(3, 22);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(269, 29);
            this.txtDescricao.TabIndex = 7;
            // 
            // gbClassesCadastradas
            // 
            this.gbClassesCadastradas.Controls.Add(this.dgvClasse);
            this.gbClassesCadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClassesCadastradas.Location = new System.Drawing.Point(10, 141);
            this.gbClassesCadastradas.Name = "gbClassesCadastradas";
            this.gbClassesCadastradas.Size = new System.Drawing.Size(275, 188);
            this.gbClassesCadastradas.TabIndex = 11;
            this.gbClassesCadastradas.TabStop = false;
            this.gbClassesCadastradas.Text = "Classes Cadastradas";
            // 
            // dgvClasse
            // 
            this.dgvClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasse.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClasse.Location = new System.Drawing.Point(3, 19);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.RowHeadersWidth = 51;
            this.dgvClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasse.Size = new System.Drawing.Size(269, 166);
            this.dgvClasse.TabIndex = 1;
            // 
            // FrmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 142);
            this.Controls.Add(this.gbClassesCadastradas);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmClasse";
            this.Text = "Cadastro de Classe";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbClassesCadastradas, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbClassesCadastradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gbClassesCadastradas;
        private System.Windows.Forms.DataGridView dgvClasse;
    }
}