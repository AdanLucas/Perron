namespace Repository.ScriptBase.StoredProcedure
{
    public class PC_CadastroPreco : IScriptProcedure
    {
        public string GUID { get { return "8AE232B9-270F-4BAB-87FF-5A17F823B687"; } }
        public string Procedure { get { return "PC_CadastroPreco"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"CREATE PROCEDURE PC_CadastroPreco (@Id int,@IdTamanho int,@Preco decimal(6,2),@Ativo bit)
						AS
						BEGIN
						
						DECLARE @RET INT
						
							IF(EXISTS(SELECT 1 FROM Preco WHERE ID = COALESCE(@Id,0)))
							 BEGIN
							
								UPDATE Preco SET IDTamanho = @IdTamanho,Preco = @Preco,Ativo = @Ativo WHERE ID = @Id
						
								SET @RET = @Id;
							 END
						
							ELSE
							 BEGIN
								 INSERT INTO Preco (IDTamanho,Preco,Ativo)
								 VALUES (@IdTamanho,@Preco,@Ativo)
						
								 SET @RET = SCOPE_IDENTITY();
						
							 END
						
							SELECT @RET;
						
						
						END";
            }

        }
    }
}
