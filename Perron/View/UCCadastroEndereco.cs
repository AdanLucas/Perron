using Model.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron.View
{
    public partial class UCCadastroEndereco : UserControl
    {




        public EnderecoModel EnderecoSelecionado
        {
            get
            {
                try
                {
                    return (EnderecoModel)dgvEndereco.CurrentRow.DataBoundItem;
                }
                catch (Exception)
                {

                    return null;
                }

            }
        }

        public string Rua { get { return txtRua.Text; } set { txtRua.Text = value; } }
        public string Numero { get { return txtNumero.Text; } set { txtNumero.Text = value; } }
        public string Descricao { get { return txtDescricao.Text; } set { txtDescricao.Text = value; } }
        public string Bairro { get { return txtBairro.Text; } set { txtBairro.Text = value; } }
        public string Cidade { get { return txtCidade.Text; } set { txtCidade.Text = value; } }
        public bool HabilitarCampos { set { habilitarCampos(value); } }
        public bool VisibidadeBotoes { set { panelBotaoes.Visible = value; } }

        public EventHandler EventoAdd;
        public EventHandler EventoRemove;
        public EventHandler EventoGrid;
        
        public void AltarandoComporamentoTela(EComportamentoTela comportamento)
        {

        }

        public void PopularGrid(List<EnderecoModel> lista)
        {
            dgvEndereco.DataSourceCuston(lista);
        }

        private void habilitarCampos(bool hab)
        {
            txtBairro.ReadOnly = !hab;
            txtRua.ReadOnly = !hab;
            txtDescricao.ReadOnly = !hab;
            txtNumero.ReadOnly = !hab;
            txtRua.ReadOnly = !hab;
            txtCidade.ReadOnly = !hab;
        }

        public UCCadastroEndereco()
        {
            InitializeComponent();

            btnAdd.Click += EventoAdd;
            btnRemover.Click += EventoRemove;
            dgvEndereco.Click += EventoGrid;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EventoAdd != null)
                EventoAdd(this, EventArgs.Empty);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(EventoRemove != null)
                EventoRemove(this, EventArgs.Empty);
        }
    }
}
