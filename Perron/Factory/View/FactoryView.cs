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
    public static IViewCadastroMercadoria CadastroMercadoria(IViewPrincipal viewPrincipal)
    {
        var viewIngrediente = new FrmCadastroMercadoria();

        SetarMidParentTelaPrincial(viewIngrediente, (Form)viewPrincipal);

        return viewIngrediente;
    }
    public static IViewCadastroProduto CadastroProduto(IViewPrincipal viewPrincipal)
    {
        var viewCadastroProduto = new FrmCadastroProduto();

        viewCadastroProduto.MdiParent = (FrmPrincipal)viewPrincipal;

        return viewCadastroProduto;


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

