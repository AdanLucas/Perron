using System;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IViewCadastroMercadoria : IViewPadraoCadastro
{


    
    void PopularGridIngredientes(List<MercadoriaModel> Ingredientes);
    MercadoriaModel MercadoriaSelecionado { get; }
    TextBox TxtDescricao { get; }

    ComboBox SelecaoTipoMedida { get; }
    ComboBox SelecaoTipoMercadoria { get; }

    void EventoGrid(EventHandler e);
    EventHandler EventoBuscar { get; set; }
}

