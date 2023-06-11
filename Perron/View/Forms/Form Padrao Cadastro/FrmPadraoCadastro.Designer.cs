
namespace Perron.View.Forms.Form_Padrao_Cadastro
{
    partial class FrmPadraoCadastro
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckInativo = new System.Windows.Forms.CheckBox();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderSize = 3;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(68, 33);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderSize = 3;
            this.btnSalvar.Location = new System.Drawing.Point(68, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(68, 33);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 33);
            this.panel1.TabIndex = 2;
            // 
            // ckInativo
            // 
            this.ckInativo.AutoSize = true;
            this.ckInativo.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckInativo.Location = new System.Drawing.Point(63, 0);
            this.ckInativo.Margin = new System.Windows.Forms.Padding(2);
            this.ckInativo.Name = "ckInativo";
            this.ckInativo.Size = new System.Drawing.Size(58, 33);
            this.ckInativo.TabIndex = 3;
            this.ckInativo.Text = "Inativo";
            this.ckInativo.UseVisualStyleBackColor = true;
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckAtivo.Location = new System.Drawing.Point(0, 0);
            this.ckAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 33);
            this.ckAtivo.TabIndex = 3;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.Location = new System.Drawing.Point(204, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemover.FlatAppearance.BorderSize = 3;
            this.btnRemover.Location = new System.Drawing.Point(136, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(68, 33);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckAtivo);
            this.panel2.Controls.Add(this.ckInativo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(292, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 33);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(272, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 33);
            this.panel3.TabIndex = 5;
            // 
            // FrmPadraoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 511);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FrmPadraoCadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckInativo;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}