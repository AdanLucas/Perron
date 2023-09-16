using System;
using System.Windows.Forms;

namespace Perron.View
{
    public partial class UCTipoFuncionario : UserControl
    {
        public DateTime DatraContrato { get { return tpkDataContratacao.Value; } set { tpkDataContratacao.Value = value; } }

        public decimal Salario
        {
            get
            {
                try
                {
                    return Convert.ToDecimal(txtSalario.Text);
                }
                catch
                {
                    txtSalario.Clear();
                    return -1;
                }
            }
            set
            {
                txtSalario.Text = value.ToString();
            }

        }

        public UCTipoFuncionario()
        {
            InitializeComponent();
        }


    }
}
