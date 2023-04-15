using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IViewCadastroTamanho : IViewPadraoCadastro
{
    void Show();
    void Close();

    #region Propriedades
    int QuantidadePedaco { get; set; }
    string DescricaoTamanho { get; set; }
    #endregion

    #region Grid
    void EventoGrid(EventHandler e);
    TamanhoModel ItemSelecionadoGrid { get; }
    void PopularGrid(List<TamanhoModel> Lista);
    #endregion


}

