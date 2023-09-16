using Model.Interface.View;
using Perron;
using Perron.View.Forms;
using System.Windows.Forms;

public static class FactoryView
{

    private static void SetarMidParentTelaPrincial(Form telaFilho, Form TelaPai)
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

        SetarMidParentTelaPrincial(viewIngrediente, (Form)viewPrincipal);

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

        SetarMidParentTelaPrincial(CadatroClasse, (Form)viewPrincipal);

        return CadatroClasse;

    }
    public static IViewCadastroTamanho CadastroTamanho(IViewPrincipal viewPrincipal)
    {
        var view = new FrmCadastroTamanho();

        SetarMidParentTelaPrincial(view, (Form)viewPrincipal);

        return view;
    }
    public static IViewCadastroPreco CadastroPreco(IViewPrincipal viewPrincipal)
    {
        var view = new FrmCadastroPreco();
        SetarMidParentTelaPrincial(view, (Form)viewPrincipal);

        return view;
    }
    public static IViewCadastroPessoa CadastroPessoa(Form viewPrincipal)
    {
        var view = new FrmPessoa();
        SetarMidParentTelaPrincial(view, viewPrincipal);

        return view;
    }
}

