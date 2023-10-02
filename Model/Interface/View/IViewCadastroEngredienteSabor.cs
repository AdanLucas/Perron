using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IViewCadastroEngredienteSabor
{
    #region Campos de Busca
    string BuscarEngredientesCadastrados { get; }
    string BuscarEngredientesSabor { get; }
    Panel PainelStatus { get; }
    #endregion

    #region Eventos
    void EventoGridEngredientesCadastrados(EventHandler e);
    void EventoGridEngredientesSabor(EventHandler e);
    void EventoBuscaEngredienteCadastrados(EventHandler e);
    void EventoBuscaEngredienteSabor(EventHandler e);

    #endregion

    GroupBox GbEndredientesCadastrados { get; }
    GroupBox GbEndredientesSabor { get; }

    #region Grid

    void PopularGridEngredientesCadastrados(List<IngredienteModel> Lista);
    void PopularGridEngredientesSabor(List<IngredienteModel> Lista);

    IngredienteModel EngredienteSelecionadoGridEngredienteCadastrado { get; }
    IngredienteModel EngredienteSelecionadoGridEngredienteSabor { get; }

    #endregion

}

