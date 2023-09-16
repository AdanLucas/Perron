namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_EngredienteTamanho_Sabor_has_Engrediente : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_EngredienteTamanho_Sabor_has_Engrediente";

        public string Script => $@"	ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdSaborEngrediente])
    					REFERENCES [dbo].[Sabor_has_Engrediente] ([Id])
    					
    					ALTER TABLE [dbo].[Sabor_has_EngredienteTamanho] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
