using System.Collections.Generic;



public interface IRepositoryMercadoria : IRepositoryBase<MercadoriaModel>
{
    
    List<MercadoriaModel> GetListaMercadoriaPorProduto(int IdProduto);

}

