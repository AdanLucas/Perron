using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IRepositoryBase<T>
{
    void Salvar(T Item);
    List<T> GetLista();
    T GetItemPorID(int Id);
}
