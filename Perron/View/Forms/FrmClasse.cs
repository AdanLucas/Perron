using Perron.View.Forms.Form_Padrao_Cadastro;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Perron.View.Forms
{
    public partial class FrmClasse : FrmPadraoCadastro, IViewClasse
    {

        protected override Size TamanhoTelaCheia { get { return new Size() { Width = 317, Height = 387 }; } }

        protected override Size TamanhoTelaReduzida { get { return new Size() { Width = 317, Height = 167 }; } }


        public FrmClasse()
        {
            InitializeComponent();


        }

        public string DescricaoClasse
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }
        }
        public bool VisibilidadeGroupBoxClassesCadastrados { set { gbClassesCadastradas.Visible = value; } }
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
            dgvClasse.DataSourceCuston(Lista);
        }

    }
}
