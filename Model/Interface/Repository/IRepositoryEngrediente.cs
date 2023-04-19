using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public interface IRepositoryEngrediente: IRepositoryBase<EngredienteModel>
{
    EngredienteModel GetEngredientePorId(int Id);
    List<EngredienteDTO> GetListaEngredienteDTO();
    List<EngredienteModel> GetListaEngredientePorSabor(int IDSabor);

}

