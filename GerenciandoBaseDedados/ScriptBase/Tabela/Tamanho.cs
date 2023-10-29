namespace Repository.ScriptBase.Tabela
{
    public class Tamanho : IScriptTabela
    {
        public string GUID => "77ACC0CB-2E0D-455B-8A59-7ED38D5F741A";

        public string NomeTabela => "Tamanho";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}](
    						[Id] [int] IDENTITY(1,1) NOT NULL,
    						[Descricao] [varchar](50) NULL,
    						[Quantidade] [int] NULL,
                            [UnidadeMedidaQuantidade] [int] NULL,
    						[Ativo] [bit] NULL,
    					 CONSTRAINT [PK_Tamanho] PRIMARY KEY CLUSTERED 
    					(
    						[Id] ASC
    					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					) ON [PRIMARY]";
            }
        }
    }
}
