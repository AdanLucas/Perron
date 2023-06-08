using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Tabela
{
    public class Sabor : IScriptTabela
    {
        public string GUID => "55C0FEBE-1F7B-4CA4-9EC3-7CE9A91FB8D8";

        public string NomeTabela => "Sabor";

        public string Script 
        { 
            get
            { 
                return $@"CREATE TABLE [dbo].[{NomeTabela}](
    						[Id] [int] IDENTITY(1,1) NOT NULL,
    						[Descricao] [varchar](50) NULL,
    						[IdClasse] [int] NULL,
    						[Ativo] [bit] NULL,
    					 CONSTRAINT [PK_Sabor] PRIMARY KEY CLUSTERED 
    					(
    						[Id] ASC
    					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					) ON [PRIMARY]";
            } 
        }
    }
}
