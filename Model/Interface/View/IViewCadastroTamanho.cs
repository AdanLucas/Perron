using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IViewCadastroTamanho : IViewPadraoCadastro
{


    #region Propriedades
    int Quantidade { get; set; }
    string DescricaoTamanho { get; set; }
     ComboBox ComboTIpoQuantidade { get; }
    DataGridView GridTamanho { get; }
    #endregion

    #region Grid
    void EventoGrid(EventHandler e);
    TamanhoModel ItemSelecionadoGrid { get; }
    void PopularGrid(List<TamanhoModel> Lista);
    #endregion


}

