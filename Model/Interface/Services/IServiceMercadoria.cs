using System.Collections.Generic;


public interface IServiceMercadoria
{
    List<MercadoriaModel> GetListaMercadoriaCadastrados();
    void Salvar(MercadoriaModel Mercadoria);
    void SalvarLista(List<MercadoriaModel> ListaMercadoria);

}

