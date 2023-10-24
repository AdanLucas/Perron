namespace Repository.ScriptBase.Constraint
{
    public class FK_Produto_Classe : IScriptConstraint
    {
        public string NomeConstraint => "FK_Produto_Classe";

        public string Script => $@"ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdClasse])
    					REFERENCES [dbo].[Classe] ([Id])
    					ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
