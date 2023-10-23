using System.Collections.Generic;



public interface IRepositoryMercadoria : IRepositoryBase<MercadoriaModel>
{
    MercadoriaModel GetMercadoriaPorId(int Id);
    List<MercadoriaModel> GetListaMercadoriaPorSabor(int IDSabor);

}

