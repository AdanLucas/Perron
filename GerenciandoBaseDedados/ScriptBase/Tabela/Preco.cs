namespace Repository.ScriptBase.Tabela
{
    public class Preco : IScriptTabela
    {
        public string GUID => "55C0FEBE-1F7B-4CA4-9EC3-7CE9A91FB8D8";

        public string NomeTabela => "Preco";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[Preco](
                        	[Id] [int] IDENTITY(1,1) NOT NULL,
                        	[IDTamanho] [int] NULL,
                        	[Preco] [decimal](6, 2) NULL,
                        	[Ativo] [bit] NULL,
                              CONSTRAINT [PK_Preco] PRIMARY KEY CLUSTERED 
                             (
                             	[Id] ASC
                             )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                             ) ON [PRIMARY]";
            }
        }
    }
}
