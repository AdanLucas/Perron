using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IRepositoryPreco
    {
          void SalvarListaPreco(List<PrecoModel> Lista);
          void SalvarPreco(PrecoModel preco);
            List<PrecoModel> GetListaPrecoPorClasse(int IDClasse);
            List<PrecoModel> GetListaPreco(EStatusCadastro status);
    }

