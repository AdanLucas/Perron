namespace Perron.View.Forms
{
    partial class FrmPessoa
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
            this.pageBusca = new System.Windows.Forms.TabPage();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvBuscaPessoa = new System.Windows.Forms.DataGridView();
            this.pageDados = new System.Windows.Forms.TabPage();
            this.gbDadosPessoa = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pnTipoPessoa = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pageDadosTipo = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageEndereco = new System.Windows.Forms.TabPage();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.pageBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaPessoa)).BeginInit();
            this.pageDados.SuspendLayout();
            this.gbDadosPessoa.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pageDadosTipo.SuspendLayout();
            this.pageEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.pageBusca);
            this.tabControl1.Controls.Add(this.pageDados);
            this.tabControl1.Controls.Add(this.pageDadosTipo);
            this.tabControl1.Controls.Add(this.pageEndereco);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 211);
            this.tabControl1.TabIndex = 3;
            // 
            // pageBusca
            // 
            this.pageBusca.Controls.Add(this.txtBuscar);
            this.pageBusca.Controls.Add(this.dgvBuscaPessoa);
            this.pageBusca.Location = new System.Drawing.Point(4, 22);
            this.pageBusca.Name = "pageBusca";
            this.pageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.pageBusca.Size = new System.Drawing.Size(951, 185);
            this.pageBusca.TabIndex = 1;
            this.pageBusca.Text = "Buscar Pessoa";
            this.pageBusca.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(783, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(162, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // dgvBuscaPessoa
            // 
            this.dgvBuscaPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscaPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscaPessoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscaPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaPessoa.Location = new System.Drawing.Point(3, 32);
            this.dgvBuscaPessoa.MultiSelect = false;
            this.dgvBuscaPessoa.Name = "dgvBuscaPessoa";
            this.dgvBuscaPessoa.ReadOnly = true;
            this.dgvBuscaPessoa.Size = new System.Drawing.Size(942, 150);
            this.dgvBuscaPessoa.TabIndex = 0;
            this.dgvBuscaPessoa.DoubleClick += new System.EventHandler(this.dgvBuscaPessoa_DoubleClick);
            // 
            // pageDados
            // 
            this.pageDados.Controls.Add(this.gbDadosPessoa);
            this.pageDados.Location = new System.Drawing.Point(4, 22);
            this.pageDados.Name = "pageDados";
            this.pageDados.Padding = new System.Windows.Forms.Padding(3);
            this.pageDados.Size = new System.Drawing.Size(951, 185);
            this.pageDados.TabIndex = 0;
            this.pageDados.Text = "Dados";
            this.pageDados.UseVisualStyleBackColor = true;
            // 
            // gbDadosPessoa
            // 
            this.gbDadosPessoa.Controls.Add(this.tableLayoutPanel1);
            this.gbDadosPessoa.Controls.Add(this.pnTipoPessoa);
            this.gbDadosPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoa.Location = new System.Drawing.Point(3, 3);
            this.gbDadosPessoa.Name = "gbDadosPessoa";
            this.gbDadosPessoa.Size = new System.Drawing.Size(945, 179);
            this.gbDadosPessoa.TabIndex = 4;
            this.gbDadosPessoa.TabStop = false;
            this.gbDadosPessoa.Text = "Dados Pessoa";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(3, 68);
            this.txtTelefone.Mask = "(99) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(366, 23);
            this.txtTelefone.TabIndex = 4;
            // 
            // pnTipoPessoa
            // 
            this.pnTipoPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTipoPessoa.Location = new System.Drawing.Point(11, 138);
            this.pnTipoPessoa.Name = "pnTipoPessoa";
            this.pnTipoPessoa.Size = new System.Drawing.Size(923, 34);
            this.pnTipoPessoa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "CpfCnpj";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpj.Location = new System.Drawing.Point(375, 68);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(545, 23);
            this.txtCpfCnpj.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(375, 20);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(545, 23);
            this.txtSobrenome.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(3, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(366, 23);
            this.txtNome.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.36918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.63082F));
            this.tableLayoutPanel1.Controls.Add(this.txtCpfCnpj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSobrenome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 112);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pageDadosTipo
            // 
            this.pageDadosTipo.Controls.Add(this.tabControl);
            this.pageDadosTipo.Location = new System.Drawing.Point(4, 22);
            this.pageDadosTipo.Name = "pageDadosTipo";
            this.pageDadosTipo.Padding = new System.Windows.Forms.Padding(3);
            this.pageDadosTipo.Size = new System.Drawing.Size(951, 185);
            this.pageDadosTipo.TabIndex = 2;
            this.pageDadosTipo.Text = "Tipo De Pessoa";
            this.pageDadosTipo.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(945, 179);
            this.tabControl.TabIndex = 6;
            // 
            // pageEndereco
            // 
            this.pageEndereco.Controls.Add(this.gbEndereco);
            this.pageEndereco.Location = new System.Drawing.Point(4, 22);
            this.pageEndereco.Name = "pageEndereco";
            this.pageEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.pageEndereco.Size = new System.Drawing.Size(951, 185);
            this.pageEndereco.TabIndex = 3;
            this.pageEndereco.Text = "Endereços";
            this.pageEndereco.UseVisualStyleBackColor = true;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.Location = new System.Drawing.Point(3, 3);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(945, 179);
            this.gbEndereco.TabIndex = 8;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereco";
            // 
            // FrmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 256);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FrmPessoa";
            this.Text = "FrmPessoa";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.pageBusca.ResumeLayout(false);
            this.pageBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaPessoa)).EndInit();
            this.pageDados.ResumeLayout(false);
            this.gbDadosPessoa.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pageDadosTipo.ResumeLayout(false);
            this.pageEndereco.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageDados;
        private System.Windows.Forms.GroupBox gbDadosPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnTipoPessoa;
        private System.Windows.Forms.TabPage pageBusca;
        private System.Windows.Forms.DataGridView dgvBuscaPessoa;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage pageDadosTipo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageEndereco;
        private System.Windows.Forms.GroupBox gbEndereco;
    }
}