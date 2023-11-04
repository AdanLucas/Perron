using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Perron.View.Forms
{
    public partial class FrmCadastroMercadoria : FrmPadraoCadastro, IViewCadastroMercadoria
    {
        protected override Size TamanhoTelaCheia { get { return new Size() { Width = 493, Height = 653 }; } }
        protected override Size TamanhoTelaReduzida { get { return new Size() { Width = 493, Height = 240 }; } }

        public FrmCadastroMercadoria()
        {
            InitializeComponent();

            txtDescricao.TextChanged += EventoBuscar;
        }
        
        public ComboBox SelecaoTipoMercadoria { get { return this.comboTipoMercadoria; } }
        public ComboBox SelecaoTipoMedida { get { return cbTipoMedida; } }
        public TextBox TxtDescricao { get { return txtDescricao; } }
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


        public DataGridView DgvMercadoria { get { return this.dgvMercadoria; } }
        public void EventoGrid(EventHandler e)
        {
            dgvMercadoria.DoubleClick += e;
        }
        public EventHandler EventoBuscar { get; set; }
        public void PopularGridIngredientes(List<MercadoriaModel> Ingredientes)
        {
            dgvMercadoria.DataSource = null;
            dgvMercadoria.DataSource = Ingredientes;
        
        }
    
  


    }
}
