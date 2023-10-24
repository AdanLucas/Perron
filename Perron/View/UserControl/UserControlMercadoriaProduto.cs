using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlMercadoriaProduto : UserControl, IViewCadastroMercadoriaProduto
    {

        public DataGridView DataItem { get { return dgvIngrendiente; } }

        public Panel Painel { get {return panelGrid;} }

        public UserControlMercadoriaProduto()
        {
            InitializeComponent();
        }
    }
}
