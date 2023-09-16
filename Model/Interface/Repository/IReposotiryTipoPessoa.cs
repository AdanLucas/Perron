using System.Collections;

public interface IReposotiryTipoPessoa
{
    int Salvar(object cadastro);
    void SalvarLista(IList lista);
    object GetCadastroPorId(int Id);
    IList GetLista();

}

