using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.Tabela
{
    public class Cliente : IScriptTabela
    {
        public string GUID => throw new NotImplementedException();

        public string NomeTabela => "Cliente";

        public string Script =>$@"CREATE TABLE [dbo].[{NomeTabela}]
                            (
    						[Id] [int] NOT NULL,
    						[Ativo] [bit] NULL
                            )";
    }
}
