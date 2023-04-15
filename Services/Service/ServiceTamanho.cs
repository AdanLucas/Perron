using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
   public class ServiceTamanho : IServiceTamanho
    {
        private readonly IRepositoryTamanho _repo; 

        
        public ServiceTamanho(IRepositoryTamanho repo)
        {
            _repo = repo;
        }



        public List<TamanhoModel> GetListaTamanho(EStatusCadastro status)
        {
            var lista = _repo.GetListaTamanho();

            switch (status)
            {
                case EStatusCadastro.none:
                    return null;
                case EStatusCadastro.Todos:
                    return lista;
                case EStatusCadastro.Ativo:
                    return lista.Where(lst => lst.Ativo == true).ToList();
                case EStatusCadastro.Inativo:
                    return lista.Where(lst => lst.Ativo == false).ToList();

            }

            return null;

        }

        public void Salvar(TamanhoModel tamanho)
        {
            _repo.SalvarTamanho(tamanho);
        }
    }
}
