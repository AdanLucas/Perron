
namespace Perron.View.Forms
{
    partial class FrmCadastroIngrediente
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
            this.gbEngredientes = new System.Windows.Forms.GroupBox();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gbEngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEngredientes
            // 
            this.gbEngredientes.Controls.Add(this.dgvIngredientes);
            this.gbEngredientes.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEngredientes.Location = new System.Drawing.Point(12, 137);
            this.gbEngredientes.Name = "gbEngredientes";
            this.gbEngredientes.Size = new System.Drawing.Size(270, 220);
            this.gbEngredientes.TabIndex = 6;
            this.gbEngredientes.TabStop = false;
            this.gbEngredientes.Text = "Engredientes Cadastrados";
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvIngredientes.Location = new System.Drawing.Point(3, 19);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersWidth = 51;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(264, 198);
            this.dgvIngredientes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(6, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(247, 26);
            this.txtDescricao.TabIndex = 5;
            // 
            // FrmCadastroIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEngredientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroIngrediente";
            this.Load += new System.EventHandler(this.FrmCadastroIngrediente_Load);
            this.Controls.SetChildIndex(this.gbEngredientes, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gbEngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEngredientes;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}