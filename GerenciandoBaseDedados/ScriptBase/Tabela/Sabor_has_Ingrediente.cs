namespace Repository.ScriptBase.Tabela
{
    public class Sabor_has_Ingrediente : IScriptTabela
    {
        public string GUID => "75CE3482-A0E0-40E0-9CC8-4827D0068E07";

        public string NomeTabela => "Sabor_has_Ingrediente";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                        (
    						[Id] [int] IDENTITY(1,1) NOT NULL,
    						[Sabor] [int] NULL,
    						[Ingrediente] [int] NULL,
    						[Ativo] [bit] NULL,
    					 CONSTRAINT [PK_Sabor_has_Ingrediente] PRIMARY KEY CLUSTERED 
    					(
    						[Id] ASC
    					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    					) ON [PRIMARY]";
            }
        }

    }
}
