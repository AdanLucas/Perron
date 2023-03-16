using System;
using System.Collections.Generic;


public interface IViewCadastroIngrediente : IViewPadraoCadastro
{
    void Show();
    void Close();

    string DescricaoIngrediente { get; set; }
    void PopularGridIngredientes(List<EngredienteModel> Ingredientes);
    EngredienteModel IngredienteSelecionado { get; }
    void EventoGrid(EventHandler e);



}

