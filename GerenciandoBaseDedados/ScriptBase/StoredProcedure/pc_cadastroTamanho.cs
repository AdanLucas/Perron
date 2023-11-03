namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroTamanho : IScriptProcedure
    {
        public string GUID { get { return "37DC2640-7FFF-4C84-A5DF-B2478654F233"; } }
        public string Procedure { get { return "pc_cadastroTamanho"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE [dbo].[pc_cadastroTamanho] (@id int,@descricao varchar (50),@Quantidade int,@TipoQuantidade int,@ativo bit)
                            AS
                            
                            BEGIN
                            
                            	IF(EXISTS(SELECT 1 From Tamanho Where ID = Coalesce(@id,0)))
                            
                            		BEGIN
                            
                            		UPDATE Tamanho SET Descricao = @descricao,Quantidade = @Quantidade, TipoQuantidade = @TipoQuantidade,ATIVO = @ativo WHERE ID = @id
                            
                            		END
                            
                            	ELSE
                            
                            		BEGIN
                            
                            		INSERT INTO Tamanho (Descricao,Quantidade,TipoQuantidade,ATIVO)
                            					                 VALUES(@descricao,@Quantidade,@TipoQuantidade,@ativo)
                            
                            		END
                            END";
            }

        }
    }
}
