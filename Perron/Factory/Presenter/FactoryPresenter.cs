
using Model.Emumerator;
using Perron.Controller;
using Perron.Factory.Controller;
using Perron.Presenter;
using Perron.Presenter.Cadastro;
using System.Windows.Forms;

public static class FactoryPresenter
{
    public static IPresenterPrincipal Principal()
    {
        var view = FactoryView.Principal();
        return new ControllerPrincipal(view);
    }
    public static IPresenterMercadoria CadastroMercadoria(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroMercadoria(viewPai);
        var servico = FactoryService.Mercadoria();


        return new PresenterMercadoria(view, servico);

    }
    public static IPresenterIngredienteSabor EngredienteSabor(params object[] paramentro)
    {
        PresenterSabor presenterSabor = paramentro[0] as PresenterSabor;
        return new PresenterIngredienteSabor(presenterSabor);

    }
    public static IPresenterSabor CadastroSabor(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroSabor(viewPai);
        var serivce = FactoryService.Sabor();

        return new PresenterSabor(view, serivce);

    }
    public static IPresenterClasse Classe(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroClasse(viewPai);
        var service = FactoryService.Classe();
        return new PresenterClasse(view, service);
    }
    public static IPresenterCadastroTamanho CadastroTamanho(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroTamanho(viewPai);
        var service = FactoryService.Tamanho();
        return new PresenterCadastroTamanho(view, service);
    }
    public static IPresenterCadastroPreco CadastroPreco(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroPreco(viewPai);
        var service = FactoryService.CadastroPreco();

        return new PresenterCadastroPreco(view, service);
    }
    public static IPresenterCadastroPessoa CadastroPessoa(Form viewPai, ETipoPessoa tipo)
    {
        var _serivce = FactoryService.CadastroTipoPessoa(ETipoPessoa.Pessoa);
        var view = FactoryView.CadastroPessoa(viewPai);
        return new PresenterCadastroPessoa(view, _serivce, tipo);
    }




}

