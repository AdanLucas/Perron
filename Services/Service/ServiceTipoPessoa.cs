using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceTipoPessoa : IServiceTipoPessoa
    {
        IReposotiryTipoPessoa _repo; 

        public ServiceTipoPessoa(IReposotiryTipoPessoa repo)
        {
            _repo = repo;
        }
        public object GetCadastroPorId(int id)
        {
            return null;
        }

        public IList GetListaCadastro(EStatusCadastro status)
        {
            return null;
        }

        public bool Salvar(object cadastro)
        {
            return false;
        }

        public Task SalvarLista(IList list)
        {

            return null;

        }
    }
}
