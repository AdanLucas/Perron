using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IServiceTipoPessoa
    {
        IList GetListaCadastro(EStatusCadastro status);
        object GetCadastroPorId(int id);
        int Salvar(object cadastro);
        Task SalvarLista(IList list);
    }


