using Perron.View.Forms.Form_Padrao_Cadastro;
using System.Drawing;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmPessoa : FrmPadraoCadastro, IViewCadastroPessoa
    {
        protected override Size TamanhoTelaCheia { get { return new Size() { Width = 491, Height = 725 }; } }
        protected override Size TamanhoTelaReduzida { get { return new Size() { Width = 491, Height = 600 }; } }

        public FrmPessoa()
        {
            InitializeComponent();
        }

        public GroupBox GBEndereco { get { return this.gbEndereco; } }
        public string Nome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public string Sobrenome { get { return txtSobrenome.Text; } set { txtSobrenome.Text = value; } }
        public string CpfCnpj { get { return txtCpfCnpj.Text; } set { txtCpfCnpj.Text = value; } }
        public string Telefone { get { return txtTelefone.Text; } set { txtTelefone.Text = value; } }
        public Panel PainelTipoPesso { get { return pnTipoPessoa; } }
        public TabControl TabControlTipoPessoa { get { return this.tabControl; } }
        public DataGridView GridViewBusca { get { return dgvBuscaPessoa; } }
        public string DescricaoTela { set { this.Text = value; } }
    }
}
