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

