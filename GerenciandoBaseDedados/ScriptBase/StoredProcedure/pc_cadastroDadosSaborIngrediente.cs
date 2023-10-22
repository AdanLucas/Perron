namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroDadosSaborIngrediente : IScriptProcedure
    {
        public string GUID { get { return "F29D0EEA-EF95-4D2A-A998-1C83F9E53B12"; } }
        public string Procedure { get { return "pc_cadastroDadosSaborIngrediente"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE pc_cadastroDadosSaborIngrediente(@idSaborIngrediente int, @tamanho int,@qnt decimal(6,2),@unidadeMedida int,@ativo bit)
						AS
						
						BEGIN
						
							IF(EXISTS(SELECT 1 FROM Sabor_has_IngredienteTamanho WHERE IdSaborIngrediente = @idSaborIngrediente AND Tamanho = @tamanho))
								BEGIN
						
								UPDATE Sabor_has_IngredienteTamanho 
								       SET
									    Quantidade = @QNT,
										UnidadeMedida = @unidadeMedida,
										Ativo = @ativo 
										    WHERE IdSaborIngrediente = @idSaborIngrediente AND Tamanho = @tamanho
						
								END
						
							ELSE
						
								BEGIN
						
									INSERT INTO Sabor_has_IngredienteTamanho (Tamanho,Quantidade,UnidadeMedida,Ativo)
															      VALUES (@tamanho,@qnt,@unidadeMedida,@ativo)
								END
								
						
						END";
            }

        }
    }
}
