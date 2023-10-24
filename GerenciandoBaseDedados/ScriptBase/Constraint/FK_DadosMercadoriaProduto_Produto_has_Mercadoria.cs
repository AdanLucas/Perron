namespace Repository.ScriptBase.Constraint
{
    public class FK_DadosMercadoriaProduto_Produto_has_Mercadoria : IScriptConstraint
    {
        public string NomeConstraint => "FK_DadosMercadoriaProduto_Produto_has_Mercadoria";

        public string Script => $@"	ALTER TABLE [dbo].[DadosMercadoriaProduto]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdProdutoMercadoria])
    					REFERENCES [dbo].[Produto_has_Mercadoria] ([Id])
    					
    					ALTER TABLE [dbo].[DadosMercadoriaProduto] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
