namespace Repository.ScriptBase.Constraint
{
    public class FK_Classe_has_Preco_Preco : IScriptConstraint
    {
        public string NomeConstraint => "FK_Classe_has_Preco_Preco";

        public string Script => $@" ALTER TABLE [dbo].[Classe_has_Preco]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdPreco])
                                    REFERENCES [dbo].[Preco] ([Id])
                                    ALTER TABLE [dbo].[Classe_has_Preco] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
