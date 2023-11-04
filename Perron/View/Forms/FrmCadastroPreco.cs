using Model.Interface.View;
using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmCadastroPreco : FrmPadraoCadastro, IViewCadastroPreco
    {
        public FrmCadastroPreco()
        {
            InitializeComponent();
            COnfigurarTela();
        }

        private void COnfigurarTela()
        {
            btnAddPreco.Image = Properties.Resources.add;
            base.VisibilidadeckAtivo = false;
            base.VisibilidadeckInativo = false;
        }
        
        
        public string DescricaoClasse { set { txtDescricaoClasse.Text = value; } }
        public string DescricaoTamanho { set { txtTamanho.Text = value; } }
        public decimal PrecoInformado
        {
            get
            {
                try
                {

                    return Convert.ToDecimal(txtPreco.Text);

                }
                catch (Exception)
                {

                    return 0;
                }
            }
            set { txtPreco.Text = value.ToString(); }
        }
        public ContextMenuStrip BotaoDireitoClasse { get {return this.menuBotaoDireitoClasse;} }
        public ContextMenuStrip BotaoDireitoTamanho { get { return this.menuBotaoDireitoTamanho; } }
        public DataGridView GridPrecos { get { return dgvPrecos; } }
        public GroupBox GbDadosCadastro { get { return gbDadosCadastro; } }
        public GroupBox GbPrecosCadastrados { get { return gbPrecosCadastrados;} }
        public void EventoAdicionarPreco(EventHandler e)
        {
            btnAddPreco.Click += e;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
