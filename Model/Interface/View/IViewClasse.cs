using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IViewClasse : IViewPadraoCadastro
{



    string DescricaoClasse { get; set; }
    void PopularGridClasse(List<ClasseModel> Lista);
    ClasseModel ClasseSelecionadaGrid { get; }
    bool VisibilidadeGroupBoxClassesCadastrados { set; }

    void EventoGrid(EventHandler e);

}

