namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_IngredienteTamanho_Sabor_has_Ingrediente : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_IngredienteTamanho_Sabor_has_Ingrediente";

        public string Script => $@"	ALTER TABLE [dbo].[Sabor_has_IngredienteTamanho]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([IdSaborIngrediente])
    					REFERENCES [dbo].[Sabor_has_Ingrediente] ([Id])
    					
    					ALTER TABLE [dbo].[Sabor_has_IngredienteTamanho] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
