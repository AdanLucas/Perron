using System.Collections.Generic;



public interface IRepositoryEngrediente : IRepositoryBase<EngredienteModel>
{
    EngredienteModel GetEngredientePorId(int Id);
    List<EngredienteDTO> GetListaEngredienteDTO();
    List<EngredienteModel> GetListaEngredientePorSabor(int IDSabor);

}

