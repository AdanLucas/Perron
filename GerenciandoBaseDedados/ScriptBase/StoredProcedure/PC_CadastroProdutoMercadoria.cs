namespace Repository.ScriptBase.StoredProcedure
{
    internal class PC_CadastroProdutoMercadoria : IScriptProcedure
    {
        public string GUID { get { return "84B5EE0B-17E1-49E9-A2FA-A460CDE62B2E"; } }
        public string Procedure { get { return "PC_CadastroProdutoMercadoria"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE [dbo].[PC_CadastroProdutoMercadoria](@IDProduto int,@IdMercadoria int,@Ativo bit)
                            AS
                            BEGIN
                            declare @ret int
                            
                            	IF(EXISTS(SELECT 1 FROM Produto_has_Mercadoria WHERE Produto = @IDProduto AND Mercadoria = @IdMercadoria))
                            	    BEGIN
                            	        UPDATE Produto_has_Mercadoria SET Ativo = @Ativo  WHERE Produto = @IDProduto AND Mercadoria = @IdMercadoria
                            	    END
                            	ELSE
                            
                            	BEGIN
                            	IF(@Ativo = 1)
                            		BEGIN
                            			INSERT INTO Produto_has_Mercadoria (Produto,Mercadoria,Ativo) VALUES (@IDProduto,@IdMercadoria,@Ativo)
                            		END
                            	END
                            END
                                ";
            }

        }
    }
}
