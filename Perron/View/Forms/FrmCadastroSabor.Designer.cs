
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
            this.pagEngredientes = new System.Windows.Forms.TabPage();
            this.dgvSaboresCadastrados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoSabor = new System.Windows.Forms.TextBox();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.painelEngredienteSabor = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.pagSabor.SuspendLayout();
            this.pagEngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaboresCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagSabor);
            this.tabControl1.Controls.Add(this.pagEngredientes);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 577);
            this.tabControl1.TabIndex = 3;
            // 
            // pagSabor
            // 
            this.pagSabor.Controls.Add(this.dgvSaboresCadastrados);
            this.pagSabor.Controls.Add(this.label2);
            this.pagSabor.Controls.Add(this.label3);
            this.pagSabor.Controls.Add(this.label1);
            this.pagSabor.Controls.Add(this.txtDescricaoSabor);
            this.pagSabor.Controls.Add(this.comboClasse);
            this.pagSabor.Location = new System.Drawing.Point(4, 29);
            this.pagSabor.Name = "pagSabor";
            this.pagSabor.Padding = new System.Windows.Forms.Padding(3);
            this.pagSabor.Size = new System.Drawing.Size(638, 544);
            this.pagSabor.TabIndex = 0;
            this.pagSabor.Text = "Sabor";
            this.pagSabor.UseVisualStyleBackColor = true;
            // 
            // pagEngredientes
            // 
            this.pagEngredientes.Controls.Add(this.painelEngredienteSabor);
            this.pagEngredientes.Location = new System.Drawing.Point(4, 29);
            this.pagEngredientes.Name = "pagEngredientes";
            this.pagEngredientes.Padding = new System.Windows.Forms.Padding(3);
            this.pagEngredientes.Size = new System.Drawing.Size(638, 544);
            this.pagEngredientes.TabIndex = 1;
            this.pagEngredientes.Text = "Engredientes";
            this.pagEngredientes.UseVisualStyleBackColor = true;
            // 
            // dgvSaboresCadastrados
            // 
            this.dgvSaboresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaboresCadastrados.Location = new System.Drawing.Point(7, 144);
            this.dgvSaboresCadastrados.Name = "dgvSaboresCadastrados";
            this.dgvSaboresCadastrados.Size = new System.Drawing.Size(624, 394);
            this.dgvSaboresCadastrados.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição Sabor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sabores Cadastrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classe";
            // 
            // txtDescricaoSabor
            // 
            this.txtDescricaoSabor.Location = new System.Drawing.Point(190, 48);
            this.txtDescricaoSabor.Name = "txtDescricaoSabor";
            this.txtDescricaoSabor.Size = new System.Drawing.Size(441, 26);
            this.txtDescricaoSabor.TabIndex = 5;
            // 
            // comboClasse
            // 
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.Location = new System.Drawing.Point(9, 48);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(136, 28);
            this.comboClasse.TabIndex = 4;
            // 
            // painelEngredienteSabor
            // 
            this.painelEngredienteSabor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelEngredienteSabor.Location = new System.Drawing.Point(3, 3);
            this.painelEngredienteSabor.Name = "painelEngredienteSabor";
            this.painelEngredienteSabor.Size = new System.Drawing.Size(632, 538);
            this.painelEngredienteSabor.TabIndex = 0;
            // 
            // FrmCadastroSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCadastroSabor";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.pagSabor.ResumeLayout(false);
            this.pagSabor.PerformLayout();
            this.pagEngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaboresCadastrados)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.Panel painelEngredienteSabor;
    }
}