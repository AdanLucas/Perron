namespace Repository.ScriptBase.Tabela
{
    internal class PessoaTipoFornecedor : IScriptTabela
    {
        public string GUID => "FD5A089C-6E62-4E22-9F27-42C2C5C0DF07";
        public string NomeTabela => "PessoaTipoFornecedor";
        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                            (
                             [Id] [int] NOT NULL,
	                         [DataCadastro] [date] NULL,
	                         [TipoVencimento] [int] NULL,
	                         [Ativo] [bit] NULL,
                                 CONSTRAINT [PK_PessoaTipoFornecedor] PRIMARY KEY CLUSTERED 
                                         ( [IDPessoa] ASC )
                                            WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                             )
                                ON [PRIMARY]";
            }
        }
    }
}
