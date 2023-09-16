using System;
using System.Collections.Generic;


public interface IViewClasse : IViewPadraoCadastro
{



    string DescricaoClasse { get; set; }
    void PopularGridClasse(List<ClasseModel> Lista);
    ClasseModel ClasseSelecionadaGrid { get; }
    bool VisibilidadeGroupBoxClassesCadastrados { set; }

    void EventoGrid(EventHandler e);

}

