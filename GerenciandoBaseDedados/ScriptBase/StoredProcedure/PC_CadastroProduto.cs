namespace Repository.ScriptBase.StoredProcedure
{
    internal class PC_CadastroProduto : IScriptProcedure
    {
        public string GUID { get { return "FB015B90-7566-431C-AA97-D793781708D8"; } }
        public string Procedure { get { return "PC_CadastroProduto"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE PC_CadastroProduto(@id int,@descricao varchar(50),@idClasse int,@ativo bit)
                            AS
                            BEGIN
                            
                            declare @ret int 
                                            
                             	If(Exists(select 1 from Produto where Id = @id))
                             		BEGIN
                             			update Produto set Descricao = @descricao,IdClasse = @idClasse ,Ativo = @ativo where id = @id 
                            			set @ret = @id
                             		END
                             
                             	ELSE
                             		BEGIN
                             
                             			insert into Produto (Descricao,IdClasse,Ativo)
                             			values (@descricao,@idClasse,@ativo)
                            
                            			set @ret = SCOPE_IDENTITY()
                            
                             		END
                             
                             select @ret;
                            
                             END";
            }

        }
    }
}
