using System.Collections.Generic;


public interface IRepositoryBase<T>
{
    void Salvar(T Item);
    List<T> GetLista(EStatusCadastro status);
    T GetItemPorID(int Id);
}
