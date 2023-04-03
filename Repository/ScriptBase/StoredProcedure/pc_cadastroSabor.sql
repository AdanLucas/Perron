Create procedure pc_cadastroSabor(@id int,@descricao varchar(50),@idClasse int,@ativo bit)
as

begin

	If(Exists(select 1 from Sabor where Id = @id))
		begin

			update Sabor set Descricao = @descricao,IdClasse = @idClasse ,Ativo = @ativo where id = @id 
 
		end

	Else
		begin

			insert into Sabor (Descricao,IdClasse,Ativo)

			values (@descricao,@idClasse,@ativo)
 
		end

End