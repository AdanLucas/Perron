
namespace Perron
{
    partial class UserControlStatusCadastro
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
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.ckInativo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckAtivo
            // 
            this.ckAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Location = new System.Drawing.Point(6, 7);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(61, 21);
            this.ckAtivo.TabIndex = 0;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // ckInativo
            // 
            this.ckInativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckInativo.AutoSize = true;
            this.ckInativo.Location = new System.Drawing.Point(72, 7);
            this.ckInativo.Name = "ckInativo";
            this.ckInativo.Size = new System.Drawing.Size(71, 21);
            this.ckInativo.TabIndex = 0;
            this.ckInativo.Text = "Inativo";
            this.ckInativo.UseVisualStyleBackColor = true;
            // 
            // UserControlStatusCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckInativo);
            this.Controls.Add(this.ckAtivo);
            this.Name = "UserControlStatusCadastro";
            this.Size = new System.Drawing.Size(148, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.CheckBox ckInativo;
    }
}
