using Model.Emumerator;
using System;
using static System.Windows.Forms.Control;

public interface IControllerTipoPessoa
{
    ETipoPessoa TipoController { get; set; }
    void AlterarComportamentoCadastro(EComportamentoTela comportamento);
    void Iniciar(ControlCollection local);
    Func<PessoaModel> GetDadosPessoa { get; set; }
    void RemoverTipoCadastro();
    void Salvar();


}

