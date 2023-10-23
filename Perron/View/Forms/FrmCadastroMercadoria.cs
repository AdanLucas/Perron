using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Perron.View.Forms
{
    public partial class FrmCadastroMercadoria : FrmPadraoCadastro, IViewCadastroMercadoria
    {
        protected override Size TamanhoTelaCheia { get { return new Size() { Width = 493, Height = 653 }; } }
        protected override Size TamanhoTelaReduzida { get { return new Size() { Width = 493, Height = 160 }; } }


        public FrmCadastroMercadoria()
        {
            InitializeComponent();

            txtDescricao.TextChanged += EventoBuscar;
        }

        public bool VisibilidadeGroupEngredientes { set { gbEngredientes.Visible = value; } }
        public bool HabilitaComboTipoMedida { set { cbTipoMedida.Enabled = value; } }

        public string DescricaoMercadoria
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }

        }
        public MercadoriaModel MercadoriaSelecionado
        {
            get
            {
                try
                {
                    return (MercadoriaModel)dgvMercadoria.CurrentRow.DataBoundItem;
                }
                catch
                {

                    return null;
                }


            }

        }

        public EUnidadeMedida TipoMedida { get { return GetUnidadeMedida(); } set { SetarUnidadeMedida(value); } }

        public void EventoGrid(EventHandler e)
        {
            dgvMercadoria.DoubleClick += e;
        }
        public EventHandler EventoBuscar { get; set; }
        public void PopularGridIngredientes(List<MercadoriaModel> Ingredientes)
        {
            dgvMercadoria.DataSource = null;


            if (Ingredientes != null)
            {
                dgvMercadoria.DataSource = Ingredientes;
                dgvMercadoria.Columns["Id"].Visible = false;
                dgvMercadoria.Columns["Ativo"].Visible = false;
                dgvMercadoria.Columns["TipoMedida"].Visible = false;
                dgvMercadoria.Columns["Descricao"].HeaderText = "Descrição";
                dgvMercadoria.Columns["DescricaoTipoMedida"].HeaderText = "Tipo Medida";
            }
        }
        private void FrmCadastroIngrediente_Load(object sender, EventArgs e)
        {

        }
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetarUnidadeMedida(EUnidadeMedida tipomedida)
        {
            cbTipoMedida.SelectedIndex = (int)tipomedida;
        }
        private EUnidadeMedida GetUnidadeMedida()
        {
            return (EUnidadeMedida)cbTipoMedida.SelectedIndex;
        }


    }
}
