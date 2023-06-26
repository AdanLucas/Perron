using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmPessoa : FrmPadraoCadastro, IViewCadastroPessoa
    {

        public FrmPessoa()
        {
            InitializeComponent();
        }

        public string Nome { get{ return txtNome.Text; }set { txtNome.Text = value; } }
        public string Sobrenome { get { return txtSobrenome.Text; } set { txtSobrenome.Text = value; } }
        public string CpfCnpj { get { return txtCpfCnpj.Text; } set { txtCpfCnpj.Text = value; } }
        public string Telefone { get { return txtTelefone.Text; } set { txtTelefone.Text = value; } }
        public Panel PainelTipoPesso { get { return pnTipoPessoa; } }
        public TabControl TabControlTipoPessoa { get { return this.tabControl; } }
        public DataGridView GridViewBusca { get { return dgvBuscaPessoa;} }
        public string DescricaoTela { set { this.Text = value; } }
    }
}
