namespace Perron.View
{
    partial class TipoPessoaComponente
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
            this.pnElemento = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnElemento
            // 
            this.pnElemento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnElemento.Location = new System.Drawing.Point(15, 3);
            this.pnElemento.Name = "pnElemento";
            this.pnElemento.Size = new System.Drawing.Size(111, 30);
            this.pnElemento.TabIndex = 0;
            // 
            // TipoPessoaComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnElemento);
            this.Name = "TipoPessoaComponente";
            this.Size = new System.Drawing.Size(142, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnElemento;
    }
}
