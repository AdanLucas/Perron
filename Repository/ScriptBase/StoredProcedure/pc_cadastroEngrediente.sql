Create Procedure pc_cadastroEngrediente @id int ,@descricao varchar(50),@ativo bit
as 

BEGIN

	IF(EXISTS(SELECT 1 FROM Engrediente WHERE ID = @id))
		BEGIN
	
		UPDATE Engrediente SET Descricao = @descricao,Ativo = @ativo
	 
		END

	ELSE
		BEGIN

			INSERT INTO Engrediente (Descricao,Ativo)
				             VALUES (@descricao,@ativo)

		END

END