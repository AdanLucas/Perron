namespace Perron.View
{
    partial class FrmNotificacao
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
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrincipal = new System.Windows.Forms.Label();
            this.txtMenssagemLonga = new System.Windows.Forms.RichTextBox();
            this.txtRodape = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(6, 14);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(95, 93);
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(60, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(3, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 26);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(458, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 26);
            this.panel1.TabIndex = 2;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.AutoSize = true;
            this.txtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.Location = new System.Drawing.Point(107, 47);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(0, 20);
            this.txtPrincipal.TabIndex = 3;
            // 
            // txtMenssagemLonga
            // 
            this.txtMenssagemLonga.AcceptsTab = true;
            this.txtMenssagemLonga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenssagemLonga.Location = new System.Drawing.Point(6, 113);
            this.txtMenssagemLonga.Name = "txtMenssagemLonga";
            this.txtMenssagemLonga.Size = new System.Drawing.Size(573, 68);
            this.txtMenssagemLonga.TabIndex = 4;
            this.txtMenssagemLonga.Text = "";
            // 
            // txtRodape
            // 
            this.txtRodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRodape.AutoSize = true;
            this.txtRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRodape.Location = new System.Drawing.Point(12, 192);
            this.txtRodape.Name = "txtRodape";
            this.txtRodape.Size = new System.Drawing.Size(0, 20);
            this.txtRodape.TabIndex = 3;
            // 
            // FrmNotificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 221);
            this.Controls.Add(this.txtMenssagemLonga);
            this.Controls.Add(this.txtRodape);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbImagem);
            this.MinimumSize = new System.Drawing.Size(530, 260);
            this.Name = "FrmNotificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.RichTextBox txtMenssagemLonga;
        private System.Windows.Forms.Label txtPrincipal;
        private System.Windows.Forms.Label txtRodape;
    }
}