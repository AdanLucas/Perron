namespace Repository.ScriptBase.Constraint
{
    public class FK_Produto_has_Preco_Produto : IScriptConstraint
    {
        public string NomeConstraint => "FK_Produto_has_Preco_Produto";

        public string Script => $@"	
                                ALTER TABLE [dbo].[Produto_has_Preco]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdProduto])
                                REFERENCES [dbo].[Produto] ([Id])
                                ALTER TABLE [dbo].[Produto_has_Preco] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
