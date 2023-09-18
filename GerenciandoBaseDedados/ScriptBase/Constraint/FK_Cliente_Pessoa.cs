namespace Repository.ScriptBase.Constraint
{
    public class FK_Cliente_Pessoa : IScriptConstraint
    {
        public string NomeConstraint => "FK_Cliente_Pessoa";

        public string Script => $@"ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Id])
    					REFERENCES [dbo].[Pessoa] ([Id])
    					ALTER TABLE [dbo].[Pessoa] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
