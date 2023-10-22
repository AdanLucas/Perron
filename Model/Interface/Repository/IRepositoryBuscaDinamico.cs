using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface.Repository
{
    public interface IRepositoryBuscaDinamico
    {
         Type TipoRepositorio{ get;}

        object ObterPorId(int Id);

        object ObterTodos();

    }
}
