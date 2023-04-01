using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlEngredienteSabor : UserControl , IViewCadastroEngredienteSabor
    {
        public UserControlEngredienteSabor()
        {
            InitializeComponent();
        }

        public GroupBox GbEndredientesCadastrados
        {
            get{ return gbEngredientesCadastrados; }
        }

        public GroupBox GbEndredientesSabor
        {
            get { return gbEngredientesSabor; }
        }

        public string BuscarEngredientesCadastrados
        {
            get { return txtBuscaEngredientesCadastrados.Text; }
        }

        public string BuscarEngredientesSabor
        {
            get { return txtBuscaEngredientesVinculados.Text; }
        }

        public EngredienteModel EngredienteSelecionadoGridEngredienteCadastrado
        {
            get
            {
                try
                {
                    return (EngredienteModel)dgvEngredientesCadastrado.CurrentRow.DataBoundItem;

                }
                catch
                {

                    return null;
                }
            }


        }
        public EngredienteModel EngredienteSelecionadoGridEngredienteSabor
        {
            get
            {
                try
                {
                    return (EngredienteModel)dgvEngredientesSabor.CurrentRow.DataBoundItem;

                }
                catch
                {

                    return null;
                }
            }


        }

        public void EventoBuscaEngredienteCadastrados(EventHandler e)
        {
            txtBuscaEngredientesCadastrados.Enter += e;
        }

        public void EventoBuscaEngredienteSabor(EventHandler e)
        {
            txtBuscaEngredientesVinculados.Enter += e;
        }

        public void EventoGridEngredientesCadastrados(EventHandler e)
        {
            dgvEngredientesCadastrado.DoubleClick += e;
        }

        public void EventoGridEngredientesSabor(EventHandler e)
        {
            dgvEngredientesSabor.DoubleClick += e;
        }

        public void PopularGridEngredientesCadastrados(List<EngredienteModel> Lista)
        {
            dgvEngredientesCadastrado.DataSource = Lista;
        }

        public void PopularGridEngredientesSabor(List<EngredienteModel> Lista)
        {
            dgvEngredientesSabor.DataSource = Lista;
        }
    }
}
