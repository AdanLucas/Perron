using System.Collections.Generic;



public interface IRepositoryEngrediente : IRepositoryBase<IngredienteModel>
{
    IngredienteModel GetEngredientePorId(int Id);
    List<EngredienteDTO> GetListaEngredienteDTO();
    List<IngredienteModel> GetListaEngredientePorSabor(int IDSabor);

}

