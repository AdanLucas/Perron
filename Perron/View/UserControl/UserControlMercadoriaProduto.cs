using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlMercadoriaProduto : UserControl, IViewCadastroMercadoriaProduto
    {
        public Panel Painel { get {return panelGrid;} }

        public UserControlMercadoriaProduto()
        {
            InitializeComponent();
        }
    }
}
