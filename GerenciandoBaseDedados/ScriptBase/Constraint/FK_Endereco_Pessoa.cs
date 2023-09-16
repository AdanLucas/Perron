namespace Repository.ScriptBase.Constraint
{
    public class FK_Endereco_Pessoa : IScriptConstraint
    {
        public string NomeConstraint => "FK_Endereco_Pessoa";

        public string Script => $@"ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdPessoa])
    					            REFERENCES [dbo].[Pessoa] ([Id])
    					            ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
