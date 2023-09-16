namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_Engrediente_Engrediente : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_Engrediente_Engrediente";

        public string Script =>
                        $@"ALTER TABLE [dbo].[Sabor_has_Engrediente]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Engrediente])
    					REFERENCES [dbo].[Engrediente] ([Id])
    					
    					ALTER TABLE [dbo].[Sabor_has_Engrediente] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
