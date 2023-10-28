
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
    public static IPresenterMercadoriaProduto MercadoriaProduto(params object[] paramentro)
    {
        PresenterProduto presenterProduto = paramentro[0] as PresenterProduto;
        return new ControllerMercadoriaProduto(presenterProduto);

    }
    public static IPresenterProduto CadastroProduto(IViewPrincipal viewPai)
    {
        var view = FactoryView.CadastroProduto(viewPai);
        var serivce = FactoryService.Produto();

        return new PresenterProduto(view, serivce);

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

