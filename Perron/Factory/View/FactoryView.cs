using Perron.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class FactoryView
{
    
        
    public static IViewPrincipal Principal()
    {
        return new FrmPrincipal();
    }
    public static IViewCadastroIngrediente CadastroIngrediente(IViewPrincipal view)
    {
        var viewIngrediente =  new FrmCadastroIngrediente();

        viewIngrediente.MdiParent = (FrmPrincipal)view;


        return viewIngrediente;
    }


}

