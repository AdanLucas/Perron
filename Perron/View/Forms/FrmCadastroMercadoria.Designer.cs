
namespace Perron.View.Forms
{
    partial class FrmCadastroMercadoria
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
            this.dgvMercadoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTipoMedida = new System.Windows.Forms.ComboBox();
            this.gbEngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEngredientes
            // 
            this.gbEngredientes.Controls.Add(this.dgvMercadoria);
            this.gbEngredientes.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEngredientes.Location = new System.Drawing.Point(16, 146);
            this.gbEngredientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEngredientes.Name = "gbEngredientes";
            this.gbEngredientes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEngredientes.Size = new System.Drawing.Size(601, 596);
            this.gbEngredientes.TabIndex = 11;
            this.gbEngredientes.TabStop = false;
            this.gbEngredientes.Text = "Mercadoria Cadastrados";
            // 
            // dgvMercadoria
            // 
            this.dgvMercadoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMercadoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMercadoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercadoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMercadoria.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMercadoria.Location = new System.Drawing.Point(4, 24);
            this.dgvMercadoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMercadoria.MultiSelect = false;
            this.dgvMercadoria.Name = "dgvMercadoria";
            this.dgvMercadoria.ReadOnly = true;
            this.dgvMercadoria.RowHeadersWidth = 51;
            this.dgvMercadoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMercadoria.Size = new System.Drawing.Size(593, 568);
            this.dgvMercadoria.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(356, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(8, 31);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(328, 30);
            this.txtDescricao.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTipoMedida);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(380, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(236, 78);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Medida";
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Items.AddRange(new object[] {
            "Selecione",
            "Kilograma",
            "Unidade"});
            this.cbTipoMedida.Location = new System.Drawing.Point(8, 27);
            this.cbTipoMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(216, 33);
            this.cbTipoMedida.TabIndex = 9;
            // 
            // FrmCadastroIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 751);
            this.Controls.Add(this.gbEngredientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroIngrediente";
            this.Load += new System.EventHandler(this.FrmCadastroIngrediente_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbEngredientes, 0);
            this.gbEngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEngredientes;
        private System.Windows.Forms.DataGridView dgvMercadoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTipoMedida;
    }
}