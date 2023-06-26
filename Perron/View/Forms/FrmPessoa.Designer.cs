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
            this.dgvBuscaPessoa = new System.Windows.Forms.DataGridView();
            this.pageDados = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.gbDadosPessoa = new System.Windows.Forms.GroupBox();
            this.pnTipoPessoa = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.pageBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaPessoa)).BeginInit();
            this.pageDados.SuspendLayout();
            this.gbDadosPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.pageBusca);
            this.tabControl1.Controls.Add(this.pageDados);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 228);
            this.tabControl1.TabIndex = 3;
            // 
            // pageBusca
            // 
            this.pageBusca.Controls.Add(this.dgvBuscaPessoa);
            this.pageBusca.Location = new System.Drawing.Point(4, 22);
            this.pageBusca.Name = "pageBusca";
            this.pageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.pageBusca.Size = new System.Drawing.Size(439, 451);
            this.pageBusca.TabIndex = 1;
            this.pageBusca.Text = "Buscar Pessoa";
            this.pageBusca.UseVisualStyleBackColor = true;
            // 
            // dgvBuscaPessoa
            // 
            this.dgvBuscaPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuscaPessoa.Location = new System.Drawing.Point(3, 3);
            this.dgvBuscaPessoa.Name = "dgvBuscaPessoa";
            this.dgvBuscaPessoa.Size = new System.Drawing.Size(433, 445);
            this.dgvBuscaPessoa.TabIndex = 0;
            // 
            // pageDados
            // 
            this.pageDados.Controls.Add(this.tabControl);
            this.pageDados.Controls.Add(this.gbDadosPessoa);
            this.pageDados.Location = new System.Drawing.Point(4, 22);
            this.pageDados.Name = "pageDados";
            this.pageDados.Padding = new System.Windows.Forms.Padding(3);
            this.pageDados.Size = new System.Drawing.Size(439, 202);
            this.pageDados.TabIndex = 0;
            this.pageDados.Text = "Dados";
            this.pageDados.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 198);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(433, 1);
            this.tabControl.TabIndex = 5;
            // 
            // gbDadosPessoa
            // 
            this.gbDadosPessoa.Controls.Add(this.pnTipoPessoa);
            this.gbDadosPessoa.Controls.Add(this.label4);
            this.gbDadosPessoa.Controls.Add(this.txtCpfCnpj);
            this.gbDadosPessoa.Controls.Add(this.label3);
            this.gbDadosPessoa.Controls.Add(this.label2);
            this.gbDadosPessoa.Controls.Add(this.label1);
            this.gbDadosPessoa.Controls.Add(this.txtTelefone);
            this.gbDadosPessoa.Controls.Add(this.txtSobrenome);
            this.gbDadosPessoa.Controls.Add(this.txtNome);
            this.gbDadosPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDadosPessoa.Location = new System.Drawing.Point(3, 3);
            this.gbDadosPessoa.Name = "gbDadosPessoa";
            this.gbDadosPessoa.Size = new System.Drawing.Size(433, 195);
            this.gbDadosPessoa.TabIndex = 4;
            this.gbDadosPessoa.TabStop = false;
            this.gbDadosPessoa.Text = "Dados Pessoa";
            // 
            // pnTipoPessoa
            // 
            this.pnTipoPessoa.Location = new System.Drawing.Point(11, 148);
            this.pnTipoPessoa.Name = "pnTipoPessoa";
            this.pnTipoPessoa.Size = new System.Drawing.Size(403, 34);
            this.pnTipoPessoa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CpfCnpj";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(222, 99);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(192, 20);
            this.txtCpfCnpj.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(11, 99);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(174, 20);
            this.txtTelefone.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(222, 45);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(192, 20);
            this.txtSobrenome.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 0;
            // 
            // FrmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 273);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPessoa";
            this.Text = "FrmPessoa";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.pageBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaPessoa)).EndInit();
            this.pageDados.ResumeLayout(false);
            this.gbDadosPessoa.ResumeLayout(false);
            this.gbDadosPessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageBusca;
        private System.Windows.Forms.TabPage pageDados;
        private System.Windows.Forms.GroupBox gbDadosPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnTipoPessoa;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dgvBuscaPessoa;
    }
}