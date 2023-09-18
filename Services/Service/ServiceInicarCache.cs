using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Xml;

namespace Services.Service
{
    public class ServiceInicarCache : IDisposable
    {
        public void Dispose(){}

        public Task IniciarCachePessoa(List<PessoaModel> pessoa)
        {
           return Task.Run(() =>
           {

               using (DbSession session = new DbSession())
               {
                   var repositorioPessoa = FactoryRepository.TipoPessoa(Model.Emumerator.ETipoPessoa.Pessoa);
                   var resultado = repositorioPessoa.GetLista<PessoaModel>();

                   
               }
           });
        }

    }
}
