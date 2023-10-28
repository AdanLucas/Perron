namespace Perron.View
{
    partial class UCTipoMedida
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
            this.ckun = new System.Windows.Forms.CheckBox();
            this.ckkg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckun
            // 
            this.ckun.AutoSize = true;
            this.ckun.Location = new System.Drawing.Point(13, 8);
            this.ckun.Name = "ckun";
            this.ckun.Size = new System.Drawing.Size(66, 17);
            this.ckun.TabIndex = 0;
            this.ckun.Text = "Unidade";
            this.ckun.UseVisualStyleBackColor = true;
            // 
            // ckkg
            // 
            this.ckkg.AutoSize = true;
            this.ckkg.Location = new System.Drawing.Point(99, 8);
            this.ckkg.Name = "ckkg";
            this.ckkg.Size = new System.Drawing.Size(72, 17);
            this.ckkg.TabIndex = 1;
            this.ckkg.Text = "Kilograma";
            this.ckkg.UseVisualStyleBackColor = true;
            // 
            // UCTipoMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckkg);
            this.Controls.Add(this.ckun);
            this.Name = "UCTipoMedida";
            this.Size = new System.Drawing.Size(192, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckun;
        private System.Windows.Forms.CheckBox ckkg;
    }
}
