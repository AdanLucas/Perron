using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extension
{
    public static class ExtensionXml
    {
        public static void SetarPropriedades(this  ArqConfiguracao arquivo)
        {
            arquivo.ConexaoBancoDados = new ConfiguracaoConexaoBancoDados();
            arquivo.API = new ConfiguracaoAPI();
            arquivo.ConexaoBancoDados.LocalDb = true;
            arquivo.ConexaoBancoDados.Banco = "Perron";
            arquivo.ConexaoBancoDados.Instancia = @"(localdb)\MSSQLLocalDB";
            arquivo.ConexaoBancoDados.Usuario = "sa";
            arquivo.ConexaoBancoDados.Senha = @"kb74Uwfcq/DRfmAGZd8pkghc52rMpXAGBZXVQOr4pkpIpsK5nt6pDCJE+EF+47wZY8aX87eqCtt/F9vjKBHMNk8jJ/2oVXOtGBcUEMn9cb1txI0Fiv7N+LFzgcfWGJuW";
            arquivo.API.Porta = 50000;
            arquivo.API.Ip = "127.0.0.1";
        }

        public static string PegarNomeArquivo( this ArqConfiguracao arquivo)
        {
            return "Configuracao.xml";
        }

    }
}
