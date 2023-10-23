using System;
using System.Collections.Generic;

namespace Services.Service
{
    public class ServiceMercadoria : IServiceMercadoria
    {
        private readonly IRepositoryMercadoria _repositorio;




        public ServiceMercadoria(IRepositoryMercadoria repositorio)
        {
            _repositorio = repositorio;
        }

        public List<MercadoriaModel> GetListaMercadoriaCadastrados()
        {
            return _repositorio.GetLista(EStatusCadastro.Todos);
        }
        public void Salvar(MercadoriaModel mercadoria)
        {
            try
            {
                _repositorio.Salvar(mercadoria);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SalvarLista(List<MercadoriaModel> ListaMercadoria)
        {
            throw new NotSupportedException();
        }
    }
}
