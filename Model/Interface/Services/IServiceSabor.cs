using System.Collections.Generic;


public interface IServiceSabor
{

    void Salvar(SaborModel sabor);
    List<SaborModel> GetListaSabor(EStatusCadastro status);

    SaborModel GetporID(int Id);

}

