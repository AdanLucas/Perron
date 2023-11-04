namespace Perron.View.Forms
{
    partial class FrmCadastroPreco
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuBotaoDireitoClasse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBotaoDireitoAdicionarClasse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBotaoDireitoRemoverClasse = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescricaoClasse = new System.Windows.Forms.Label();
            this.dgvPrecos = new System.Windows.Forms.DataGridView();
            this.gbPrecosCadastrados = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuBotaoDireitoTamanho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBotaoDireitoAdicionarTamanho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBotaoDireitoRemoverTamanho = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTamanho = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPreco = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDadosCadastro = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuBotaoDireitoClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecos)).BeginInit();
            this.gbPrecosCadastrados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuBotaoDireitoTamanho.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDadosCadastro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.ContextMenuStrip = this.menuBotaoDireitoClasse;
            this.groupBox1.Controls.Add(this.txtDescricaoClasse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 59);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuBotaoDireitoClasse
            // 
            this.menuBotaoDireitoClasse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBotaoDireitoAdicionarClasse,
            this.menuBotaoDireitoRemoverClasse});
            this.menuBotaoDireitoClasse.Name = "menuBotaoDireitoClasse";
            this.menuBotaoDireitoClasse.Size = new System.Drawing.Size(126, 48);
            // 
            // menuBotaoDireitoAdicionarClasse
            // 
            this.menuBotaoDireitoAdicionarClasse.Image = global::Perron.Properties.Resources.add;
            this.menuBotaoDireitoAdicionarClasse.Name = "menuBotaoDireitoAdicionarClasse";
            this.menuBotaoDireitoAdicionarClasse.Size = new System.Drawing.Size(125, 22);
            this.menuBotaoDireitoAdicionarClasse.Text = "Adicionar";
            // 
            // menuBotaoDireitoRemoverClasse
            // 
            this.menuBotaoDireitoRemoverClasse.Image = global::Perron.Properties.Resources.Remover;
            this.menuBotaoDireitoRemoverClasse.Name = "menuBotaoDireitoRemoverClasse";
            this.menuBotaoDireitoRemoverClasse.Size = new System.Drawing.Size(125, 22);
            this.menuBotaoDireitoRemoverClasse.Text = "Remover";
            this.menuBotaoDireitoRemoverClasse.Visible = false;
            // 
            // txtDescricaoClasse
            // 
            this.txtDescricaoClasse.AutoSize = true;
            this.txtDescricaoClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoClasse.Location = new System.Drawing.Point(28, 29);
            this.txtDescricaoClasse.Name = "txtDescricaoClasse";
            this.txtDescricaoClasse.Size = new System.Drawing.Size(0, 13);
            this.txtDescricaoClasse.TabIndex = 0;
            // 
            // dgvPrecos
            // 
            this.dgvPrecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrecos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrecos.Location = new System.Drawing.Point(3, 16);
            this.dgvPrecos.MultiSelect = false;
            this.dgvPrecos.Name = "dgvPrecos";
            this.dgvPrecos.ReadOnly = true;
            this.dgvPrecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrecos.Size = new System.Drawing.Size(261, 274);
            this.dgvPrecos.TabIndex = 9;
            // 
            // gbPrecosCadastrados
            // 
            this.gbPrecosCadastrados.Controls.Add(this.dgvPrecos);
            this.gbPrecosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrecosCadastrados.Location = new System.Drawing.Point(8, 252);
            this.gbPrecosCadastrados.Name = "gbPrecosCadastrados";
            this.gbPrecosCadastrados.Size = new System.Drawing.Size(267, 293);
            this.gbPrecosCadastrados.TabIndex = 10;
            this.gbPrecosCadastrados.TabStop = false;
            this.gbPrecosCadastrados.Text = "Preços Cadastrados";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.ContextMenuStrip = this.menuBotaoDireitoTamanho;
            this.groupBox2.Controls.Add(this.txtTamanho);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 56);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamanho";
            // 
            // menuBotaoDireitoTamanho
            // 
            this.menuBotaoDireitoTamanho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBotaoDireitoAdicionarTamanho,
            this.menuBotaoDireitoRemoverTamanho});
            this.menuBotaoDireitoTamanho.Name = "menuBotaoDireitoClasse";
            this.menuBotaoDireitoTamanho.Size = new System.Drawing.Size(126, 48);
            // 
            // menuBotaoDireitoAdicionarTamanho
            // 
            this.menuBotaoDireitoAdicionarTamanho.Image = global::Perron.Properties.Resources.add;
            this.menuBotaoDireitoAdicionarTamanho.Name = "menuBotaoDireitoAdicionarTamanho";
            this.menuBotaoDireitoAdicionarTamanho.Size = new System.Drawing.Size(125, 22);
            this.menuBotaoDireitoAdicionarTamanho.Text = "Adicionar";
            // 
            // menuBotaoDireitoRemoverTamanho
            // 
            this.menuBotaoDireitoRemoverTamanho.Image = global::Perron.Properties.Resources.Remover;
            this.menuBotaoDireitoRemoverTamanho.Name = "menuBotaoDireitoRemoverTamanho";
            this.menuBotaoDireitoRemoverTamanho.Size = new System.Drawing.Size(125, 22);
            this.menuBotaoDireitoRemoverTamanho.Text = "Remover";
            this.menuBotaoDireitoRemoverTamanho.Visible = false;
            // 
            // txtTamanho
            // 
            this.txtTamanho.AutoSize = true;
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(28, 26);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(0, 13);
            this.txtTamanho.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnAddPreco);
            this.groupBox4.Controls.Add(this.txtPreco);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 76);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "R$:";
            // 
            // btnAddPreco
            // 
            this.btnAddPreco.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPreco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPreco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPreco.FlatAppearance.BorderSize = 5;
            this.btnAddPreco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPreco.Location = new System.Drawing.Point(201, 21);
            this.btnAddPreco.Name = "btnAddPreco";
            this.btnAddPreco.Size = new System.Drawing.Size(46, 43);
            this.btnAddPreco.TabIndex = 4;
            this.btnAddPreco.UseVisualStyleBackColor = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(64, 30);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 26);
            this.txtPreco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // gbDadosCadastro
            // 
            this.gbDadosCadastro.Controls.Add(this.groupBox1);
            this.gbDadosCadastro.Controls.Add(this.groupBox4);
            this.gbDadosCadastro.Controls.Add(this.groupBox2);
            this.gbDadosCadastro.Location = new System.Drawing.Point(8, 19);
            this.gbDadosCadastro.Name = "gbDadosCadastro";
            this.gbDadosCadastro.Size = new System.Drawing.Size(267, 226);
            this.gbDadosCadastro.TabIndex = 11;
            this.gbDadosCadastro.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbDadosCadastro);
            this.groupBox3.Controls.Add(this.gbPrecosCadastrados);
            this.groupBox3.Location = new System.Drawing.Point(0, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 551);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // FrmCadastroPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 595);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroPreco";
            this.Text = "Cadastrando Preço";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuBotaoDireitoClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecos)).EndInit();
            this.gbPrecosCadastrados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuBotaoDireitoTamanho.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDadosCadastro.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip menuBotaoDireitoClasse;
        private System.Windows.Forms.ToolStripMenuItem menuBotaoDireitoAdicionarClasse;
        private System.Windows.Forms.ToolStripMenuItem menuBotaoDireitoRemoverClasse;
        private System.Windows.Forms.Label txtDescricaoClasse;
        private System.Windows.Forms.DataGridView dgvPrecos;
        private System.Windows.Forms.GroupBox gbPrecosCadastrados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtTamanho;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDadosCadastro;
        private System.Windows.Forms.ContextMenuStrip menuBotaoDireitoTamanho;
        private System.Windows.Forms.ToolStripMenuItem menuBotaoDireitoAdicionarTamanho;
        private System.Windows.Forms.ToolStripMenuItem menuBotaoDireitoRemoverTamanho;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}