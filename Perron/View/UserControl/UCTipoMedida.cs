using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.View
{
    public partial class UCTipoMedida : UserControl
    {
        public UCTipoMedida()
        {
            InitializeComponent();
        }

        public CheckBox ckUn { get { return this.ckun; } }
        public CheckBox ckKg { get { return this.ckkg; } }
    }
}
