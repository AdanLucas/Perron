namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_IngredienteTamanho_Tamanho : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_IngredienteTamanho_Tamanho";

        public string Script => $@"	ALTER TABLE [dbo].[Sabor_has_IngredienteTamanho]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Tamanho])
    					REFERENCES [dbo].[Tamanho] ([Id])
    					ALTER TABLE [dbo].[Sabor_has_IngredienteTamanho] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
