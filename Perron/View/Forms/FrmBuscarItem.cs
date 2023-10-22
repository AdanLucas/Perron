using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmBuscarItem : Form
    {
        public Panel Painel { get { return this.painelGrid; } }
        public EventHandler EventoBusca {  get; set; }
        public FrmBuscarItem()
        {
            InitializeComponent();
            
        }

        private void dgvItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if(EventoBusca != null)
                    EventoBusca(txtBusca.Text, EventArgs.Empty);
        }
    }
}
