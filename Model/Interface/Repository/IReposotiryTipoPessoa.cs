using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public interface IReposotiryTipoPessoa
    {
        int Salvar(object cadastro);
        void SalvarLista(IList lista);
        object GetCadastroPorId(int Id);
        IList GetLista();

    }

