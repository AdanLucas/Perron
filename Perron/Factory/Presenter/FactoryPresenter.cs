
using Perron.Controller;
using Perron.Factory.Controller;
using Perron.Presenter;
using System.Windows.Forms;

public static class FactoryPresenter
{
    public static IPresenterPrincipal Principal()
    {
        var view = FactoryView.Principal();
        return new ControllerPrincipal(view);
    }
    public static IPresenterEngrediente CadastroIngredientes(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroIngrediente(viewPai);
        var servico = FactoryService.Engrediente();


        return new PresenterIngrediente(view, servico);

    }
    public static IPresenterEngredienteSabor  EngredienteSabor(Panel painel)
    {
        var view = FactoryView.CadastroEngredienteSabor(painel);

        return new PresenterEngredienteSabor(view);

    }
    public static IPresenterSabor CadastroSabor(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroSabor(viewPai);

        return new PresenterSabor(view);

    }
    public static IPresenterClasse Classe(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroClasse(viewPai);
        var service = FactoryService.Classe();
        return new PresenterClasse(view, service);
    }

}

