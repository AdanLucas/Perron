namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroSaborIngrediente : IScriptProcedure
    {
        public string GUID { get { return "84B5EE0B-17E1-49E9-A2FA-A460CDE62B2E"; } }
        public string Procedure { get { return "pc_CadastroSaborIngrediente"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE [dbo].[pc_cadastroSaborIngrediente](@IDSabor int,@IDIngrediente int,@Ativo bit)
                            AS
                            BEGIN
                            declare @ret int
                            
                            	IF(EXISTS(SELECT 1 FROM Sabor_has_Ingrediente WHERE Sabor = @IDSabor AND Engrediente = @IDEngrediente))
                            	    BEGIN
                            	        UPDATE Sabor_has_Ingrediente SET Ativo = @Ativo  WHERE Sabor = @IDSabor AND Engrediente = @IDEngrediente
                            	    END
                            	ELSE
                            
                            	BEGIN
                            	IF(@Ativo = 1)
                            		BEGIN
                            			INSERT INTO Sabor_has_Ingrediente (Sabor,Engrediente,Ativo) VALUES (@IDSabor,@IDEngrediente,@Ativo)
                            		END
                            	END
                            END";
            }

        }
    }
}
