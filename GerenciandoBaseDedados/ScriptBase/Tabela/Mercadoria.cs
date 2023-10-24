namespace Repository.ScriptBase.Tabela
{
    public class Mercadoria : IScriptTabela
    {
        public string GUID => "E57CDCAE-A9FB-41D3-97D1-89C7450A288E";

        public string NomeTabela => "Mercadoria";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                        (
    						[Id] [int] IDENTITY(1,1) NOT NULL,
    						[Descricao] [varchar](50) NULL,
                            [TipoMercadoria] [int] NULL,
                            [TipoMedida] [int] NULL,
    						[Ativo] [bit] NULL,
    					 CONSTRAINT [PK_Mercadoria] PRIMARY KEY CLUSTERED 
    					(
    						[Id] ASC
    					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					) ON [PRIMARY]";

            }
        }
    }
}
