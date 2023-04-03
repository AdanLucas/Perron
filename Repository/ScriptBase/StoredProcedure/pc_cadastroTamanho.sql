create Procedure pc_cadastroDadosSaborEngrediente(@idSaborEngrediente int, @tamanho int,@qnt decimal(6,2),@unidadeMedida int,@ativo bit)
AS

BEGIN

	IF(EXISTS(SELECT 1 FROM Sabor_has_EngredienteTamanho WHERE IdSaborEngrediente = @idSaborEngrediente AND Tamanho = @tamanho))
		BEGIN

		UPDATE Sabor_has_EngredienteTamanho 
		       SET
			    Quantidade = @QNT,
				UnidadeMedida = @unidadeMedida,
				Ativo = @ativo 
				    WHERE IdSaborEngrediente = @idSaborEngrediente AND Tamanho = @tamanho

		END

	ELSE

		BEGIN

			INSERT INTO Sabor_has_EngredienteTamanho (Tamanho,Quantidade,UnidadeMedida,Ativo)
									      VALUES (@tamanho,@qnt,@unidadeMedida,@ativo)
		END
		

END