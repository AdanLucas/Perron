using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IRepositoryVerificacaoBancoDedados
    {
        bool validarExistenciaBancodeDadosConfigurado();
        bool ValidarConexaoComAInstancia();
        List<string> GetListaBancoInstancia();
        void CriarBaseDeDadosDefaut();

    }

