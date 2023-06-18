using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IServiceCadastroPreco
{
    List<TamanhoModel> GetTamanhos();
    List<ClasseModel> GetClasses();
    List<PrecoModel> GetPrecoPorClasse(int IdClasse);
    void SalvarListaPrecos(List<PrecoModel> ListaPreco);
}

