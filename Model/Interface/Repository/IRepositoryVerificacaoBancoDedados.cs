using System.Collections.Generic;


public interface IRepositoryVerificacaoBancoDedados
{
    bool validarExistenciaBancodeDadosConfigurado();
    bool ValidarConexaoComAInstancia();
    List<string> GetListaBancoInstancia();
    void CriarBaseDeDadosDefaut();

}

