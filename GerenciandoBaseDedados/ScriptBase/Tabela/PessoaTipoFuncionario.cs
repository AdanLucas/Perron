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
                                	[Id] [int] NOT NULL,
                                	[DataAdimissao] [datetime] NULL,
                                	[Salario] [decimal](18, 0) NULL,
                                	[Ativo] [bit] NULL
                                                    ) ON [PRIMARY]";
            }
        }
    }
}
