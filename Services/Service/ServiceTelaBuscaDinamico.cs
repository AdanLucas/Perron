using Model.Interface.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceTelaBuscaDinamico
    {
        

        private readonly IRepositoryBuscaDinamico _repo;

        public ServiceTelaBuscaDinamico(Type tipo)
        {
            _repo = FactoryRepository.BuscaDinamico(tipo);
        }

        public IList ObterTodos()
        {
            return _repo.ObterTodos() as IList;
        }
        public object ObterPoId(int id) 
        { 
           return _repo.ObterPorId(id);
        }

    }
}
