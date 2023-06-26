using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ScriptBase.Tabela
{
    internal class Endereco : IScriptTabela
    {
        public string GUID => "FD5A089C-6E62-4E22-9F27-42C2C5C0DF07";

        public string NomeTabela => "Endereco";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                                (
                            	[Id] [int] IDENTITY(1,1) NOT NULL,
                            	[IdPessoa] [int] NULL,
                            	[Descricao] [varchar](300) NULL,
                            	[Rua] [varchar](300) NULL,
                            	[Numero] [varchar](10) NULL,
                            	[Bairro] [varchar](250) NULL,
                            	[Complemento] [varchar](250) NULL,
                            	[Ativo] [bit] NULL,
                                             CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED ([Id] ASC) 
                                              WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                    ) ON [PRIMARY]";
            }
        }
    }
}
