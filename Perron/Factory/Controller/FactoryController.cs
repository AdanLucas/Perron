
using Perron.Controller;
using Perron.Factory.Controller;


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

        return new ControllerIngrediente(view);

    }

}

