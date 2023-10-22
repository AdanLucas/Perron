namespace Repository.ScriptBase.StoredProcedure
{
    internal class pc_cadastroIngrediente : IScriptProcedure
    {
        public string GUID { get { return "229A15BF-4725-4867-AA7C-6F8C44ECB87A"; } }
        public string Procedure { get { return "pc_CadastroMercadoria"; } }

        public string ScriptPrcedured
        {
            get
            {
                return $@"Create Procedure {Procedure} @id int ,@descricao varchar(50),@tipoMedida int,@ativo bit
                          as 
                          
                          BEGIN
                          
                          	IF(EXISTS(SELECT 1 FROM Mercadoria WHERE ID = @id))
                          		BEGIN
                          	
                          		UPDATE Mercadoria SET Descricao = @descricao,TipoMedida = @tipoMedida ,Ativo = @ativo where Id = @Id
                          	 
                          		END
                          
                          	ELSE
                          		BEGIN
                          
                          			INSERT INTO Mercadoria (Descricao,TipoMedida,Ativo)
                          				             VALUES (@descricao,@tipoMedida,@ativo)
                          
                          		END
                          
                          END";
            }

        }
    }
}
