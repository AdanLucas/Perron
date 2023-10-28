using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Componentes
{
    

    public partial class DadosMercadoriaComponente : UserControl
    {
        private IngredienteModel ingrediente { get; set; }
        
        public Action AtualiarTela { get; set; }
        public IngredienteModel Ingrediente { get; set; }
        public EventHandler EventoAdicionarDadosIngrediente { get; set; }
        public EventHandler EventoRemoverIngrediente { get; set; }



        public DadosMercadoriaComponente(IngredienteModel ingrediente)
        {
            InitializeComponent();
            Ingrediente = ingrediente;
        }

        private void DadosMercadoriaComponente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('a') && EventoAdicionarDadosIngrediente != null)
                        EventoAdicionarDadosIngrediente(Ingrediente,EventArgs.Empty);
        }
        private void DadosMercadoriaComponente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete) && EventoRemoverIngrediente != null)
                EventoRemoverIngrediente(this, EventArgs.Empty);

        }
    }
}
