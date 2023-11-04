using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
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
            this.txtBuscar.TextChanged += txtBuscar_TextChanged;
        }
        public EventHandler EventoGridBusca { get; set; }
        public EventHandler EventoBusca { get; set; }
        public List<PessoaModel> ListaPessoaSendoExibidos { set { SetarListGrid(value); } }
        public GroupBox GBEndereco { get { return this.gbEndereco; } }
        public string Nome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public string Sobrenome { get { return txtSobrenome.Text; } set { txtSobrenome.Text = value; } }
        public string CpfCnpj { get { return txtCpfCnpj.Text; } set { txtCpfCnpj.Text = value; } }
        public string Telefone { get { return txtTelefone.Text; } set { txtTelefone.Text = value; } }
        public Panel PainelTipoPesso { get { return pnTipoPessoa; } }
        public TabControl TabControlTipoPessoa { get { return this.tabControl; } }
        public DataGridView GridViewBusca { get { return dgvBuscaPessoa; } }
        public string DescricaoTela { set { this.Text = value; } }

        public PessoaModel PessaoSelecionada
        { get
            {
                try
                {
                    return (PessoaModel)dgvBuscaPessoa.CurrentRow.DataBoundItem;
                }
                catch
                {
                    return null;
                }
            } 
        }
        public string TextoBusca { get { return txtBuscar.Text; } }
        private void SetarListGrid(List<PessoaModel> lista)
        {
            dgvBuscaPessoa.DataSource = null;
            dgvBuscaPessoa.DataSource = lista;
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (EventoBusca != null)
                this.EventoBusca(sender, EventArgs.Empty);
        }

        private void dgvBuscaPessoa_DoubleClick(object sender, EventArgs e)
        {
            if (EventoGridBusca != null)
                this.EventoGridBusca(sender, EventArgs.Empty);
        }
    }
}
