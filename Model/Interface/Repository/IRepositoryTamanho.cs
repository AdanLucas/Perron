using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IRepositoryTamanho
{
      void SalvarTamanho(TamanhoModel tamanho);
      TamanhoModel GetTamanhoPorId(int id);
      List<TamanhoModel> GetListaTamanho(EStatusCadastro status);
}

