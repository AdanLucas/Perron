using System.Collections.Generic;

public interface IRepositoryDadosEngredienteSabor : IRepositoryBase<DadosSaborEngredienteModel>
{
    List<DadosSaborEngredienteModel> GetListaDadosPorSabor(int IdSabor);

}

