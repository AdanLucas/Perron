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
    public partial class FrmCadastroIngrediente : FrmPadraoCadastro, IViewCadastroIngrediente
    {
        public FrmCadastroIngrediente()
        {
            InitializeComponent();
        }

        public string DescricaoIngrediente
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }
        
        }

        public IngredienteModel IngredienteSelecionado
        {
            get
            {
                try
                {
                    return (IngredienteModel)dgvIngredientes.CurrentRow.DataBoundItem;
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

        public void PopularGridIngredientes(List<IngredienteModel> Ingredientes)
        {
            dgvIngredientes.DataSource = Ingredientes;
        }
    }
}
