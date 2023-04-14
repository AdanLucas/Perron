using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IViewClasse : IViewPadraoCadastro
{

    void Show();
    void Close();

    string DescricaoClasse { get; set; }
    void PopularGridClasse(List<ClasseModel> Lista);
    ClasseModel ClasseSelecionadaGrid { get; }
    void EventoGrid(EventHandler e);

}

