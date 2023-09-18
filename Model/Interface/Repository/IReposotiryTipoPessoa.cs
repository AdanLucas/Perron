
using System.Collections.Generic;

public interface IReposotiryTipoPessoa
{
    int Salvar(object cadastro);
    void SalvarLista(System.Collections.IList lista);
    object GetCadastroPorId(int Id);
    List<T> GetLista<T>();

}

