using System;
using System.Collections.Generic;


public interface IViewCadastroIngrediente : IViewPadraoCadastro
{


    string DescricaoIngrediente { get; set; }
    void PopularGridIngredientes(List<IngredienteModel> Ingredientes);
    IngredienteModel IngredienteSelecionado { get; }
    bool VisibilidadeGroupEngredientes { set; }
    EUnidadeMedida TipoMedida { get; set; }
    bool HabilitaComboTipoMedida { set; }

    void EventoGrid(EventHandler e);
    EventHandler EventoBuscar { get; set; }
}

