﻿namespace Repository.ScriptBase.Constraint
{
    public class FK_Sabor_has_Ingrediente_Ingrediente : IScriptConstraint
    {
        public string NomeConstraint => "FK_Sabor_has_Ingrediente_Ingrediente";

        public string Script =>
                        $@"ALTER TABLE [dbo].[Sabor_has_Ingrediente]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Ingrediente])
    					REFERENCES [dbo].[Mercadoria] ([Id])
    					
    					ALTER TABLE [dbo].[Sabor_has_Ingrediente] CHECK CONSTRAINT [{NomeConstraint}]
";
    }
}
