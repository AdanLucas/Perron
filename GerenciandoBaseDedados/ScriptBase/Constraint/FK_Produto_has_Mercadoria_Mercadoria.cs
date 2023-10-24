namespace Repository.ScriptBase.Constraint
{
    public class FK_Produto_has_Mercadoria_Mercadoria : IScriptConstraint
    {
        public string NomeConstraint => "FK_Produto_has_Mercadoria_Mercadoria";

        public string Script =>
                        $@"ALTER TABLE [dbo].[Prduto_has_Mercadoria]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Mercadoria])
    					REFERENCES [dbo].[Mercadoria] ([Id])
    					
    					ALTER TABLE [dbo].[Prduto_has_Mercadoria] CHECK CONSTRAINT [{NomeConstraint}]
";
    }
}
