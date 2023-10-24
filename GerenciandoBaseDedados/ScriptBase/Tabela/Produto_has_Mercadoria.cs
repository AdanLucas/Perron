namespace Repository.ScriptBase.Tabela
{
    public class Produto_has_Mercadoria : IScriptTabela
    {
        public string GUID => "75CE3482-A0E0-40E0-9CC8-4827D0068E07";

        public string NomeTabela => "Produto_has_Mercadoria";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                        (
    						[Id] [int] IDENTITY(1,1) NOT NULL,
    						[Produto] [int] NULL,
    						[Mercadoria] [int] NULL,
    						[Ativo] [bit] NULL,
    					 CONSTRAINT [PK_Produto_has_Mercadoria] PRIMARY KEY CLUSTERED 
    					(
    						[Id] ASC
    					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					) ON [PRIMARY]";
            }
        }

    }
}
