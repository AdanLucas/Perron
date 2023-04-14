using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IRepositoryClasse
{
    void Salvar(ClasseModel classe);

    List<ClasseModel> GetListaClasse();

    ClasseModel GetClassePorId(int Id);


}

