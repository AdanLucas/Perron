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
    public partial class FrmCadastroTamanho : FrmPadraoCadastro, IViewCadastroTamanho
    {
        public FrmCadastroTamanho()
        {
            InitializeComponent();
        }




        public int QuantidadePedaco
        {
            get { return (int)numQnt.Value; }
            set { numQnt.Value = value; }
        }
        public string DescricaoTamanho
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text= value; }
        }
        public TamanhoModel ItemSelecionadoGrid
        {
            get
            {
                try
                {
                    return (TamanhoModel)dgvTamanhos.CurrentRow.DataBoundItem;
                }
                catch
                {

                    return null;
                }    
            }
        }
        public void EventoGrid(EventHandler e)
        {
            dgvTamanhos.DoubleClick += e;
        }
        public void PopularGrid(List<TamanhoModel> Lista)
        {
            dgvTamanhos.DataSourceAentity(Lista);
        }
    }
}
