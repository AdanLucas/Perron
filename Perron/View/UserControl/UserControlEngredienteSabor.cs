using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Perron
{
    public partial class UserControlEngredienteSabor : UserControl, IViewCadastroEngredienteSabor
    {
        public UserControlEngredienteSabor()
        {
            InitializeComponent();

        }

        public GroupBox GbEndredientesCadastrados
        {
            get { return gbEngredientesCadastrados; }
        }
        public GroupBox GbEndredientesSabor
        {
            get { return gbEngredientesSabor; }
        }
        public Panel PainelStatus
        {
            get { return painelStatus; }
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
            txtBuscaEngredientesCadastrados.TextChanged += e;
        }
        public void EventoBuscaEngredienteSabor(EventHandler e)
        {
            txtBuscaEngredientesVinculados.TextChanged += e;
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
            dgvEngredientesCadastrado.DataSource = null;

            dgvEngredientesCadastrado.DataSource = Lista;
            dgvEngredientesCadastrado.Columns["Id"].Visible = false;
            dgvEngredientesCadastrado.Columns["Ativo"].Visible = false;
        }
        public void PopularGridEngredientesSabor(List<EngredienteModel> Lista)
        {
            dgvEngredientesSabor.DataSource = null;

            if (Lista != null)
            {
                dgvEngredientesSabor.DataSource = Lista;
                dgvEngredientesSabor.Columns["Id"].Visible = false;
                dgvEngredientesSabor.Columns["Ativo"].Visible = false;
            }
        }
    }
}
