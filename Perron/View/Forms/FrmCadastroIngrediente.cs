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
    public partial class FrmCadastroIngrediente:FrmPadraoCadastro, IViewCadastroIngrediente
    {
        public FrmCadastroIngrediente()
        {
            InitializeComponent();
        }

        public bool VisibilidadeGroupEngredientes { set { gbEngredientes.Visible = value; }}
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
        public void EventoGrid(EventHandler e)
        {
            dgvIngredientes.DoubleClick += e;
        }
        public void EventoBuscar(EventHandler e)
        {
            txtDescricao.TextChanged += e;
        }
        public void PopularGridIngredientes(List<EngredienteModel> Ingredientes)
        {
            dgvIngredientes.DataSource = null;


            if(Ingredientes != null)
            {
                dgvIngredientes.DataSource = Ingredientes;
                dgvIngredientes.Columns["Id"].Visible = false;
                dgvIngredientes.Columns["Ativo"].Visible = false;
            }
        }
        private void FrmCadastroIngrediente_Load(object sender, EventArgs e)
        {

        }
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}
