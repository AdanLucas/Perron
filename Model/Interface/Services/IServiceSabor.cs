using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IServiceSabor
{

    void Salvar(SaborModel sabor);
    List<SaborModel> GetListaSabor(EStatusCadastro status);

    SaborModel GetporID(int Id);

}

