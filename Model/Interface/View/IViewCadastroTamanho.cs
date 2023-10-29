using System;
using System.Collections.Generic;


public interface IViewCadastroTamanho : IViewPadraoCadastro
{


    #region Propriedades
    int Quantidade { get; set; }
    string DescricaoTamanho { get; set; }
    #endregion

    #region Grid
    void EventoGrid(EventHandler e);
    TamanhoModel ItemSelecionadoGrid { get; }
    void PopularGrid(List<TamanhoModel> Lista);
    #endregion


}

