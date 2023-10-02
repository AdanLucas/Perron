namespace Repository.ScriptBase.Constraint
{
    public class FK_Funcionario_Pessoa : IScriptConstraint
    {
        public string NomeConstraint => "FK_Funcionario_Pessoa";

        public string Script => $@"ALTER TABLE [dbo].[Funcionario] WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Id])
    					REFERENCES [dbo].[Pessoa] ([Id])
    					ALTER TABLE [dbo].[Funcionario] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
