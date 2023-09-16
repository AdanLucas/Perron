using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Perron.View.Forms
{
    public partial class FrmCadastroIngrediente : FrmPadraoCadastro, IViewCadastroIngrediente
    {
        protected override Size TamanhoTelaCheia { get { return new Size() { Width = 493, Height = 653 }; } }
        protected override Size TamanhoTelaReduzida { get { return new Size() { Width = 493, Height = 160 }; } }


        public FrmCadastroIngrediente()
        {
            InitializeComponent();

            txtDescricao.TextChanged += EventoBuscar;
        }

        public bool VisibilidadeGroupEngredientes { set { gbEngredientes.Visible = value; } }
        public bool HabilitaComboTipoMedida { set { cbTipoMedida.Enabled = value; } }

        public string DescricaoIngrediente
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }

        }
        public EngredienteModel IngredienteSelecionado
        {
            get
            {
                try
                {
                    return (EngredienteModel)dgvIngredientes.CurrentRow.DataBoundItem;
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
            dgvIngredientes.DoubleClick += e;
        }
        public EventHandler EventoBuscar { get; set; }
        public void PopularGridIngredientes(List<EngredienteModel> Ingredientes)
        {
            dgvIngredientes.DataSource = null;


            if (Ingredientes != null)
            {
                dgvIngredientes.DataSource = Ingredientes;
                dgvIngredientes.Columns["Id"].Visible = false;
                dgvIngredientes.Columns["Ativo"].Visible = false;
                dgvIngredientes.Columns["TipoMedida"].Visible = false;
                dgvIngredientes.Columns["Descricao"].HeaderText = "Descrição";
                dgvIngredientes.Columns["DescricaoTipoMedida"].HeaderText = "Tipo Medida";
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
