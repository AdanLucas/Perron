using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.Tabela
{
    public class Cliente : IScriptTabela
    {
        public string GUID => throw new NotImplementedException();

        public string NomeTabela => "Cliente";

        public string Script =>$@"CREATE TABLE [dbo].[{NomeTabela}](
    						[Id] [int] NOT NULL,
    						[Ativo] [bit] NULL,
    					         CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
    					        (
    					        	[Id] ASC
    					        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					        ) ON [PRIMARY]";
    }
}
