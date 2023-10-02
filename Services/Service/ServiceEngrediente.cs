using System;
using System.Collections.Generic;

namespace Services.Service
{
    public class ServiceEngrediente : IServiceIngrediente
    {
        private readonly IRepositoryEngrediente _repositorio;




        public ServiceEngrediente(IRepositoryEngrediente repositorio)
        {
            _repositorio = repositorio;
        }

        public List<IngredienteModel> GetListaEngredientesCadastroados()
        {
            return _repositorio.GetLista(EStatusCadastro.Todos);
        }
        public void Salvar(IngredienteModel Engrediente)
        {
            try
            {
                _repositorio.Salvar(Engrediente);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SalvarLista(List<IngredienteModel> ListaEngrediente)
        {
            throw new NotSupportedException();
        }
    }
}
