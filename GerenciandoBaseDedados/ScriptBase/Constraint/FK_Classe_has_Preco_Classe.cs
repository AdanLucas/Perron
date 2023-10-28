namespace Repository.ScriptBase.Constraint
{
    public class FK_Classe_has_Preco_Classe : IScriptConstraint
    {
        public string NomeConstraint => "FK_Classe_has_Preco_Classe";

        public string Script => $@" ALTER TABLE [dbo].[Classe_has_Preco]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdClasse])
                                    REFERENCES [dbo].[Classe] ([Id])
                                    ALTER TABLE [dbo].[Classe_has_Preco] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
