using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IViewCadastroProduto : IViewPadraoCadastro
{

    string DescricaoProduto { get; set; }
    string DescricaoClasse { set; }
     TabControl TabControl { get; }
    bool VisibilidadeBotao { set; }
    void EventoBuscarClasse(EventHandler e);
    void EventoGrid(EventHandler e);
    ProdutoModel ItemSelecionadoGrid { get; }
    void PopularGrid(List<ProdutoModel> Lista);
    KeyPressEventHandler EventoTeclaPressionada { get; set; }

}

