namespace Repository.ScriptBase.Constraint
{
    public class FK_Produto_has_Preco_Preco : IScriptConstraint
    {
        public string NomeConstraint => "FK_Produto_has_Preco_Preco";

        public string Script => $@"	ALTER TABLE [dbo].[Produto_has_Mercadoria]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Produto])
    					REFERENCES [dbo].[Produto] ([Id])
    					
    					ALTER TABLE [dbo].[Produto_has_Mercadoria] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
