﻿namespace Perron.View.Forms
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTamanho = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPrecos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.DescricaoClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnPreco = new System.Windows.Forms.Panel();
            this.btnAddPreco = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.pnPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTamanho);
            this.groupBox2.Location = new System.Drawing.Point(9, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamanho";
            // 
            // dgvTamanho
            // 
            this.dgvTamanho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTamanho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamanho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTamanho.Location = new System.Drawing.Point(3, 16);
            this.dgvTamanho.MultiSelect = false;
            this.dgvTamanho.Name = "dgvTamanho";
            this.dgvTamanho.ReadOnly = true;
            this.dgvTamanho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanho.Size = new System.Drawing.Size(343, 65);
            this.dgvTamanho.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPrecos);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 162);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preços Cadastrados";
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
            this.dgvPrecos.Size = new System.Drawing.Size(359, 143);
            this.dgvPrecos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClasses);
            this.groupBox1.Location = new System.Drawing.Point(9, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescricaoClasse});
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasses.Location = new System.Drawing.Point(3, 16);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(343, 101);
            this.dgvClasses.TabIndex = 1;
            // 
            // DescricaoClasse
            // 
            this.DescricaoClasse.DataPropertyName = "DescricaoClasse";
            this.DescricaoClasse.HeaderText = "Descricão Classe";
            this.DescricaoClasse.Name = "DescricaoClasse";
            this.DescricaoClasse.ReadOnly = true;
            // 
            // pnPreco
            // 
            this.pnPreco.Controls.Add(this.btnAddPreco);
            this.pnPreco.Controls.Add(this.txtPreco);
            this.pnPreco.Controls.Add(this.label1);
            this.pnPreco.Location = new System.Drawing.Point(12, 265);
            this.pnPreco.Name = "pnPreco";
            this.pnPreco.Size = new System.Drawing.Size(343, 77);
            this.pnPreco.TabIndex = 8;
            // 
            // btnAddPreco
            // 
            this.btnAddPreco.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPreco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPreco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPreco.FlatAppearance.BorderSize = 5;
            this.btnAddPreco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPreco.Location = new System.Drawing.Point(245, 13);
            this.btnAddPreco.Name = "btnAddPreco";
            this.btnAddPreco.Size = new System.Drawing.Size(82, 51);
            this.btnAddPreco.TabIndex = 2;
            this.btnAddPreco.UseVisualStyleBackColor = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(95, 16);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 45);
            this.txtPreco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "R$:";
            // 
            // FrmCadastroPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 507);
            this.Controls.Add(this.pnPreco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroPreco";
            this.Text = "Cadastrando Preço";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnPreco, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.pnPreco.ResumeLayout(false);
            this.pnPreco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTamanho;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPrecos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoClasse;
        private System.Windows.Forms.Panel pnPreco;
        private System.Windows.Forms.Button btnAddPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
    }
}