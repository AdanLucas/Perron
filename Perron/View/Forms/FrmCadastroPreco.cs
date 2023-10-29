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
        public TamanhoModel TamanhoSelecionado
        {
            get
            {
                try
                {
                    return (TamanhoModel)dgvTamanho.CurrentRow.DataBoundItem;
                }
                catch (Exception)
                {

                    return null;
                }
            }


        }
        
        public string DescricaoClasse { set { } }
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
        }
        public ContextMenuStrip BotaoDireito { get {return this.menuBotaoDireitoClasse;} }
        public PrecoView PrecoSelecionado
        {
            get
            {
                try
                {
                    return (PrecoView)dgvPrecos.CurrentRow.DataBoundItem;
                }
                catch
                {
                    throw null;
                }
            }
        }
        public bool VisibilidadePainel { set { pnPreco.Visible = value; } }
        
        public void EventoGridClasse(EventHandler e)
        {
            dgvClasses.Click += e;
        }
        public void EventoGridPrecos(EventHandler e)
        {
            dgvPrecos.Click += e;
        }
        public void EventoGridTamanho(EventHandler e)
        {
            dgvTamanho.Click += e;

        }
        
        public void SetarListaPrecosCadastrados(List<PrecoView> ListaPreco)
        {
            dgvPrecos.DataSource = null;


            if (ListaPreco != null)
            {
                dgvPrecos.DataSource = ListaPreco;
                dgvPrecos.Columns["Index"].Visible = false;

            }
        }
        public void SetarListatamanho(List<TamanhoModel> ListaTamanho)
        {
            dgvTamanho.DataSource = null;

            if (ListaTamanho != null)
            {
                dgvTamanho.DataSource = ListaTamanho;
                dgvTamanho.Columns["Id"].Visible = false;
                dgvTamanho.Columns["Ativo"].Visible = false;
                dgvTamanho.Columns["QntPedacos"].HeaderText = "Quantidade de Pedaços";
                dgvTamanho.Columns["Descricao"].HeaderText = "Descrição";

            }
        }
        public void EventoAdicionarPreco(EventHandler e)
        {
            btnAddPreco.Click += e;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
