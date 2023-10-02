namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_Ingrediente_Sabor : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_Ingrediente_Sabor";

        public string Script => $@"	ALTER TABLE [dbo].[Sabor_has_Ingrediente]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Sabor])
    					REFERENCES [dbo].[Sabor] ([Id])
    					
    					ALTER TABLE [dbo].[Sabor_has_Ingrediente] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
