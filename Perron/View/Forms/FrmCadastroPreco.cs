using Model.Interface.View;
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
    public partial class FrmCadastroPreco : FrmPadraoCadastro , IViewCadastroPreco
    {
        public FrmCadastroPreco()
        {
            InitializeComponent();
            ConfigurarBotao();
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
            }
        }

        public void SetarListaPrecosCadastrados(List<object> ListaPreco)
        {
            dgvPrecos.DataSource = null;


            if (ListaPreco != null)
            {
                dgvPrecos.DataSource = ListaPreco;
            }
        }

        public void SetarListatamanho(List<TamanhoModel> ListaTamanho)
        {
            dgvTamanho.DataSource = null;

            if(ListaTamanho!= null)
            {
                dgvTamanho.DataSource = ListaTamanho;
            }
        }

    }
}
