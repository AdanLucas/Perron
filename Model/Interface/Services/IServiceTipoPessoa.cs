using System.Collections;
using System.Threading.Tasks;


public interface IServiceTipoPessoa
{
    IList GetListaCadastro(EStatusCadastro status);
    object GetCadastroPorId(int id);
    int Salvar(object cadastro);
    Task SalvarLista(IList list);
}


