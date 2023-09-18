using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciandoBaseDedados.ScriptBase.Tabela
{
    internal class Empresa : IScriptTabela
    {
        public string GUID => "5718D4D6-02B4-4838-8D6D-4072ED1D8B08";

        public string NomeTabela => "Empresa";

        public string Script => $@"CREATE TABLE [dbo].[{NomeTabela}](
    						[Id] [int] NOT NULL,
    						[Ativo] [bit] NULL,
    					         CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
    					        (
    					        	[Id] ASC
    					        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					        ) ON [PRIMARY]";
    }
}
