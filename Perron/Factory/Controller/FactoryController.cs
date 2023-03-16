
using Perron.Controller;
using Perron.Factory.Controller;
using System.Windows.Forms;

public static class FactoryController
{
    public static IControllerPrincipal Principal()
    {
        var view = FactoryView.Principal();
        return new ControllerPrincipal(view);
    }
    public static IControllerIngrediente CadastroIngredientes(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroIngrediente(viewPai);

        return new PresenterIngrediente(view);

    }
    public static IControllerEngredienteSabor  EngredienteSabor(Panel painel)
    {
        var view = FactoryView.CadastroEngredienteSabor(painel);

        return new PresenterEngredienteSabor(view);

    }
    public static IControllerSabor CadastroSabor(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroSabor(viewPai);

        return new PresenterSabor(view);

    }

}

