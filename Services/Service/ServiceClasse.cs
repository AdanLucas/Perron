using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceClasse : IServiceClasse
    {

        private readonly IRepositoryClasse _repository;

        public ServiceClasse(IRepositoryClasse repo)
        {
            _repository = repo;
        }

        public ClasseModel GetClasseporId(int Id)
        {
            return _repository.GetItemPorID(Id);
        }

        public List<ClasseModel> GetlistaClasse(EStatusCadastro statusCadastro)
        {
            var Lista = _repository.GetLista(EStatusCadastro.Todos);

            switch (statusCadastro)
            {
                case EStatusCadastro.none:
                    return null; 

                case EStatusCadastro.Todos:
                    return Lista;

                    
                case EStatusCadastro.Ativo:
                    return Lista.Where(l => l.Ativo == true).ToList();

                    
                case EStatusCadastro.Inativo:
                    return Lista.Where(l => l.Ativo == false).ToList();
            }

            return null;

        }

        public void Salvar(ClasseModel classe)
        {
            try
            {
                _repository.Salvar(classe);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
