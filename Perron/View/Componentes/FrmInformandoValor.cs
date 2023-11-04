using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.View.Componentes
{
    public partial class FrmInformandoValor : Form
    {

        public decimal Valor { get { return Convert.ToDecimal(textBox1.Text); } }

        public EventHandler EventoOK {  get; set; }

        public FrmInformandoValor()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (EventoOK != null)
                    EventoOK(sender, e);
        }
    }
}
