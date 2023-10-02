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

        public List<PessoaModel> IniciarCachePessoa()
        {
            using (DbSession session = new DbSession())
            {
                var repositorioPessoa = FactoryRepository.TipoPessoa(Model.Emumerator.ETipoPessoa.Pessoa);
                return repositorioPessoa.GetLista<PessoaModel>();
            }
        }

    }
}
