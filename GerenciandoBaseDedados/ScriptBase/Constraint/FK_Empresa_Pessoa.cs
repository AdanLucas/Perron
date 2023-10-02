namespace Repository.ScriptBase.Constraint
{
    public class FK_Empresa_Pessoa : IScriptConstraint
    {
        public string NomeConstraint => "FK_Empresa_Pessoa";

        public string Script => $@"ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Id])
    					REFERENCES [dbo].[Pessoa] ([Id])
    					ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
