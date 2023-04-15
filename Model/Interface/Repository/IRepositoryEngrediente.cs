using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public interface IRepositoryEngrediente
{
    void SalvarEngrediente(EngredienteModel Engrediente);
    
    EngredienteModel GetEngredientePorId(int Id);
    List<EngredienteDTO> GetListaEngredienteDTO();
    List<EngredienteModel> GetListaEngrediente(EStatusCadastro statusCadastro);
    List<EngredienteModel> GetListaEngredientePorSabor(int IDSabor);

}

