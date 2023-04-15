using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IServiceTamanho
    {
        void Salvar(TamanhoModel tamanho);

        List<TamanhoModel> GetListaTamanho(EStatusCadastro status);

    }

