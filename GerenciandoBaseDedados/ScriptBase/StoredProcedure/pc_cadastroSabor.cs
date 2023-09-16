namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroSabor : IScriptProcedure
    {
        public string GUID { get { return "FB015B90-7566-431C-AA97-D793781708D8"; } }
        public string Procedure { get { return "pc_cadastroSabor"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"Create procedure pc_cadastroSabor(@id int,@descricao varchar(50),@idClasse int,@ativo bit)
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
                        
                        End";
            }

        }
    }
}
