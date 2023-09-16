using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    class ServiceSabor : IServiceSabor
    {

        private readonly IRepositorySabor _repo;


        public ServiceSabor(IRepositorySabor repo)
        {
            _repo = repo;
        }

        public List<SaborModel> GetListaSabor(EStatusCadastro status)
        {
            var Lista = _repo.GetLista(EStatusCadastro.Todos);

            switch (status)
            {
                case EStatusCadastro.none:
                    return null;

                case EStatusCadastro.Todos:
                    return Lista;

                case EStatusCadastro.Ativo:
                    return Lista.Where(R => R.Ativo == true).ToList();

                case EStatusCadastro.Inativo:
                    return Lista.Where(R => R.Ativo == false).ToList();

                default:
                    throw new Exception("Status Não Encontrado");
            }

        }

        public SaborModel GetporID(int Id)
        {
            return _repo.GetItemPorID(Id);
        }

        public void Salvar(SaborModel sabor)
        {
            try
            {
                _repo.Salvar(sabor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
