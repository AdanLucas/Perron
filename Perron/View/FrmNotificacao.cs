using System.Drawing;
using System.Windows.Forms;

namespace Perron.View
{
    public partial class FrmNotificacao : Form
    {


        public string TextoTela { set { this.Text = value; } }
        public string TextoRodape { set { this.txtRodape.Text = value; } }
        public string TextoPrincipal { set { txtPrincipal.Text = value; } }
        public string TextoLongo { set { txtMenssagemLonga.Text = value; } }
        public Image Imagem { set { this.pbImagem.Image = value; } }
        public Button BotaoOk { get { return this.btnOk; } }
        public Button BotaoCancelar { get { return this.btnCancelar; } }
        public FrmNotificacao()
        {
            InitializeComponent();
        }
    }
}
