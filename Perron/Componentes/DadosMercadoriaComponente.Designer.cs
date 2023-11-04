namespace Perron.Componentes
{
    partial class DadosMercadoriaComponente
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.Label();
            this.dgvDadosIngrediente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUnidadeMedida = new System.Windows.Forms.Label();
            this.menuBotaoDireito = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdicionarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoverDados = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosIngrediente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuBotaoDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(14, 26);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(77, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "descricao";
            // 
            // dgvDadosIngrediente
            // 
            this.dgvDadosIngrediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosIngrediente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDadosIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosIngrediente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDadosIngrediente.Location = new System.Drawing.Point(3, 16);
            this.dgvDadosIngrediente.MultiSelect = false;
            this.dgvDadosIngrediente.Name = "dgvDadosIngrediente";
            this.dgvDadosIngrediente.ReadOnly = true;
            this.dgvDadosIngrediente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDadosIngrediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosIngrediente.Size = new System.Drawing.Size(214, 94);
            this.dgvDadosIngrediente.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDadosIngrediente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(257, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 113);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtUnidadeMedida);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unidade Medida";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.AutoSize = true;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadeMedida.Location = new System.Drawing.Point(13, 24);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(53, 13);
            this.txtUnidadeMedida.TabIndex = 1;
            this.txtUnidadeMedida.Text = "descricao";
            // 
            // menuBotaoDireito
            // 
            this.menuBotaoDireito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemover,
            this.menuAdicionarDados,
            this.menuRemoverDados});
            this.menuBotaoDireito.Name = "menuBotaoDireito";
            this.menuBotaoDireito.Size = new System.Drawing.Size(162, 70);
            // 
            // menuRemover
            // 
            this.menuRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuRemover.Image = global::Perron.Properties.Resources.cancel;
            this.menuRemover.Name = "menuRemover";
            this.menuRemover.Size = new System.Drawing.Size(161, 22);
            this.menuRemover.Text = "Remover";
            // 
            // menuAdicionarDados
            // 
            this.menuAdicionarDados.Image = global::Perron.Properties.Resources.BotaoOk;
            this.menuAdicionarDados.Name = "menuAdicionarDados";
            this.menuAdicionarDados.Size = new System.Drawing.Size(161, 22);
            this.menuAdicionarDados.Text = "Adicionar Dados";
            // 
            // menuRemoverDados
            // 
            this.menuRemoverDados.Image = global::Perron.Properties.Resources.Remover;
            this.menuRemoverDados.Name = "menuRemoverDados";
            this.menuRemoverDados.Size = new System.Drawing.Size(161, 22);
            this.menuRemoverDados.Text = "Remover Dados";
            // 
            // DadosMercadoriaComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.menuBotaoDireito;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DadosMercadoriaComponente";
            this.Size = new System.Drawing.Size(480, 119);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosIngrediente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuBotaoDireito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.DataGridView dgvDadosIngrediente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtUnidadeMedida;
        private System.Windows.Forms.ContextMenuStrip menuBotaoDireito;
        private System.Windows.Forms.ToolStripMenuItem menuRemover;
        private System.Windows.Forms.ToolStripMenuItem menuAdicionarDados;
        private System.Windows.Forms.ToolStripMenuItem menuRemoverDados;
    }
}
