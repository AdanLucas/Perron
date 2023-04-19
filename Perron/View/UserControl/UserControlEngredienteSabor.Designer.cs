
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
            this.gbEngredientesCadastrados = new System.Windows.Forms.GroupBox();
            this.txtBuscaEngredientesCadastrados = new System.Windows.Forms.TextBox();
            this.dgvEngredientesCadastrado = new System.Windows.Forms.DataGridView();
            this.gbEngredientesSabor = new System.Windows.Forms.GroupBox();
            this.painelStatus = new System.Windows.Forms.Panel();
            this.dgvEngredientesSabor = new System.Windows.Forms.DataGridView();
            this.txtBuscaEngredientesVinculados = new System.Windows.Forms.TextBox();
            this.gbEngredientesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesCadastrado)).BeginInit();
            this.gbEngredientesSabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesSabor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEngredientesCadastrados
            // 
            this.gbEngredientesCadastrados.Controls.Add(this.txtBuscaEngredientesCadastrados);
            this.gbEngredientesCadastrados.Controls.Add(this.dgvEngredientesCadastrado);
            this.gbEngredientesCadastrados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEngredientesCadastrados.Location = new System.Drawing.Point(0, 0);
            this.gbEngredientesCadastrados.Name = "gbEngredientesCadastrados";
            this.gbEngredientesCadastrados.Size = new System.Drawing.Size(367, 164);
            this.gbEngredientesCadastrados.TabIndex = 0;
            this.gbEngredientesCadastrados.TabStop = false;
            this.gbEngredientesCadastrados.Text = "Engredientes Cadastrados";
            // 
            // txtBuscaEngredientesCadastrados
            // 
            this.txtBuscaEngredientesCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaEngredientesCadastrados.Location = new System.Drawing.Point(215, 29);
            this.txtBuscaEngredientesCadastrados.Name = "txtBuscaEngredientesCadastrados";
            this.txtBuscaEngredientesCadastrados.Size = new System.Drawing.Size(146, 30);
            this.txtBuscaEngredientesCadastrados.TabIndex = 5;
            // 
            // dgvEngredientesCadastrado
            // 
            this.dgvEngredientesCadastrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEngredientesCadastrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEngredientesCadastrado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEngredientesCadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngredientesCadastrado.Location = new System.Drawing.Point(6, 62);
            this.dgvEngredientesCadastrado.MultiSelect = false;
            this.dgvEngredientesCadastrado.Name = "dgvEngredientesCadastrado";
            this.dgvEngredientesCadastrado.ReadOnly = true;
            this.dgvEngredientesCadastrado.RowHeadersWidth = 51;
            this.dgvEngredientesCadastrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEngredientesCadastrado.Size = new System.Drawing.Size(355, 96);
            this.dgvEngredientesCadastrado.TabIndex = 3;
            // 
            // gbEngredientesSabor
            // 
            this.gbEngredientesSabor.Controls.Add(this.painelStatus);
            this.gbEngredientesSabor.Controls.Add(this.dgvEngredientesSabor);
            this.gbEngredientesSabor.Controls.Add(this.txtBuscaEngredientesVinculados);
            this.gbEngredientesSabor.Location = new System.Drawing.Point(3, 170);
            this.gbEngredientesSabor.Name = "gbEngredientesSabor";
            this.gbEngredientesSabor.Size = new System.Drawing.Size(358, 218);
            this.gbEngredientesSabor.TabIndex = 1;
            this.gbEngredientesSabor.TabStop = false;
            this.gbEngredientesSabor.Text = "Engredientes Vinculado ao Sabor";
            // 
            // painelStatus
            // 
            this.painelStatus.Location = new System.Drawing.Point(3, 40);
            this.painelStatus.Name = "painelStatus";
            this.painelStatus.Size = new System.Drawing.Size(169, 30);
            this.painelStatus.TabIndex = 5;
            // 
            // dgvEngredientesSabor
            // 
            this.dgvEngredientesSabor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEngredientesSabor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEngredientesSabor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEngredientesSabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngredientesSabor.Location = new System.Drawing.Point(3, 76);
            this.dgvEngredientesSabor.MultiSelect = false;
            this.dgvEngredientesSabor.Name = "dgvEngredientesSabor";
            this.dgvEngredientesSabor.ReadOnly = true;
            this.dgvEngredientesSabor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEngredientesSabor.RowHeadersWidth = 51;
            this.dgvEngredientesSabor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEngredientesSabor.Size = new System.Drawing.Size(355, 136);
            this.dgvEngredientesSabor.TabIndex = 4;
            // 
            // txtBuscaEngredientesVinculados
            // 
            this.txtBuscaEngredientesVinculados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaEngredientesVinculados.Location = new System.Drawing.Point(206, 40);
            this.txtBuscaEngredientesVinculados.Name = "txtBuscaEngredientesVinculados";
            this.txtBuscaEngredientesVinculados.Size = new System.Drawing.Size(146, 30);
            this.txtBuscaEngredientesVinculados.TabIndex = 3;
            // 
            // UserControlEngredienteSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.gbEngredientesSabor);
            this.Controls.Add(this.gbEngredientesCadastrados);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlEngredienteSabor";
            this.Size = new System.Drawing.Size(367, 391);
            this.gbEngredientesCadastrados.ResumeLayout(false);
            this.gbEngredientesCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesCadastrado)).EndInit();
            this.gbEngredientesSabor.ResumeLayout(false);
            this.gbEngredientesSabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngredientesSabor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbEngredientesCadastrados;
        private System.Windows.Forms.TextBox txtBuscaEngredientesCadastrados;
        private System.Windows.Forms.DataGridView dgvEngredientesCadastrado;
        private System.Windows.Forms.GroupBox gbEngredientesSabor;
        private System.Windows.Forms.Panel painelStatus;
        private System.Windows.Forms.DataGridView dgvEngredientesSabor;
        private System.Windows.Forms.TextBox txtBuscaEngredientesVinculados;
    }
}
