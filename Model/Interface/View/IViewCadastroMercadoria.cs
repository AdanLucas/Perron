using System;
using System.Collections.Generic;


public interface IViewCadastroMercadoria : IViewPadraoCadastro
{


    string DescricaoMercadoria { get; set; }
    void PopularGridIngredientes(List<MercadoriaModel> Ingredientes);
    MercadoriaModel MercadoriaSelecionado { get; }
    bool VisibilidadeGroupEngredientes { set; }
    EUnidadeMedida TipoMedida { get; set; }
    bool HabilitaComboTipoMedida { set; }

    void EventoGrid(EventHandler e);
    EventHandler EventoBuscar { get; set; }
}

