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
    public partial class FrmCadastroSabor : FrmPadraoCadastro, IViewCadastroSabor
    {
        public FrmCadastroSabor()
        {
            InitializeComponent();
        }


        public string DescricaoSabor
        {
            get { return txtDescricaoSabor.Text; }
            set { txtDescricaoSabor.Text = value; }

        }
        public Panel PainelEngredienteSabor
        {
            get { return painelEngredienteSabor; }
        }
        public string DescricaoClasse
        {
            set { txtClasse.Text = value; }
        }
        public void EventoBuscarClasse(EventHandler e)
        {
            btnBuscarClasse.Click += e;
        }
        public bool VisibilidadeBotao
        {
            set { btnBuscarClasse.Visible = value; }
        }
        public SaborModel ItemSelecionadoGrid
        {
            get
            {
                try
                {
                    return (SaborModel)dgvSaboresCadastrados.CurrentRow.DataBoundItem;
                }
                catch
                {

                    return null;
                }
            }
        
        }
        public void EventoGrid(EventHandler e)
        {
            dgvSaboresCadastrados.DoubleClick += e;
        }

        public void PopularGrid(List<SaborModel> Lista)
        {
            dgvSaboresCadastrados.DataSource = null;

            if(Lista != null)
            {
                dgvSaboresCadastrados.DataSource = Lista;
                dgvSaboresCadastrados.Columns["Id"].Visible = false;
                dgvSaboresCadastrados.Columns["Ativo"].Visible = false;
                dgvSaboresCadastrados.Columns["Classe"].Visible = false;
            }

         
        }
    }
}
