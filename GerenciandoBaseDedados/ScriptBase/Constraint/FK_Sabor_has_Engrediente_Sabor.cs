namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_Engrediente_Sabor : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_Engrediente_Sabor";

        public string Script => $@"	ALTER TABLE [dbo].[Sabor_has_Engrediente]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Sabor])
    					REFERENCES [dbo].[Sabor] ([Id])
    					
    					ALTER TABLE [dbo].[Sabor_has_Engrediente] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
