namespace Repository.ScriptBase.Tabela
{
    internal class DadosMercadoriaProduto : IScriptTabela
    {
        public string GUID => "BC85D9F9-152B-43FE-AEDB-F07987B6F6B6";

        public string NomeTabela => "DadosMercadoriaProduto";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                        (
    						[IdProdutoMercadoria] [int] NULL,
    						[Tamanho] [int] NULL,
    						[Quantidade] [decimal](6, 2) NULL
    					) ON [PRIMARY]"
                 ;
            }
        }
    }
}
