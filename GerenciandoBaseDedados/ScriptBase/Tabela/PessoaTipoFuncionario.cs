namespace Repository.ScriptBase.Tabela
{
    internal class PessoaTipoFuncionario : IScriptTabela
    {
        public string GUID => "FD5A089C-6E62-4E22-9F27-42C2C5C0DF07";
        public string NomeTabela => "PessoaTipoFuncionario";
        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                                   (
                                	[ID] [int] IDENTITY(1,1) NOT NULL,
                                	[Nome] [varchar](250) NULL,
                                	[Sobrenome] [varchar](250) NULL,
                                	[Tipo] [int] NULL,
                                    [CpfCnpj] [varchar](20) NULL,
                                	[Telefone] [varchar](15) NULL,
                                	[Ativo] [bit] NULL,
                                        CONSTRAINT [PK_Pessoas] PRIMARY KEY CLUSTERED ( [ID] ASC ) 
                                        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                        ) ON [PRIMARY]";
            }
        }
    }
}
