
namespace Perron
{
    partial class UserControlEngredienteSabor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbEngredientesSabor = new System.Windows.Forms.GroupBox();
            this.dgvEngredientesSabor = new System.Windows.Forms.DataGridView();
            this.txtBuscaEngredientesVinculados = new System.Windows.Forms.TextBox();
            this.gbEngredientesCadastrados = new System.Windows.Forms.GroupBox();
            this.txtBuscaEngredientesCadastrados = new System.Windows.Forms.TextBox();
            this.dgvEngredientesCadastrado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbEngredientesSabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesSabor)).BeginInit();
            this.gbEngredientesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesCadastrado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbEngredientesSabor);
            this.panel1.Controls.Add(this.gbEngredientesCadastrados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 538);
            this.panel1.TabIndex = 0;
            // 
            // gbEngredientesSabor
            // 
            this.gbEngredientesSabor.Controls.Add(this.dgvEngredientesSabor);
            this.gbEngredientesSabor.Controls.Add(this.txtBuscaEngredientesVinculados);
            this.gbEngredientesSabor.Location = new System.Drawing.Point(0, 279);
            this.gbEngredientesSabor.Name = "gbEngredientesSabor";
            this.gbEngredientesSabor.Size = new System.Drawing.Size(629, 259);
            this.gbEngredientesSabor.TabIndex = 1;
            this.gbEngredientesSabor.TabStop = false;
            this.gbEngredientesSabor.Text = "Engredientes Vinculado ao Sabor";
            // 
            // dgvEngredientesSabor
            // 
            this.dgvEngredientesSabor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEngredientesSabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngredientesSabor.Location = new System.Drawing.Point(6, 57);
            this.dgvEngredientesSabor.Name = "dgvEngredientesSabor";
            this.dgvEngredientesSabor.Size = new System.Drawing.Size(623, 196);
            this.dgvEngredientesSabor.TabIndex = 4;
            // 
            // txtBuscaEngredientesVinculados
            // 
            this.txtBuscaEngredientesVinculados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaEngredientesVinculados.Location = new System.Drawing.Point(480, 25);
            this.txtBuscaEngredientesVinculados.Name = "txtBuscaEngredientesVinculados";
            this.txtBuscaEngredientesVinculados.Size = new System.Drawing.Size(146, 26);
            this.txtBuscaEngredientesVinculados.TabIndex = 3;
            // 
            // gbEngredientesCadastrados
            // 
            this.gbEngredientesCadastrados.Controls.Add(this.txtBuscaEngredientesCadastrados);
            this.gbEngredientesCadastrados.Controls.Add(this.dgvEngredientesCadastrado);
            this.gbEngredientesCadastrados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEngredientesCadastrados.Location = new System.Drawing.Point(0, 0);
            this.gbEngredientesCadastrados.Name = "gbEngredientesCadastrados";
            this.gbEngredientesCadastrados.Size = new System.Drawing.Size(632, 276);
            this.gbEngredientesCadastrados.TabIndex = 0;
            this.gbEngredientesCadastrados.TabStop = false;
            this.gbEngredientesCadastrados.Text = "Engredientes Cadastrados";
            // 
            // txtBuscaEngredientesCadastrados
            // 
            this.txtBuscaEngredientesCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaEngredientesCadastrados.Location = new System.Drawing.Point(483, 17);
            this.txtBuscaEngredientesCadastrados.Name = "txtBuscaEngredientesCadastrados";
            this.txtBuscaEngredientesCadastrados.Size = new System.Drawing.Size(146, 26);
            this.txtBuscaEngredientesCadastrados.TabIndex = 5;
            // 
            // dgvEngredientesCadastrado
            // 
            this.dgvEngredientesCadastrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEngredientesCadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngredientesCadastrado.Location = new System.Drawing.Point(6, 49);
            this.dgvEngredientesCadastrado.Name = "dgvEngredientesCadastrado";
            this.dgvEngredientesCadastrado.Size = new System.Drawing.Size(623, 224);
            this.dgvEngredientesCadastrado.TabIndex = 3;
            // 
            // UserControlEngredienteSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlEngredienteSabor";
            this.Size = new System.Drawing.Size(632, 538);
            this.panel1.ResumeLayout(false);
            this.gbEngredientesSabor.ResumeLayout(false);
            this.gbEngredientesSabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesSabor)).EndInit();
            this.gbEngredientesCadastrados.ResumeLayout(false);
            this.gbEngredientesCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesCadastrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbEngredientesCadastrados;
        private System.Windows.Forms.TextBox txtBuscaEngredientesCadastrados;
        private System.Windows.Forms.DataGridView dgvEngredientesCadastrado;
        private System.Windows.Forms.GroupBox gbEngredientesSabor;
        private System.Windows.Forms.DataGridView dgvEngredientesSabor;
        private System.Windows.Forms.TextBox txtBuscaEngredientesVinculados;
    }
}
