namespace Repository.ScriptBase.Constraint
{
    public class FK_DadosMercadoriaProduto_Tamanho : IScriptConstraint
    {
        public string NomeConstraint => "FK_DadosMercadoriaProduto_Tamanho";

        public string Script => $@"	ALTER TABLE [dbo].[DadosMercadoriaProduto]  WITH CHECK ADD  CONSTRAINT [{NomeConstraint}] FOREIGN KEY([Tamanho])
    					REFERENCES [dbo].[Tamanho] ([Id])
    					ALTER TABLE [dbo].[DadosMercadoriaProduto] CHECK CONSTRAINT [{NomeConstraint}]";
    }
}
