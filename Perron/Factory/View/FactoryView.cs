using Model.Interface.View;
using Perron;
using Perron.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class FactoryView
{

    private static void SetarMidParentTelaPrincial(Form telaFilho, IViewPrincipal TelaPai)
    {
        telaFilho.MdiParent = (FrmPrincipal)TelaPai;

    }
    public static IViewPrincipal Principal()
    {
        return new FrmPrincipal();
    }
    public static IViewCadastroIngrediente CadastroIngrediente(IViewPrincipal viewPrincipal)
    {
        var viewIngrediente = new FrmCadastroIngrediente();

        SetarMidParentTelaPrincial(viewIngrediente, viewPrincipal);

        return viewIngrediente;
    }
    public static IViewCadastroSabor CadastroSabor(IViewPrincipal viewPrincipal)
    {
        var viewCadastroSabor = new FrmCadastroSabor();

        viewCadastroSabor.MdiParent = (FrmPrincipal)viewPrincipal;

        return viewCadastroSabor;


    }
    public static IViewCadastroEngredienteSabor CadastroEngredienteSabor(Panel painel)
    {
        var userControl = new UserControlEngredienteSabor();

        painel.Controls.Add(userControl);

        return userControl;

    }
    public static IViewClasse CadastroClasse(IViewPrincipal viewPrincipal)
    {
        var CadatroClasse = new FrmClasse();

        SetarMidParentTelaPrincial(CadatroClasse, viewPrincipal);

        return CadatroClasse;

    }
    public static IViewCadastroTamanho CadastroTamanho(IViewPrincipal viewPrincipal)
    {
        var view = new FrmCadastroTamanho();

        SetarMidParentTelaPrincial(view, viewPrincipal);

        return view;
    }
    public static IViewCadastroPreco CadastroPreco(IViewPrincipal viewPrincipal)
    {
        var view = new FrmCadastroPreco();
        SetarMidParentTelaPrincial(view, viewPrincipal);

        return view;
    }
}

