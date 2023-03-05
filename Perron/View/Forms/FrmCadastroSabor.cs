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
        public int IdClasse 
        {
            get
            {
                try
                {
                    return (int)comboClasse.SelectedValue;
                }
                catch
                {

                    return 0;
                }    

            }
            set { }
        }

        public Panel PainelEngredienteSabor
        {
            get { return painelEngredienteSabor;}
        }

        public void PopularComboClasse(List<ClasseModel> ListaClasse)
        {
            comboClasse.ConfigurarDadosComboBox<ClasseModel>(ListaClasse);
        }
    }
}
