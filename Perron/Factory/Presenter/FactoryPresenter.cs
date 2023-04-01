
using Perron.Controller;
using Perron.Factory.Controller;
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

        return new PresenterIngrediente(view);

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

}

