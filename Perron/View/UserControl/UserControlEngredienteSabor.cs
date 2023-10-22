using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlEngredienteSabor : UserControl, IViewCadastroEngredienteSabor
    {

        public DataGridView DataItem { get { return dgvIngrendiente; } }

        public Panel Painel { get {return panelGrid;} }

        public UserControlEngredienteSabor()
        {
            InitializeComponent();
        }
    }
}
