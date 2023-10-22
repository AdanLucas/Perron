using Model.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface.Repository
{
    public interface IRepositoryBuscaDinamico
    {
         Type TipoRepositorio{ get;}
        EntidadeBuscaModel ObterPorId(int Id);

        List<EntidadeBuscaModel> ObterTodos();

    }
}
