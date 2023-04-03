using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IRepositorySabor
{
    void SalvarSabor(SaborModel sabor);
    SaborModel GetSaborPorId(int Id);
    List<SaborModel> GetListaSabor(EStatusCadastro statusCadastro);

}

