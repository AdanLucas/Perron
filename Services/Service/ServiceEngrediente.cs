using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ServiceEngrediente : IServiceIngrediente
    {
        private readonly IRepositoryEngrediente _repositorio;




        public ServiceEngrediente(IRepositoryEngrediente repositorio)
        {
            _repositorio = repositorio;
        }

        public List<EngredienteModel> GetListaEngredientesCadastroados()
        {
            return _repositorio.GetLista(EStatusCadastro.Todos);
        }
        public void Salvar(EngredienteModel Engrediente)
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
        public void SalvarLista(List<EngredienteModel> ListaEngrediente)
        {
            throw new NotSupportedException();
        }
    }
}
