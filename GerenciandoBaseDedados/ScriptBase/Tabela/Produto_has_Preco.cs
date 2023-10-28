namespace Repository.ScriptBase.Tabela
{
    public class Produto_has_Preco : IScriptTabela
    {
        public string GUID => "77ACC0CB-2E0D-455B-8A59-7ED38D5F741A";

        public string NomeTabela => "Produto_has_Preco";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}](
                                            	[IdProduto] [int] NOT NULL,
                                            	[IdPreco] [int] NOT NULL
                                                ) ON [PRIMARY]";
            }
        }
    }
}
