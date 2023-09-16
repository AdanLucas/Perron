using Model.Interface.View;
using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;

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
        public ClasseModel ClasseSelecioanda
        {
            get
            {
                try
                {
                    return (ClasseModel)dgvClasses.CurrentRow.DataBoundItem;
                }
                catch (Exception)
                {

                    return null;
                }
            }


        }
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
        public bool HabilitarGridClasse { set { dgvClasses.Enabled = value; } }
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
        public void SetarListaClasse(List<ClasseModel> ListaClasse)
        {
            dgvClasses.DataSource = null;

            if (ListaClasse != null)
            {
                dgvClasses.DataSource = ListaClasse;
                dgvClasses.Columns["Id"].Visible = false;
                dgvClasses.Columns["Ativo"].Visible = false;
            }
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
    }
}
