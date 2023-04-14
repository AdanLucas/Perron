using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlExibirStatusCadastro : UserControl
    {



        public UserControlExibirStatusCadastro()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }

        public Button Status
        {
            get
            {
                return button;
            }

        }
    }

}

