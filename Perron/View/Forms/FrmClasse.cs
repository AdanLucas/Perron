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
    public partial class FrmClasse : FrmPadraoCadastro, IViewClasse
    {
        public FrmClasse()
        {
            InitializeComponent();
        }

        public string DescricaoClasse
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }
        }

        public ClasseModel ClasseSelecionadaGrid
        {
            get
            {
                try
                {
                    return (ClasseModel)dgvClasse.CurrentRow.DataBoundItem;
                }
                catch  
                {

                    return null;
                }
            }
        
        }

        public void EventoGrid(EventHandler e)
        {
            dgvClasse.DoubleClick += e;
        }

        public void PopularGridClasse(List<ClasseModel> Lista)
        {
            dgvClasse.DataSourceAentity(Lista);
        }

    }
}
