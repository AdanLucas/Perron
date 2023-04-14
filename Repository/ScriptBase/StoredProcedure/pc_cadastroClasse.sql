create procedure pc_cadastroClasse @id int,@descricao varchar(50),@ativo bit
as
BEGIN

	IF(EXISTS(SELECT 1 FROM Classe WHERE ID = COALESCE(@id,0)))
	BEGIN

	UPDATE CLASSE SET Descricao = @descricao,Ativo = @ativo WHERE Id = @id

	END

	ELSE
	BEGIN

	INSERT INTO Classe (Descricao,Ativo)
				VALUES (@descricao,@ativo)

	END



END