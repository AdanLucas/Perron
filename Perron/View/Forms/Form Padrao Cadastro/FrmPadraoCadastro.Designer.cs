
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.ckInativo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderSize = 3;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 27);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderSize = 3;
            this.btnSalvar.Location = new System.Drawing.Point(91, 0);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 27);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckInativo);
            this.panel1.Controls.Add(this.ckAtivo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 27);
            this.panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.Location = new System.Drawing.Point(273, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemover.FlatAppearance.BorderSize = 3;
            this.btnRemover.Location = new System.Drawing.Point(182, 0);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(91, 27);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Location = new System.Drawing.Point(424, 3);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(61, 21);
            this.ckAtivo.TabIndex = 3;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // ckInativo
            // 
            this.ckInativo.AutoSize = true;
            this.ckInativo.Location = new System.Drawing.Point(528, 4);
            this.ckInativo.Name = "ckInativo";
            this.ckInativo.Size = new System.Drawing.Size(71, 21);
            this.ckInativo.TabIndex = 3;
            this.ckInativo.Text = "Inativo";
            this.ckInativo.UseVisualStyleBackColor = true;
            // 
            // FrmPadraoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 714);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPadraoCadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckInativo;
        private System.Windows.Forms.CheckBox ckAtivo;
    }
}